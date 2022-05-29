using System;

namespace homework008
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput;
            while (true) 
            {
                Console.Write("password: ");
                userInput = Console.ReadLine();
                if (password  == userInput)
                {
                    Console.WriteLine("the end ");
                }
            }
        }
        }       
    }
