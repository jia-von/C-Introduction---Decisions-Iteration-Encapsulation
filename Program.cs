using System;

namespace Projects_25_Jun_2020
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Assignment on 25-Jun-2020: Problem 1 
            //Telling user to input value
            Console.WriteLine("User please add integer: ");

            //Convert user input value to integer
            int firstNum = Int32.Parse( Console.ReadLine());

            //Display answer that int ^3
            //Math.Power method @https://stackoverflow.com/questions/3034604/is-there-an-exponent-operator-in-c
            //Conver integer to string @https://stackoverflow.com/questions/26243602/cannot-implicity-convert-type-double-to-string
            string result = Math.Pow(firstNum, 3).ToString();
            Console.WriteLine(result);
        
        
        }
    }
}
