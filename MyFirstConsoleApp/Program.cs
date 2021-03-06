using System;
using System.Collections.Generic;
// we needed to import this to create a list

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //get data from a user
            Console.WriteLine("please enter your name...");
            name = Console.ReadLine();

            //this will not work bc static types. you can change value but not type
            //name = 12;

            //this is for whole numbers aka integers
            //this is a 32 bit declaration. use long for really really big numbers
            int favoriteNumber = 12;

            //64 bit signed number
            //you can use underscores instead of commas
            long longNumber = 922_345_678_987;

            //16 bit signed number
            short shortNumber = 32_767;

            //ushort means you don't care about the negatives, so you get twice the positives

            //stuff with decimals decimals are more precise double is more general
            double accountBalance = 0.57d;
            decimal accountBalanceDec = 0.57M;


            //type inference
            var myStuff = 5 * 5;

            //booleans
            bool isTired = true;
            var isHungry = false;

            //datetime
            var today = new DateTime(2021, 7, 13);

            today = DateTime.Today;

            //initializing an array. this is an array of up to 5 strings. lists are used more commonly
            //var students = new string[5];

            //all variable names must be camelCase

            //lists
            //tell the list what's gonna be in it
            //new keyword creates new instance
            var students = new List<string>();

            students.Add("Hunter");
            students.Add("Rob");
            students.Add("Jimbo");

            students.Remove("Jimbo");

            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            //or

            //more idomatic and convenient
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //if blocks are identical in JS and C# but there is no triple equality. = for set == for comparison
        }
    }
}
