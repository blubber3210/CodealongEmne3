using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    internal class Recipe
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<string> Ingredients { get; private set; }
        public List<string> Categories { get; private set; }

        public Recipe(string name, string description, List<string> ingredients, List<string> categories)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Categories = categories;
        }


        public static void PrintRecipeNames(List<Recipe> recipes)
        {
            Console.Clear();
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine(i + ": " + recipes[i].Name);
            }
            Console.WriteLine("Type index num to view");
            int input = Convert.ToInt32(Console.ReadLine());
            recipes[input].PrintRecipeInfo();

        }

        private void PrintRecipeInfo()
        {
            Console.Clear();
            Console.WriteLine("Recipe: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Ingredients needed: ");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine("    " + ingredient);
            }
        }


    }
}
