using System;

namespace Lab_10_VK_GC_April_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieList Tony = new MovieList();

            Console.WriteLine(Tony.GetType());

            //will print out the DEFAULT values of all of the properties of Tony
            //the DEFAULT values you see here are being set manually in the default constructor in
            //the Classmate class
            //If we didn't do that, the compiler would display the default C-SHARP values
            Console.WriteLine($"{Tony.Name} is from {Tony.HomeTown}. " +
                $"He was born on {Tony.Birthday}. " +
                $"His favorite number is {Tony.FavoriteNumber}. \n");

            //
            Tony.Name = "Tony Prosciutto";
            Tony.HomeTown = "Jersey";
            Tony.Birthday = DateTime.Parse("1/1/2001");
            Tony.FavoriteNumber = 1;

            //will print out Tony without the default values
            Console.WriteLine($"{Tony.Name} is from {Tony.HomeTown}. " +
            $"He was born on {Tony.Birthday.ToShortDateString()}. " +
            $"His favorite number is {Tony.FavoriteNumber}.");

            List<Classmate> classmates = new List<Classmate>();
            FillListOfClassmates(classmates);

            foreach (Classmate friend in classmates)
            {
                //print out the classmates
                friend.PrintClassmateInfo();
            }
        }
    }
}
