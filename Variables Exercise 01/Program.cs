using System.Collections.Generic;
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


            const string myName = "Jose";
            const char grade = 'A';
            bool jobInTech = true;
            const int weeks = 9;
            double salary = 65000;
            decimal endSalary = 150000;

            Console.WriteLine($"{myName} is enjoying class hopefuly passing with an {grade}.");
            Console.WriteLine($" The class with take {weeks} and it is {jobInTech} that I want a coding job.");
            Console.WriteLine($"Hopefully with a starting salary of a minimum {salary} but with potential to earn more than {endSalary}.");
        }
    }
}