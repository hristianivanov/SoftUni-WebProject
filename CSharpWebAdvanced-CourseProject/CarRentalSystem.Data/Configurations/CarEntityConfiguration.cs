﻿namespace CarRentalSystem.Data.Configurations
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	using Models;
	using Models.Enums;

	public class CarEntityConfiguration : IEntityTypeConfiguration<Car>
	{
		public void Configure(EntityTypeBuilder<Car> builder)
		{
			builder
				.Property(c => c.CreatedOn)
				.HasDefaultValueSql("GETDATE()");

			builder
				.Property(c => c.IsActive)
				.HasDefaultValue(true);

			builder.HasData(this.GenerateCars());
		}

		private ICollection<Car> GenerateCars()
		{
			var cars = new HashSet<Car>();

			cars.Add(new Car()
			{
				Id =  Guid.Parse("a6e93473-1479-442f-a73a-96a5f4f94b2f"),
				MakeId = 3,
				Model = "RS e-tron GT",
				BodyType = BodyType.Coupe,
				Transmission = Transmission.Auto,
				Acceleration = 2.9,
				Mileage = 5_000,
				HorsePower = 637,
				TopSpeed = 155,
				Year = 2021,
				Consumption = 20.2,
				ImageUrl = "https://www.cnet.com/a/img/resize/607531bf946fb55b78d58ddf654b802133f3aeb3/hub/2021/11/10/e0e04238-ff8d-4e5a-9cd7-1dca34ec7843/2022-audi-rs-e-tron-gt-ogi-1.jpg?auto=webp&fit=crop&height=675&width=1200",
				EngineType = EngineType.Electric, 
				PricePerDay = 420,
				Range = 298,
				Safety = 5,
				PassengerSeats = 5
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("e0076ee2-7eaa-4b5b-82cd-0e415b4df2dd"),
				MakeId = 3,
				Model = "A5 SB basic",
				BodyType = BodyType.Hatchback,
				Transmission = Transmission.Auto,
				Acceleration = 6.2,
				Mileage = 450_000,
				HorsePower = 261,
				TopSpeed = 126,
				Year = 2013,
				Consumption = 6.2,
				ImageUrl = "https://imagizer.imageshack.com/a/img29/5097/gu89.jpg",
				EngineType = EngineType.Diesel,
				PricePerDay = 329,
				Range = 520,
				Safety = 4,
				PassengerSeats = 5
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("0176c691-6be3-49bf-9399-42d8e9ebde86"),
				MakeId = 4,
				Model = "X6 40d",
				BodyType = BodyType.SUV,
				Transmission = Transmission.Auto,
				Acceleration = 5.5,
				Mileage = 53_000,
				HorsePower = 340,
				TopSpeed = 147,
				Year = 2012,
				Consumption = 7.1,
				ImageUrl = "https://avatars.mds.yandex.net/get-autoru-vos/5234682/06057d0f4b94a888f5c8112546a31a43/1200x900",
				EngineType = EngineType.Diesel,
				PricePerDay = 412,
				Range = 704,
				Safety = 4,
				PassengerSeats = 5
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("247ae983-4cf8-4881-951d-f39e66b8877e"),
				MakeId = 6,
				Model = "F430",
				BodyType = BodyType.Sport,
				Transmission = Transmission.Auto,
				Acceleration = 3.6,
				Mileage = 230_532,
				HorsePower = 483,
				TopSpeed = 196,
				Year = 2004,
				Consumption = 18.3,
				ImageUrl = "https://photos.carspecs.us/d389399428d2ba5d065c5b6f59aaf3771a41ca4b-2000.jpg",
				EngineType = EngineType.Diesel,
				PricePerDay = 620,
				Range = 323,
				Safety = 3,
				PassengerSeats = 2
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("5c85b4b3-10c9-4cec-b30b-ac226da7b60b"),
				MakeId = 2,
				Model = "Giulia",
				BodyType = BodyType.Sedan,
				Transmission = Transmission.Manual,
				Acceleration = 5.4,
				Mileage = 623_142,
				HorsePower = 280,
				TopSpeed = 191,
				Year = 2018,
				Consumption = 28.5,
				ImageUrl = "https://pbs.twimg.com/media/FxTMcyQWwAMqIYk?format=jpg&name=large",
				EngineType = EngineType.Diesel,
				PricePerDay = 205,
				Range = 464,
				Safety = 4,
				PassengerSeats = 5
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("b5cc05e9-2c12-4a5d-bccf-fc4a95ec04a6"),
				MakeId = 4,
				Model = "e60 M5",
				BodyType = BodyType.Sedan,
				Transmission = Transmission.Auto,
				Acceleration = 4.5,
				Mileage = 575_531,
				HorsePower = 500,
				TopSpeed = 190,
				Year = 2005,
				Consumption = 22.7,
				ImageUrl = "https://sun9-46.userapi.com/impg/jGF9KYUrkOJ81ExMSYNNE4L7fh4GD5Ryoic6zA/Iy6iwscdEg0.jpg?size=1920x1280&quality=95&sign=637909ae3d1112f8306502533c876ba3&c_uniq_tag=3K2cQHcDOmacj7mo5PNx7wX_XCN3EOQggqEfBc4h6iI&type=album",
				EngineType = EngineType.Diesel,
				PricePerDay = 130,
				Range = 293,
				Safety = 3,
				PassengerSeats = 5
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("65ee10ee-99dc-4265-b93a-ce5c5e954d63"),
				MakeId = 7,
				Model = "Camaro",
				BodyType = BodyType.Coupe,
				Transmission = Transmission.Manual,
				Acceleration = 4,
				Mileage = 10_531,
				HorsePower = 638,
				TopSpeed = 210,
				Year = 2011,
				Consumption = 26.32,
				ImageUrl = "https://img.remediosdigitales.com/c661b4/2018-chevrolet-camaro-zl1-1le-001p/1366_2000.jpg",
				EngineType = EngineType.Diesel,
				PricePerDay = 530.99m,
				Range = 503,
				Safety = 5,
				PassengerSeats = 2
			});
			cars.Add(new Car()
			{
				Id = Guid.Parse("3c5788d6-865f-456c-b23c-39c28cdfe131"),
				MakeId = 8,
				Model = "GT",
				BodyType = BodyType.Coupe,
				Transmission = Transmission.Auto,
				Acceleration = 3.2,
				Mileage = 22_931,
				HorsePower = 428,
				TopSpeed = 201,
				Year = 2014,
				Consumption = 29.32,
				ImageUrl = "https://cdn.motor1.com/images/mgl/vxoL0b/s1/2022-ford-gt-64-heritage-edition-04.jpg",
				EngineType = EngineType.Diesel,
				PricePerDay = 201.59m,
				Range = 302,
				Safety = 4,
				PassengerSeats = 2
			});

			return cars;
		}
	}
}
