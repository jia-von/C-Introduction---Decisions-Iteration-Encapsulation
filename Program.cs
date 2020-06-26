using System;

namespace Projects_25_Jun_2020
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Assignment on 25-Jun-2020: Problem 1 
                //Write a program that prompts the user for a number (as an int) and outputs the cube of that number (raised to the third power).
                //Telling user to input value
                Console.WriteLine("User please add integer: ");

                //Convert user input value to integer
                int firstNum = Int32.Parse( Console.ReadLine());

                //Display answer that int ^3
                //Math.Power method @https://stackoverflow.com/questions/3034604/is-there-an-exponent-operator-in-c
                //Conver integer to string @https://stackoverflow.com/questions/26243602/cannot-implicity-convert-type-double-to-string
                string result = Math.Pow(firstNum, 3).ToString();
                Console.WriteLine(result);
        
    
            /*Assignment on Problem 2: Write a program that will take in a total dollar value (as a double) 
            and a number of diners (as an int) and calculate the amount of the bill that each diner should pay (equal split).
            */
                Console.WriteLine("Enter Dollar Value:");

                //Capture user input and convert user intput to double
                //@link: https://www.educba.com/convert-string-to-double-in-c-sharp/
                double myDouble = Convert.ToDouble( Console.ReadLine());

                //Display user input   
                Console.WriteLine("Is this the value: " + myDouble + "?");

                //Ask user to input 'number of diners'
                Console.WriteLine("Enter number of diners:");

                //Capture user input 'number of diners as int'
                int numDiner = Int32.Parse(Console.ReadLine());

                //Calculate the amount of the bill that each diner should play equally
                //Dollar amount rounded to 2 decimal point 
                //@link: https://stackoverflow.com/questions/257005/how-do-you-round-a-number-to-two-decimal-places-in-c
                Console.WriteLine("Each amount diner should pay:" + Math.Round(myDouble / numDiner, 2));

            /*Problem 3 for practice assignment: 
            Write a program that will take in a user’s age and calculate their birth year (assuming this year’s birthday has passed).
             */
                
    
        }

        private static double Double(string v)
        {
            throw new NotImplementedException();
        }
    }
}
