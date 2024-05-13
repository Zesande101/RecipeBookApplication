using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RecipeBookApplication
{
    public class Recipe
    {
        //Created arrays to store data collected from end-users
        private string[] ingredient;
        private double[] quantity;
        private string[] unitofMeas;
        private string[] steps;
        private double[] calories;
        private string[] foodGroup;
        private string recipeName;

        //Default constructor
        public Recipe()
        {
            ingredient = new string[0];
            quantity = new double[0];
            unitofMeas = new string[0];
            steps = new string[0];
            calories = new double[0];
            foodGroup = new string[0];
        }
        //This method will allow a user to enter details about a single recipe
        public void EnterRecipeDetails()
        {
            //This variable will store the number of ingredients
            int noOfIngredient;
            //Do while loop to repeat the statement if user incorrectly input data 
            do
            {
                //This line of code will execute as long as user input is not equal to correct data type
                Console.WriteLine("Enter the number of ingredients: ");
            } while (!int.TryParse(Console.ReadLine(),out noOfIngredient));

            ingredient = new string[noOfIngredient];
            quantity = new double[noOfIngredient];
            unitofMeas = new string[noOfIngredient];
            steps = new string[noOfIngredient];
            calories = new double[noOfIngredient];
            foodGroup = new string[noOfIngredient];

            //This for loop will illiterate throught the number of ingredients entered by a user, for incorrect data types it will repeatly do the same display 
            for (int i = 0; i < noOfIngredient; i++)
            {
                Console.WriteLine("Enter the name of the ingredient: ");
                ingredient[i] = Console.ReadLine();
                do
                {
                    Console.WriteLine($"Enter the quantity of {ingredient[i]}: ");
                } while (!double.TryParse(Console.ReadLine(), out quantity[i]));

                Console.WriteLine($"Enter the unit of measurement for {ingredient[i]} :");
                unitofMeas[i] = Console.ReadLine();

                do
                {
                    Console.WriteLine($"Enter the amount of calories for {ingredient[i]} :");
                } while (!double.TryParse(Console.ReadLine(), out calories[i]));

                Console.WriteLine($"Enter Food Group for {ingredient[i]} : ");
                foodGroup[i] = Console.ReadLine();
            }
            //This variable will store number of steps it takes to make the recipe
            int noOfSteps;
            do
            {
                Console.WriteLine("Enter the number of steps: ");

            } while (!int.TryParse(Console.ReadLine(), out noOfSteps));
            
            steps = new string[noOfSteps];
            //This for loop will loop through the number of steps entered by a user
            for (int i = 0; i < noOfSteps; i++)
            {
                Console.WriteLine($"Enter Step {1 + i} :");
                steps[i] = Console.ReadLine();
            }
        }
        //This method will calculate the number of calories contain in a single recipe
        public void calCalories(double[]calories)
        {
            //This variable will store the sum of calories
            double sumOfCalories = 0;
            //this line of code will loop through the lenght of calories
            for (int i = 0;i < calories.Length;i++)
            {
                //This line of code will add up the calories
                sumOfCalories+=calories[i];
            }
            //this if statement will check if total number calories exceeds 300
            if(calories.Length < 300)
            {
                //if true this line of code will execute
                Console.WriteLine("TOTAL CALORIES EXCEEDS 300!!!");
            }

        }
        //This method will display a recipe ingredients and steps
        public void DisplayRecipe()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine(                 "Display Recipe ");
            Console.WriteLine($"Name of Recipe: {recipeName}");
            Console.WriteLine("**************************************************");

            for (int i = 0; i < ingredient.Length; i++)
            {
                Console.WriteLine($"{quantity[i]} {unitofMeas[i]} of {ingredient[i]}");
            }
            Console.WriteLine("**************************************************");
            Console.WriteLine($"\nSteps to make {recipeName}");
            Console.WriteLine("**************************************************");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine(steps[i]);
            }
            Console.WriteLine("**************************************************");
        }
        //This method will scale ingredients for a recipe by a factor of 0.5 or 2 or 3
        public double scaleRecipe(double scale)
        {
            //this for loop will illiterate throught the lenght of quantity
            for (int i = 0; i < quantity.Length; i++)
            {
                //This line of code will loop through the quantity array and will muliply by scale
                quantity[i] *= scale;
            }
            return scale;
        }
        public void ResetQuantity()
        {
            for(int i = 0;i < quantity.Length; i++)
            {
                quantity[i] /= 2;
            }
        }
        public void ClearRecipe()
        {
            ingredient = new string[0];
            quantity = new double[0];
            unitofMeas = new string[0];
            steps = new string[0];
        }
    }
}

