namespace _8
{
    internal class _8
    {
        static void Main(string[] args)
        {
            Console.Write("inter a number and i will tell u the x^2 and x^3 : "); ;
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the {x}^2 is => {Math.Pow(x, 2)} \nthe {x}^3 is =>{Math.Pow(x, 3)}");
        }
    }
}