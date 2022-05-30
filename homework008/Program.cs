using System;

namespace homework008
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput;
            do
            {
                Console.Write("password: ");
                userInput = Console.ReadLine();
            }
            while { password != userInput };
        }
        }       
    }
