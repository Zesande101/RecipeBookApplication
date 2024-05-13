using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookApplication
{
    internal class App
    {
        private Dictionary<string, Recipe> recipeBook;
        private recipeLogger logger;
        public App(Dictionary<string, Recipe> recipeBook)
        {
            this.recipeBook = recipeBook;
            logger = new recipeLogger(recipeBook);
        }
        public void AppMenu()
        {
            while (true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("               Recipe Book App             ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("1. Add Recipes");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Search Recipe");
                Console.WriteLine("4. Display List of Recipes");
                Console.WriteLine("5. Scale Recipe");
                Console.WriteLine("6. Reset Recipe Ingredients");
                Console.WriteLine("7. Clear Recipes");
                Console.WriteLine("8. Exit App");
                Console.WriteLine("*******************************************");
                string menuOpt = Console.ReadLine();
                switch (menuOpt)
                {
                    case "1":
                        logger.AddRecipes();
                        break;
                    case "2":
                        logger.DisplaySingleRecipe();
                        break;
                    case "3":
                        logger.seacrhRecipe();
                        break;
                    case "4":
                        logger.ListOfRecipes();
                        break;
                    case "5":
                        logger.ScaleRecipe();
                        break;
                    case "6":
                        Recipe recipe = new Recipe();
                        recipe.ResetQuantity();
                        break;
                    case "7":
                        foreach (var recipess in recipeBook)
                        {
                            Recipe recipes = new Recipe();
                            recipes.ClearRecipe(); 
                        }
                        
                        break;

                    case "8":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
        }
    }
}
