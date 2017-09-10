using System;

namespace Decision
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Type something and press enter");
           // string userValue;
          //  userValue = Console.ReadLine();
          //  Console.WriteLine("You typed: " + userValue);
         //   Console.ReadLine();

            //whatever user types in will be evaluated
            //assigns the variable "1" userValue = 1
            //evaluates the expression ... true or false? if(userValue) == 1)
            //else evaluates different conditions

            Console.WriteLine("would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            if(userValue == "1")
            {
                Console.WriteLine("You won a new car");
                Console.ReadLine();
            }
            else if(userValue == "2")
            {
                Console.WriteLine("You won a new boat");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a new cat");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You lose");
                Console.ReadLine();


            }
        }
    }
}
