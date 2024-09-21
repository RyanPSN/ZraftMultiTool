using System;

namespace LearnCSharp
{
    public class Program
    {
        public static bool isActive = false;
        public static float amount;
        
        public static void Main(string[] args)
        {
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
                    
                    switch(option)
                    {
                        case "Yearly":

                            Console.WriteLine("Enter Amount 1: ");
                            var AmountOne = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount 2: ");
                            var AmountTwo = Convert.ToInt32(Console.ReadLine());

                            amount = AmountOne * AmountTwo;
                            Console.WriteLine($"You Will Have: ${amount}");
                            Console.ReadLine();
                            break;

                        case "Options":
                            Console.WriteLine("1: Yearly");
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