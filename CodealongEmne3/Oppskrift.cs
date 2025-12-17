using System;
using System.Collections.Generic;
using System.Text;

namespace CodealongEmne3
{
    internal class Oppskrift
    {
        public string Name;
        public string[] Ingredients;
        public string[] Category;

        public Oppskrift(string name, string[] ingredients, string[] category)
        {
            Name = name;
            Ingredients = ingredients;
            Category = category;
        }

        public void ShowListOfRecipes(List<Oppskrift> recipesList)
        {
            Console.WriteLine("List of recipes: ");

            foreach (Oppskrift recipe in recipesList)
            {
                Console.WriteLine($"Oppskrift nummer {recipesList.IndexOf(recipe)} :" + recipe.Name);
            }

            Console.WriteLine("Type number to view recipe");
            int userInput = Convert.ToInt32(Console.ReadLine());


        }

    }
}
