namespace Full_GRASP_And_SOLID.Library
{
    /*
        Se creó esta interfaz para cumplir con el patrón de polimorfismo ya que va a permitir que varias clases implementen este tipo
        y se pueda imprimir en distintos lugares. También se cumple con el principio LSP ya que todas las clases
        que implementen el tipo IPrinter van a poder ser asignadas a una variable del tipo IPrinter y el comportamiento no va a cambiar. 
    */
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}