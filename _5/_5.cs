namespace _5
{
	internal class _5
	{
		static void Main(string[] args)
		{
			Console.Write("inter a : ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write($"inter b : ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write($"inter c i");
			int c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"finding the root of {a}(x^2) + {b}x + {c} ....");
			CalTheRoot(a, b, c);
		}

		private static void CalTheRoot(int a, int b, int c)
		{
			double delta = Math.Pow(b, 2) - (4 * a * c);
			if (delta > 0)
			{
				double x = (((-b) + Math.Sqrt(delta)) / (2 * a));
				double y = (((-b) - Math.Sqrt(delta)) / (2 * a));
				Console.WriteLine("x1 is {0} and x2 is {1}", x, y);
			}
			else if (delta == 0)
			{
				double x = ((-b) / (2 * a));
				Console.WriteLine("x1 is {0} and x2 is Undifine", x);
			}
			else
			{
				Console.WriteLine(" x1 is undefined" + "x2 is undefined");
			}
		}

	}
}