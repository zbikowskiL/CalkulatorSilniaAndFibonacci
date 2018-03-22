using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkulatorSilniaAndFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opc1 = "Please choose 1, if You want to calculate Silnia.";
            string opc2 = "Please choose 2, if You want to calculate Fibonacci number.";
            string opc3 = "Please choose 0, if You want to exit.";

            string s_user_selection;
            int n_user_selection;
            string close;
            int value;

            programOptions(opc1, opc2, opc3);
            s_user_selection = Console.ReadLine();

            do
            {
                while (string.IsNullOrEmpty(s_user_selection))
                {
                    Console.WriteLine("Please, select options: 1, 2 or 3 and press enter.");
                    programOptions(opc1, opc2, opc3);
                    s_user_selection = Console.ReadLine();
                }

                while (!int.TryParse(s_user_selection, out n_user_selection))
                {
                    Console.WriteLine("Please, select options: 1, 2 or 3 and press enter.");
                    programOptions(opc1, opc2, opc3);
                    s_user_selection = Console.ReadLine();
                }

                switch (n_user_selection)
                {
                    case 0:
                        Console.WriteLine("Your choice 0. Press enter to exit the program.");
                        Console.ReadKey();
                        break;

                    case 1:
                        string s_entered_value;
                        Console.WriteLine("Please, enter number for calculate silnia: ");

                        s_entered_value = Console.ReadLine();

                        while (!int.TryParse(s_entered_value, out value))
                        {
                            Console.WriteLine("Please, enter number for calculate silnia: ");
                            s_entered_value = Console.ReadLine();
                        }


                        Console.WriteLine($"Silnia for {value} is equal: {Silnia.RekurentCalculateSilnia(value)}");
                        Console.WriteLine("Do You want to leave the program ? Yes/NO.");
                        close = Console.ReadLine().ToUpper();
                        if (close == "YES")
                        {
                            n_user_selection = 0;
                            Console.WriteLine("Press enter to exit the program.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Please, select options: 1, 2 or 3 and press enter.");
                            programOptions(opc1, opc2, opc3);
                            s_user_selection = Console.ReadLine();
                        }
                        break;

                    case 2:

                        Console.WriteLine("Please enter the Fibonacci number that You would like to find:");
                        s_entered_value = Console.ReadLine();

                        while (!int.TryParse(s_entered_value, out value))
                        {
                            Console.WriteLine("Please enter the Fibonacci number that You would like to find: ");
                            s_entered_value = Console.ReadLine();
                        }

                        Console.WriteLine("Fibonacci number for {0} is equal {1}.", value, Fibonacci.FibonacciNumber(value));
                        Console.WriteLine("Do You want to leave the program ? Yes/NO.");

                        close = Console.ReadLine().ToUpper();
                        if (close == "YES")
                        {
                            n_user_selection = 0;
                            Console.WriteLine("Press enter to exit the program.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Please, select options: 1, 2 or 3 and press enter.");
                            programOptions(opc1, opc2, opc3);
                            s_user_selection = Console.ReadLine();
                        }
                        break;

                    default:
                        Console.WriteLine("You entered the wrong option. Do You want to leave the program ? Yes/NO.");
                        close = Console.ReadLine().ToUpper();
                        if (close == "YES")
                        {
                            n_user_selection = 0;
                        }
                        else
                        {
                            Console.WriteLine("Please, select options: 1, 2 or 3 and press enter.");
                            programOptions(opc1, opc2, opc3);
                            s_user_selection = Console.ReadLine();
                        }
                        break;
                }

            } while (n_user_selection != 0);
        }

        public static void programOptions(string opc1, string opc2, string opc3)
        {
            Console.WriteLine(opc1);
            Console.WriteLine(opc2);
            Console.WriteLine(opc3);
        }

    }
}
