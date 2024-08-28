namespace ParkingManager.Models
{
	internal class Parking
	{
		/// <summary>
		/// </summary>
		/// <param name="initialPrice">Preço inicial</param>
		/// <param name="hourlyPrice">Preço por hora</param>
		public Parking(decimal initialPrice, decimal hourlyPrice)
		{
			InitialPrice = initialPrice;
			HourlyPrice = hourlyPrice;
		}

		private decimal InitialPrice { get; set; } = 0;
		private decimal HourlyPrice { get; set; } = 0;
		private List<string> Vehicles { get; set; } = [];

		public void AddVehicle()
		{
			Console.WriteLine("Digite a placa do veículo para estacionar:");

			var plate = Console.ReadLine() ?? "N/A";

			Vehicles.Add(plate);

			Console.WriteLine($"Veículo {plate} adicionado com sucesso.");
		}

		public void RemoveVehicle()
		{
			Console.WriteLine("Digite a placa do veículo para remover:");
			var plate = Console.ReadLine() ?? "N/A";

			if (!Vehicles.Exists(x => x.Equals(plate, StringComparison.OrdinalIgnoreCase)))
				Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
			else
			{
				Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

				if (!int.TryParse(Console.ReadLine(), out var hours))
					Console.WriteLine("Digite uma quantidade de horas válidas");

				decimal value = InitialPrice + (HourlyPrice * hours);

				Vehicles.Remove(plate);

				Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {value}");
			}
		}

		public void ListVehicles()
		{
			if (Vehicles.Count == 0)
			{
				Console.WriteLine("Não há veículos estacionados.");
				return;
			}

			Vehicles.ForEach(Console.WriteLine);
		}

	}
}
