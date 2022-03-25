using System;

namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts

            #region Types
            // string
            // char
            // bool
            // int
            // double
            // decimal
            #endregion
            string myName = "Brittany";
            char midInitial = 'J';
            bool isMarried = true;
            int myAge = 25;
            double myWeight = 165.33;
            decimal myAccount = 500.25m;

            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 

            // TODO: Initialize each of the variables with a value

            // TODO: Write out each of the variables to the Console 
            Console.WriteLine($"Hello my name is {myName}, I am {myAge} years old.");
            Console.WriteLine($"Its {isMarried} I'm married with {myAccount} in the bank");
        }

    }
}
