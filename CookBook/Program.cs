using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace CookBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var recipes = InitRecipes();
            Controller.Run(recipes);

        }
        private static List<Recipe> InitRecipes()
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
