namespace _4
{
	internal class _4
	{
		static void Main(string[] args)
		{
			Console.Write("inter the first number : ");
			var a = Convert.ToInt32(Console.ReadLine());
			Console.Write("inter the seconde number : ");
			var b = Convert.ToInt32(Console.ReadLine());
			var GCD = GetGreatestDivisor(a, b);
			var LCM = GetLCM(a, b, GCD);
			Console.WriteLine("the b.m.m of {0} and {1} is => {2}\nthe K.m.m of {0} and {1} is => {3}", a, b, GCD, LCM);
		}

		private static int GetLCM(int a, int b, int gCD)
		{
			return (Math.Abs(a * b) / gCD);
		}

		static int GetGreatestDivisor(int a, int b)
		{
			while (b != 0)
			{
				var oldB = b;
				b = a % b;
				a = oldB;
			}
			return a;

		}

	}
}