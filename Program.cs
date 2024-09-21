using System;

namespace LearnCSharp
{
    public class GetAmount
    {
        public float xPrice;
        public float yPrice;

        public void getMainAmount(float a, float b)
        {
            float calc = a * b;

            Console.WriteLine($"You Will Have: ${calc}");
            Console.ReadLine();
        }


    }

    public class CalculateWage
    {
        public static float xPos;
        public static float yPos;

        public void GetWageCalculation(double a, double b, double c, double d)
        {

            double wage = a * b * c * d;
            Console.WriteLine($"You Will Have ${wage} in 1 Year");

            Console.ReadLine();
        }
    }

    public class Program
    {
        public static bool isActive = false;
        public static float amount = 0.0f;
        public static double wage;
        public static double hour;
        public static double days;
        public static double weeks;
        
        public static void Main(string[] args)
        {
            GetAmount M = new GetAmount();
            CalculateWage c = new CalculateWage();

            if (args.Length == 0)
            {

                while (!isActive)
                {

                    Console.WriteLine(" - Welcome to Name Project");

                    Console.WriteLine("Enter Your Name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine($"Hello {name}");

                    Console.WriteLine("Enter Option: ");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "Monthly":

                            Console.WriteLine("Enter Amount 1: ");
                            M.xPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount 2: ");
                            M.yPrice = Convert.ToInt32(Console.ReadLine());


                            M.getMainAmount(M.xPrice, M.yPrice);

                            Console.ReadLine();
                            break;




                        case "Options":
                            Console.WriteLine("1: Yearly");
                            Console.ReadLine();
                            break;



                        case "/Yearly":
                            Console.WriteLine("Enter Wage: ");
                            wage = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Days: ");
                            days = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Hours: ");
                            hour = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Weeks: ");
                            weeks = Convert.ToDouble(Console.ReadLine());
                            c.GetWageCalculation(wage, days, hour, weeks);
                            Console.ReadLine();
                            break;

                    }

                    Console.ReadKey();

                    isActive = true;
                }

            }
         

        }

    }
}