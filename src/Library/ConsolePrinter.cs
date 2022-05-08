using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase creada según el patrón Polymorfism, dicha clase se encarga de implementar la interfaz IPrinter, 
    /// esta clase tiene la responsabilidad de recibir una instancia de recipe como parámetro e imprimirla en consola. 
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        
        /// <summary>
        /// Implementación de la operación polimórfica la cual recibe una instancia de recipe como 
        /// parámetro y la imprime en la consola.
        /// </summary>
        /// <param name="recipe"></param>
        public void PrintTicket(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}