using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    internal class Recipe
    {
        private string Name;
        private string Description;
        private List<string> Ingredients;
        private List<string> Categories;

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

        public static List<Recipe> FilterList(List<Recipe> recipes, string selectedFilter, string categoryOrIngredient)
        {
            List<Recipe> filteredList;

            if (categoryOrIngredient == "ingredient")
            {
                filteredList = recipes.Where(recipe => recipe.Ingredients.Contains(selectedFilter)).ToList();
                return filteredList;
            }
            if (categoryOrIngredient == "category")
            {
                filteredList = recipes.Where(recipe => recipe.Categories.Contains(selectedFilter)).ToList();
                return filteredList;
            }
            return recipes;
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
