﻿namespace CarRentalSystem.Web.Controllers
{
	using Microsoft.AspNetCore.Authentication;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Caching.Memory;

	using Data.Models;
	using ViewModels.User;
	using static Common.NotificationMessagesConstants;
	using static Common.GeneralApplicationConstants;

	public class UserController : Controller
	{
		private readonly SignInManager<ApplicationUser> signInManager;
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IMemoryCache memoryCache;

		public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager,
			IMemoryCache memoryCache)
		{
			this.signInManager = signInManager;
			this.userManager = userManager;

			this.memoryCache = memoryCache;
		}

		[HttpGet]
		public IActionResult Register(string returnUrl = null)
		{
			if (User.Identity!.IsAuthenticated)
			{
				Response.Redirect("/");
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterFormModel model)
		{
			if (!ModelState.IsValid)
			{
				return this.View();
			}

			ApplicationUser applicationUser = new ApplicationUser()
			{
				Email = model.Email,
				FirstName = model.FirstName,
				LastName = model.LastName,
			};

			await this.userManager.SetEmailAsync(applicationUser, model.Email);
			await this.userManager.SetUserNameAsync(applicationUser, model.Email);

			var result =
				await this.userManager.CreateAsync(applicationUser);

			if (!result.Succeeded)
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}

				return this.View(model);
			}

			await this.signInManager.SignInAsync(applicationUser, isPersistent: false);
			this.memoryCache.Remove(UsersCacheKey);

			return this.RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public async Task<IActionResult> Login(string? returnUrl = null)
		{
			if (User.Identity!.IsAuthenticated)
			{
				Response.Redirect("/");
			}

			await this.HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

			LoginFormModel model = new LoginFormModel()
			{
				ReturnUrl = returnUrl,
			};

			return this.View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginFormModel model)
		{
			if (!ModelState.IsValid)
			{
				return this.View(model);
			}

			var result = await this.signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,
				lockoutOnFailure: false);

			if (!result.Succeeded)
			{
				this.TempData[ErrorMessage] = "There was an error while logging you in! Please try again or contact an administrator!";

				return this.View(model);
			}

			return this.Redirect(model.ReturnUrl ?? "/Home/Index");
		}
	}
}