using System;
using System.Collections.Generic;

namespace _9998329_assessment3_question01
{
    class Program
    {
        //Creating a list for falconers and falcons
        static List<string> falconers = new List<string>{"Debbie", "Heidi", "Noel", "Melissa", "Kirsten", "Koshy"};
        static List<string> falcons = new List<string>{"Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo"};    
        static void Main(string[] args) //method
        {
           
           //Start the program with Clear();
           Console.Clear();           

            Console.WriteLine(DisplayFalconer());
            Console.WriteLine(DisplayFalconer());
            Console.WriteLine(DisplayFalconer());
            Console.WriteLine(DisplayFalconer());
            Console.WriteLine(DisplayFalconer());
            Console.WriteLine(DisplayFalconer());

           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();
           
           
        }
        //Generating random number
        static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);
        }
        static string DisplayFalconer()
        {   //declaring variables for falcons and falconers
            var selectFalcons = falcons[GenerateRandomNumber(falcons)];
            var selectFalconers = falconers[GenerateRandomNumber(falconers)];
            return $"Selected Falconer = {selectFalconers}\nSelected Falcon ={selectFalcons}";
        }
    }
}
