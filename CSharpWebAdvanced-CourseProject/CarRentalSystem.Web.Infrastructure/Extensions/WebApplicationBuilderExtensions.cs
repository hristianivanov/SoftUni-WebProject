﻿namespace CarRentalSystem.Web.Infrastructure.Extensions
{
	using System.Reflection;

	using Microsoft.Extensions.DependencyInjection;

	using CarRentalSystem.Services.Data;
	using CarRentalSystem.Services.Data.Interfaces;

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

				services.AddScoped(serviceType, implementationType);
			}

			//TODO: see if that logic works and whether it need it ?
			services.AddScoped<ICarService, CarService>();
		}
	}
}
