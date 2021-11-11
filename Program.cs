﻿using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomDrink();
            DisplayRandomFood();
            DisplayRandomMovie();

        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];

            Console.WriteLine($"Computer picked: {randomFood}");


        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks [randomIndex];

            Console.WriteLine($"Computer picked: {randomDrink}");
        }
        private static void DisplayRandomMovie()
        {
             string[] movie = { "Visa hing 2", "Visa hing 1", "Annabelle", "Mägedel on silmad" };
             Random rnd = new Random();
             int randomIndex = rnd.Next(0, movie.Length);

             string randomMovie = movie[randomIndex];

             Console.WriteLine($"Computer picked: {randomMovie}");
        }
    }
}
