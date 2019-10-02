using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040Assignment2
{
    class Triangle
    {
        public static int ValidateMenuSelection()

        {
            string userInput = "";
            bool validMenuselect = false;

            while (validMenuselect == false)
            {
                Console.WriteLine("1 = Enter Triangle Dimension");
                Console.WriteLine("2 = Exit \n");
                Console.WriteLine("Please Select an option, by Entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                   userInput != "2")
                {
                    Console.WriteLine("Plese Enter the vaild option from the Menu :\n");

                }
                else
                {
                    validMenuselect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }
        public static int ValidateUserInput(string triangleside)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"please Enter the {triangleside} of your Triangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number Cannot be less than 0 please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {triangleside} of your triangle is now:{number}\n");
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            int selection;
            selection = ValidateMenuSelection();
            while (selection != 2)
            {
                switch (selection)
                {
                    case 1:
                        int sideA = ValidateUserInput("Side A");
                        int sideB = ValidateUserInput("Side B");
                        int sideC = ValidateUserInput("Side C");
                        String ans = TriangleSolver.Analyze(sideA, sideB, sideC);
                        Console.WriteLine(ans);
                        break;

                    default:
                        break;
                }
                selection = ValidateMenuSelection();
            }
        }


    }

}

