namespace _6
{
    internal class _6
    {
        static void Main(string[] args)
        {
            Console.Write("inter ur bank Account balance : ");
            double mojody = Convert.ToDouble(Console.ReadLine());
            Console.Write("inter the yearly bounes persent : ");
            double bahre = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter the wanted balance to see how many years u need till u reach that : ");
            int hadaf = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (hadaf >= mojody)
            {
                mojody = ((mojody * bahre / 100)) + mojody;
                i++;
            }
            Console.WriteLine("=>\nu must waite {0} years to diposit ur curency", i);
        }
    }
}