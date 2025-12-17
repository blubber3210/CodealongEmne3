namespace CodealongEmne3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<Oppskrift> recipesList = new List<Oppskrift>();

            var recipe1 = new Oppskrift("carbonara", ["spaghetti", "ost", "bacon"], ["italiensk", "comfort food", "enkelt"]);
            var recipe2 = new Oppskrift("omelette", ["melk", "ost", "bacon"], ["frokost", "enkelt"]);
            var recipe3 = new Oppskrift("pizza", ["mel", "ost", "bacon", "tomatsaus"], ["italiensk", "comfort food"]);

            recipesList.Add(recipe1);
            recipesList.Add(recipe2);
            recipesList.Add(recipe3);



            Console.WriteLine("Type number to choose option!");
            Console.WriteLine("1. View all recipes");
            Console.WriteLine("2. Search by category");
            Console.WriteLine("3. Search by ingredient");

            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1) ShowListOfRecipes(recipesList);
            if (userInput == 2) RunSearchByCategory();
            if (userInput == 3) RunSearchByIngredient();
            








        }

        static void ShowListOfRecipes(List<Oppskrift> recipesList)
        {
            Console.WriteLine("List of recipes: ");

            foreach (Oppskrift recipe in recipesList)
            {
                Console.WriteLine($"Oppskrift nummer {recipesList.IndexOf(recipe)} :" + recipe.Name);
            }

            Console.WriteLine("Type number to view recipe");
            int userInput = Convert.ToInt32(Console.ReadLine());


        }

        static void RunSearchByCategory()
        {
            Console.WriteLine("Available categories:");

        }

        static void RunSearchByIngredient()
        {
            Console.WriteLine("Available ingredients:");
        }
    }
}
