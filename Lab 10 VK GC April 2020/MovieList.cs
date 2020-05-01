using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_VK_GC_April_2020
{

    class MovieList
    {
        //private fields - movie title, movie category
        //syntax - these start with a lower-case letter - Camel Case
        private string movieTitle;
        private string movieCategory;


        //public properties - getters & setters
        //because these are public, these are what we use to access the properties of an object
        //syntax - these start with an upper-case letter - Pascal Case
        public string MovieTitle
        {
            get //referenced when we call this property from an object 
            {
                return movieTitle;
            }
            set //used when we give the property its value
            {
                movieTitle = value;
            }

        }
        public string MovieCategory
        {
            get
            {
                return movieCategory;
            }
            set
            {
                movieCategory = value;
            }
        }


        //constructor(s)
        //all classes come with a defualt constructor. BUT PLEASE NOTE that the minute a default constructor is overloaded, it no longer exists
        //This overloaded constructor will allow me to give an object's properties value when I create the object. 
        public MovieList(string _movieTitle, string _movieCategory)
        {
            movieTitle = _movieTitle; //setting our field equal to the value coming from where we create out object
            movieCategory = _movieCategory;

        }

        public MovieList()
        {
            //initializing variable in default constructor
            movieTitle = "Inside Out";
            movieCategory = "animated";
        }

        //methods

        public void PrintClassmateInfo()
        {
            Console.WriteLine($"Since you want to watch a {movieCategory} movie, you can pick from these {movieTitle}. \n");
        }

    }
}
