using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /*
        Esta clase implementa el tipo IPrinter y cumple con el principio LSP ya que cualquier objeto de ella va poder ser asignado
        a una variable del tipo IPrinter sin afectar el comportamiento del programa.
    */
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());        
        }
    }
}