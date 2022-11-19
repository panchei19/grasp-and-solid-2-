using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinterRecipe
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
    }
}