using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    internal class Controller
    {
        public static void Run(List<Recipe> recipes)
        {
            while (true)
            {
                PrintIntroMenu();
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1) Recipe.PrintRecipeNames(recipes);
                if (input == 2)
                {
                    var filteredList = PrintCategoryMenu(recipes);
                    Recipe.PrintRecipeNames(filteredList);
                }

                if (input == 3)
                {
                    var filteredList = PrintIngredientMenu(recipes);
                    Recipe.PrintRecipeNames(filteredList);
                }
                else Run(recipes);
            }
        }

        private static void PrintIntroMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. View all recipes");
            Console.WriteLine("2. Search by category");
            Console.WriteLine("3. Search by ingredients");
        }

        private static List<Recipe> PrintCategoryMenu(List<Recipe> recipes)
        {
            Console.Clear();
            var categories = new List<string> { "Breakfast", "Lunch", "Dinner", "Dessert", "Vegetarian", "Vegan", "Quick", "Comfort Food", "Italian", "Mexican", "Asian", "Healthy" };
            
            Console.WriteLine("What kind of food do you want to make?");

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine(i + ": " + categories[i]);
            }

            int input = Convert.ToInt32(Console.ReadLine());
            var selectedCategory = categories[input];
            var filteredList = Recipe.FilterList(recipes, selectedCategory, "category");
            //List<Recipe> filteredList = recipes.Where(recipe => recipe.Categories.Contains(selectedCategory)).ToList();
            return filteredList;
        }

        private static List<Recipe> PrintIngredientMenu(List<Recipe> recipes)
        {
            Console.Clear();
            //var ingredients = new List<string> { "Eggs", "Chicken", "Beef", "Pasta", "Rice", "Tomatoes", "Cheese", "Beans", "Potatoes", "Spinach" };
            var ingredients = new List<string> { "Eggs", "Milk", "Butter", "Flour", "Sugar", "Chicken", "Beef", "Pasta", "Rice", "Tomatoes", "Onion", "Garlic", "Bell Pepper", "Cheese", "Olive Oil", "Soy Sauce", "Beans", "Potatoes", "Spinach" };

            Console.WriteLine("What do you want to cook with?");

            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine(i + ": " + ingredients[i]);
            }

            int input = Convert.ToInt32(Console.ReadLine());
            var selectedIngredient = ingredients[input];
            var filteredList = Recipe.FilterList(recipes, selectedIngredient, "ingredient");
            //List<Recipe> filteredList = recipes.Where(recipe => recipe.Ingredients.Contains(selectedIngredient)).ToList();
            return filteredList;
        }
    }
}
