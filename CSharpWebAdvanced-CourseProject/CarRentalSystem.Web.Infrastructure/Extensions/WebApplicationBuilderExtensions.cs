﻿namespace CarRentalSystem.Web.Infrastructure.Extensions
{
	using System.Reflection;

	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.Extensions.DependencyInjection;

	using Data.Models;
	using Middlewares;

	using static Common.GeneralApplicationConstants;

	public static class WebApplicationBuilderExtensions
	{
		/// <summary>
		/// This method registers all services with their interfaces and implementations of given assembly.
		/// The assembly is taken from the type of any service implementation provided.
		/// </summary>
		/// <param name="serviceType"></param>
		/// <exception cref="InvalidOperationException"></exception>
		public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
		{
			Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
			if (serviceAssembly == null)
			{
				throw new InvalidOperationException("Invalid service type provided!");
			}

			Type[] serviceTypes = serviceAssembly
				.GetTypes()
				.Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
				.ToArray();

			foreach (Type implementationType in serviceTypes)
			{
				Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}");

				if (interfaceType == null)
				{
					throw new InvalidOperationException($"No interface is provided for the service with name: {implementationType.Name}");
				}

				services.AddScoped(interfaceType, implementationType);
			}

		}

		/// <summary>
		/// This method seed admin role if it does not exist.
		/// Passed email should be valid email of existing user in the application.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="email"></param>
		/// <returns></returns>
		public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
		{
			using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

			IServiceProvider serviceProvider = scopedServices.ServiceProvider;

			UserManager<ApplicationUser> userManager =
				serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
			RoleManager<IdentityRole<Guid>> roleManager =
				serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

			Task.Run(async () =>
				{
					if (await roleManager.RoleExistsAsync(AdminRoleName))
					{
						return;
					}

					IdentityRole<Guid> role =
						new IdentityRole<Guid>(AdminRoleName);

					await roleManager.CreateAsync(role);

					ApplicationUser adminApplicationUser =
						await userManager.FindByEmailAsync(email);

					await userManager.AddToRoleAsync(adminApplicationUser, AdminRoleName);
				})
				.GetAwaiter()
				.GetResult();

			return app;
		}

		public static IApplicationBuilder EnableOnlineUsersCheck(this IApplicationBuilder app)
		{
			return app.UseMiddleware<OnlineUsersMiddleware>();
		}
	}
}
