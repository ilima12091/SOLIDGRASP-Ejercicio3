using System;

namespace Full_GRASP_And_SOLID.Library
{
    /*
        Esta clase implementa el tipo IPrinter y cumple con el principio LSP ya que cualquier objeto de ella va poder ser asignado
        a una variable del tipo IPrinter sin afectar el comportamiento del programa.
    */
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}