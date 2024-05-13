namespace RecipeBookApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Recipe> recipeBook = new Dictionary<string, Recipe>();
            App menu = new App(recipeBook);
            menu.AppMenu();
        }
    }
}
