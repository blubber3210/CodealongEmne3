using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    internal class Controller
    {
        public void Run()
        {
            var recipes = InitRecipes();
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

                else Run();
            }
        }

        private void PrintIntroMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. View all recipes");
            Console.WriteLine("2. Search by category");
            Console.WriteLine("3. Search by ingredients");
        }

        private List<Recipe> PrintCategoryMenu(List<Recipe> recipes)
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

        private List<Recipe> PrintIngredientMenu(List<Recipe> recipes)
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

        private List<Recipe> InitRecipes()
        {
            var recipes = new List<Recipe>
            {
                new Recipe("Classic Pancakes",
                    "Fluffy breakfast pancakes served warm with syrup or fruit.",
                    ["Flour", "Milk", "Eggs", "Butter", "Sugar"],
                    ["Breakfast", "Vegetarian", "Comfort Food"]),

                new Recipe("Spaghetti Bolognese",
                    "Traditional Italian pasta with a rich beef and tomato sauce.",
                    ["Pasta", "Beef", "Tomatoes", "Onion", "Garlic", "Olive Oil"],
                    ["Dinner", "Italian", "Comfort Food"]),

                new Recipe("Veggie Stir-Fry",
                    "Quick stir-fried vegetables in a savory soy sauce glaze.",
                    ["Bell Pepper", "Onion", "Garlic", "Spinach", "Soy Sauce", "Olive Oil"],
                    ["Dinner", "Vegan", "Asian", "Quick"]),

                new Recipe("Chicken Fried Rice",
                    "Classic fried rice with chicken, eggs, and vegetables.",
                    ["Rice", "Chicken", "Egg", "Onion", "Soy Sauce", "Garlic"],
                    ["Lunch", "Dinner", "Asian"]),

                new Recipe("Caprese Salad",
                    "Fresh salad with tomatoes, cheese, and olive oil.",
                    ["Tomatoes", "Cheese", "Olive Oil"],
                    ["Lunch", "Vegetarian", "Healthy", "Quick", "Italian"]),

                new Recipe("Beef Tacos",
                    "Seasoned beef served in tacos with fresh toppings.",
                    ["Beef", "Onion", "Bell", "Pepper", "Tomatoes", "Cheese"],
                    ["Dinner", "Mexican", "Comfort Food"]),

                new Recipe("Baked Potatoes with Garlic Butter",
                    "Oven-baked potatoes topped with melted garlic butter.",
                    ["Potatoes", "Butter", "Garlic"],
                    ["Side Dish", "Vegetarian", "Comfort Food"]),

                new Recipe("Spinach Omelette",
                    "Light omelette filled with sautéed spinach and cheese.",
                    ["Eggs", "Spinach", "Cheese", "Butter"],
                    ["Breakfast", "Vegetarian", "Quick"]),

                new Recipe("Tomato Soup",
                    "Smooth and warm tomato soup, perfect for cold days.",
                    ["Tomatoes", "Onion", "Garlic", "Olive Oil"],
                    ["Lunch", "Dinner", "Vegan", "Comfort Food"]),

                new Recipe("Simple Fruit Dessert",
                    "Light dessert made with fresh fruit and a touch of sugar.",
                    ["Sugar", "Fruit"],
                    ["Dessert", "Vegan", "Healthy", "Quick"])

            };
            return recipes;
        }
    }
}
