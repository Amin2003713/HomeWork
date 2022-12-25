namespace _3
{
    internal class _3
    {
        static void Main(string[] args)
        {
            Console.Write("inter number : ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter number : ");
            double y = Convert.ToInt32(Console.ReadLine());
            double abs = Math.Abs(x - y);
            double pow = Math.Pow(abs, Math.Abs(y));
            double sqrt = Math.Sqrt(pow);
            Console.WriteLine("the abs of ( x - y ) is => {0} \nthe pow of ( ( x - y ) ^ y ) is  => {1} \nthe final answer is => {2}", abs, pow, sqrt);
        }
    }
}