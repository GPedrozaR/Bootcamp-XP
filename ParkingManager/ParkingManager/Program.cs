using ParkingManager.Models;

namespace ParkingManager
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
							  "Digite o preço inicial:");

			var initialPrice = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine("Agora digite o preço por hora:");

			decimal hourlyPrice = Convert.ToDecimal(Console.ReadLine());

			var park = new Parking(initialPrice, hourlyPrice);

			var showMenu = true;
			while (showMenu)
			{
				Console.Clear();
				Console.WriteLine("Digite a sua opção:");
				Console.WriteLine("1 - Cadastrar veículo");
				Console.WriteLine("2 - Remover veículo");
				Console.WriteLine("3 - Listar veículos");
				Console.WriteLine("4 - Encerrar");

				switch (Console.ReadLine())
				{
					case "1":
						park.AddVehicle();
						break;

					case "2":
						park.RemoveVehicle();
						break;

					case "3":
						park.ListVehicles();
						break;

					case "4":
						showMenu = false;
						break;

					default:
						Console.WriteLine("Opção inválida");
						break;
				}

				Console.WriteLine("Pressione uma tecla para continuar");
				Console.ReadLine();
			}

			Console.WriteLine("O programa se encerrou");
		}
	}
}
