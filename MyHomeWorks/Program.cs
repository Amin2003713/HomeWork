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
                case 3:
                    Console.WriteLine("part one age\n**************************************************************************");
                    CalAge();
                    Console.WriteLine("........................................");
                    Console.WriteLine("part two sqr and qube\n******************************************************************");
                    GetQube();
                    Console.WriteLine("........................................");
                    Console.WriteLine("part two smalest and larger commen multi\n******************************************************************");
                    GetLCMSCM();
                    Console.WriteLine("........................................");
                    Console.WriteLine("part two account add ups\n******************************************************************");
                    GetAccounting();
                    Console.WriteLine("........................................");
                    Console.WriteLine("part two finding the roots\n******************************************************************");
                    GetTheRoot();
                    Console.WriteLine("........................................");
                    break;
                default:
                    break;
            }
        }





        #region 3

        #region part 1
        private static void GetTheRoot()
        {
            Console.Write("inter a in ax^2 + bx + c : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"inter b in {a}x^2 + bx + c : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"inter c in {a}x^2 + {b}x + c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"finding the root of {a}(x^2) + {b}x + {c} ....");
            var x = CalTheRoot(a, b, c).x;
            var y = CalTheRoot(a, b, c).y;
            Console.WriteLine($"the roots of {a}(x^2) + {b}x + {c} is \nfirst => {x}\nSeconde is => {y}");
        }

        private static (string x, string y) CalTheRoot(int a, int b, int c)
        {
            var delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta > 0)
            {
                var x = (((-b) + Math.Sqrt(delta)) / (2 * a));
                var y = (((-b) - Math.Sqrt(delta)) / (2 * a));
                return (x.ToString(), y.ToString());
            }
            else if (delta == 0)
            {
                var x = (((-b) / (2 * a)));
                return (x.ToString(), "Undifine");
            }
            else
            {
                return ("undefined", "undefined");
            }
        }
        #endregion

        #region part 2
        private static void GetAccounting()
        {
            Console.Write("inter ur bank Account balance : ");
            var balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("inter the yearly bounes persent : ");
            var bounec = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter the wanted balance to see how many years u need till u reach that : ");
            int year = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (year >= balance)
            {
                balance = ((balance * bounec / 100)) + balance;
                i++;
            }
            Console.WriteLine($"=>\nu must waite {i} years to diposit ur curency");
        }
        #endregion

        #region part 3

        private static void CalAge()
        {
            Console.Write("inter the total days that u were in this earth : ");
            var days = Convert.ToInt32(Console.ReadLine());
            var getYears = GetYear(days);
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
            var re = Math.DivRem(week, 7);
            return re.Quotient;
        }

        private static int GetMonth(int days, int getYears)
        {
            var month = days - getYears * 365;
            var re = Math.DivRem(month, 30);
            return (re.Quotient);
        }

        private static int GetYear(int days)
        {
            var age = Math.DivRem(days, 365);
            return age.Quotient;
        }

        #endregion

        #region part 4

        private static void GetQube()
        {
            Console.Write("inter a number and i will tell u the x^2 and x^3 : "); ;
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the {x}^2 is => {Math.Pow(x, 2)} \nthe {x}^3 is =>{Math.Pow(x, 3)}");
        }

        #endregion

        #region part 5 


        private static void GetLCMSCM()
        {
            Console.Write("inter the first number : ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter the seconde number : ");
            var b = Convert.ToInt32(Console.ReadLine());
            var GCD = GetGreatestDivisor(a, b);
            var LCM = GetLCM(a, b, GCD);
            Console.WriteLine($"the b.m.m of {a} and {b} is => {GCD}\nthe K.m.m of {a} and {b} is => {LCM}");
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
        #endregion

        #endregion

        #region 2
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
        #endregion

        #region 1
        private static void _1st()
        {
            bool content = true;
            bool nocontent = false;
            Console.WriteLine($"the test is {content}");
            Console.WriteLine($"the test is {nocontent}");
            Console.WriteLine("the test is {0}", content);
            Console.WriteLine("the test is {0}", nocontent);
        }
        #endregion
    }
}