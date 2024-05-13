using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookApplication
{
    internal class recipeLogger
    {
        //Declaring A Diction with string key type
            private Dictionary<string, Recipe> recipeBook;
            public recipeLogger(Dictionary<string, Recipe> recipeBook)
            {
                this.recipeBook = recipeBook;
            }
        //This method allows a user to add muliple recipes and store the recipe in a dictionary
            public void AddRecipes()
            {
            //Prompt user to enter name of Recipe they wish to add
                Console.WriteLine("Enter the name of the Recipe: ");
                string recipeName = Console.ReadLine();
                Recipe recipe = new Recipe();
                recipe.EnterRecipeDetails();
            //Adding the created Recipe to recipeBook dictionary
                recipeBook.Add(recipeName, recipe);
                Console.WriteLine("Recipe Successfully Added!!!");
            }
        //This method prompts a user to search and display a single recipe
            public void DisplaySingleRecipe()
            {
            //This prompts a user to enter the recipe name they wish to display
                Console.WriteLine("Please enter name of Recipe");
                string recipeName = Console.ReadLine();

            //This if-statement checks if the recipe name entered by a user exits in the recipe book dictionary
                if (recipeBook.ContainsKey(recipeName))
                {
                //If condition is true the Recipe is displayed
                    Console.WriteLine($"Recipe Name: {recipeName}");
                    recipeBook[recipeName].DisplayRecipe();
                }
                else
                {
                //If condition is false an message is displayed
                    Console.WriteLine("Recipe does not exist");
                }
            }
        //This method will loop throught the recipe book dictionary and print out the recipe name in alphabetical order
            public void ListOfRecipes()
            {
            //This loop illerates through the recipeBook 
                foreach (var recipe in recipeBook)
                {
                //This line of code will display a list of recipe names
                    Console.WriteLine($"Recipe Name:{recipe.Key}");
                }
            }
        //This method will prompt a user to enter the name of recipe they wish to search and will display it if the recipe exits
            public void seacrhRecipe()
            {
            //this line of code promts a user to enter the name of the recipe they want to search
                Console.WriteLine("Please enter name of Recipe");
                string recipeName = Console.ReadLine();
            //This if statement checks if the entered recipe name exits in the recipe Book dictionary
                if (recipeBook.ContainsKey(recipeName))
                {
                //If recipe name exits in the dictionary this block of code is executed and the recipe is displayed
                    Console.WriteLine($"Recipe Name: {recipeName}");
                    recipeBook[recipeName].DisplayRecipe();
                }
                else
                {
                //If recipe name does not exist this message is displayed
                    Console.WriteLine("Recipe does not exist");
                }
            }
        //This method prompts a user to enter a recipe name they wish to scale the ingredients by a factor of 0.5,2 or 3
            public void ScaleRecipe()
            {
            //this line of code promts a user to enter the name of the recipe they want to scale
            Console.WriteLine("Please enter name of Recipe");
                string recipeName = Console.ReadLine();
            //This if statement checks if the entered recipe name exits in the recipe Book dictionary
            if (recipeBook.ContainsKey(recipeName))
                {
                //if the recipe is found, this line of code will prompt a user to enter a number to scale recipe with
                    Console.WriteLine("Scale the Recipe ingredients by a factor of 0,5 or 2 or 3?: ");
                    double scale = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Recipe Name: {recipeName}");
                    recipeBook[recipeName].scaleRecipe(scale);
                }
                else
                {
                //If recipe is not found this line of code will execute
                    Console.WriteLine("Recipe does not exist");
                }
            }
        }
    
    }
