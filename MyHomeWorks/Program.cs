namespace MyHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("witch one of my homeworks u wish to see ? : ");
            int homeworkNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("..............................................");
            switch (homeworkNumber)
            {
                case 1:
                    Console.WriteLine("the bool test in str output \n******************************************************* ");
                    _1st();
                    Console.WriteLine("........................................");
                    break;
                case 2:
                    Console.WriteLine("part one triangel \n*************************************************************");
                    Triangle();
                    Console.WriteLine(".........................................");
                    Console.WriteLine("part 2\n************************************************************************");
                    MathAbsSqrtPow();
                    Console.WriteLine("..........................................");
                    break;


                default:
                    break;
            }
        }

        private static void _1st()
        {
            bool content = true;
            bool nocontent = false;
            Console.WriteLine($"the test is {content}");
            Console.WriteLine($"the test is {nocontent}");
            Console.WriteLine("the test is {0}", content);
            Console.WriteLine("the test is {0}", nocontent);
        }

        private static void Triangle()
        {
            Console.Write("inter number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + c > b && a + b > c && b + c > a)
            {
                Console.WriteLine($"the triangle is formed with the primeter of => '{Perimeter(a, b, c)}'");
            }
            else
                Console.WriteLine("triangle is not formed");
        }

        private static double Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        private static void MathAbsSqrtPow()
        {
            Console.Write("inter number : ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter number : ");
            double y = Convert.ToInt32(Console.ReadLine());
            double abs = Math.Abs(x - y);
            double pow = Math.Pow(abs, Math.Abs(y));
            double sqrt = Math.Sqrt(pow);
            Console.WriteLine($"the abs of ( x - y ) is => {abs} \nthe pow of ( ( x - y ) ^ y ) is  => {pow} \nthe final answer is => {sqrt}");

        }
    }
}