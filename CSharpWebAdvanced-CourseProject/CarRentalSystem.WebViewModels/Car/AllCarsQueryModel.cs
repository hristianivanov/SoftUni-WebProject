﻿namespace CarRentalSystem.Web.ViewModels.Car
{
	using System.ComponentModel.DataAnnotations;

	using Enums;

	using static Common.GeneralApplicationConstants;

	public class AllCarsQueryModel
	{
		public AllCarsQueryModel()
		{
			this.CurrentPage = DefaultPage;
			this.CarsPerPage = EntitiesPerPage;
			this.Makes = new HashSet<string>();
			this.Cars = new HashSet<CarAllViewModel>();
			this.Transmissions = new string[]
			{
				"Auto", "Manual"
			};
		}

		public string? Make { get; set; }
		[Display(Name = "Search by word")]
		public string? SearchString { get; set; }
		public string? Transmission { get; set; }
		[Display(Name = "Sort Cars By")]
		public CarSorting CarSorting { get; set; }
		public int CurrentPage { get; set; }
		public int TotalCarsCount { get; set; }
		[Display(Name = "Show Cars On Page")]
		public int CarsPerPage { get; set; }
		public string[] Transmissions { get; set; }
		public IEnumerable<string> Makes { get; set; }
		public IEnumerable<CarAllViewModel> Cars { get; set; }
	}
}
