﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            var bird = new Bird();
            bird.Age = 1;
            bird.color = "blue";
            bird.name = "bluebird";
            bird.isASongbird = true;
            bird.howManyWings = 2;

            var iguana = new Reptile();
            iguana.Age = 5;
            iguana.Name = "Godzilla";
            iguana.extinct = false;
            iguana.HasLegs = true;
            iguana._HowManyApendages = 4;


            bird.introduce();
            iguana.whatIsIt();
        }


    }
}
