using System;
using System.IO;


namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase creada según el patrón Polymorfism, dicha clase se encarga de implementar la interfaz IPrinter, 
    /// esta clase tiene la responsabilidad de recibir una instancia de recipe como parámetro e imprimirla en un archivo. 
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Implementación de la operación polimórfica la cual recibe una instancia de recipe como 
        /// parámetro y la imprime en un archivo, en este caso "Recipe.txt".
        /// </summary>
        /// <param name="recipe"></param>
        public void PrintTicket(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}