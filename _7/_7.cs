namespace _7
{
	internal class _7
	{
		static void Main(string[] args)
		{
			Console.Write("inter the total days that u were in this earth : ");
			int days = Convert.ToInt32(Console.ReadLine());
			int getYears = GetYear(days);
			int getMonths = GetMonth(days, getYears);
			int getWeeks = GetWeek(days, getMonths, getYears);
			int getdays = GetDays(days, getMonths, getYears, getWeeks);
			Console.WriteLine($"you were in this world for about {getYears} years and {getMonths} months and {getWeeks} weeks and {getdays} days ");
		}

		private static int GetDays(int days, int getMonths, int getYears, int getWeeks)
		{
			return (days - ((getYears * 365) + (getMonths * 30) + (getWeeks * 7)));
		}

		private static int GetWeek(int days, int getMonths, int getYears)
		{
			var week = days - ((getMonths * 30) + (getYears * 365));
			var re = week % 7;
			re = (week - re) / 7;
			return re;
		}

		private static int GetMonth(int days, int getYears)
		{
			var month = days - getYears * 365;
			var re = month % 30;
			re = (month - re) / 30;
			return (re);
		}

		private static int GetYear(int days)
		{
			var age = days % 365;
			var year = (days - age) / 365;
			return year;
		}
	}
}