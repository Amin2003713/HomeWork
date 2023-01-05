namespace _9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("inter hight if u have it :");
			var h = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("inter first side of ur shape : ");
			var rad = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("inter seconde side of ur shape : ");
			var r = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("u want the premiter of 1) cirlce 2) rectangle 3) square 4) Trapezius");
			var choise = Convert.ToInt32(Console.ReadLine());





			var primiter = new Premiter(rad, r, h);

			switch (choise)
			{
				case 1:
					Console.WriteLine(primiter.Circle());
					break;
				case 2:
					Console.WriteLine(primiter.Rectangale());
					break;
				case 3:
					Console.WriteLine(primiter.SquarePremiter());
					break;
				case 4:
					Console.WriteLine(primiter.Trapezius());
					break;
				default:
					Console.WriteLine("not Difined");
					break;
			}
		}
	}
}