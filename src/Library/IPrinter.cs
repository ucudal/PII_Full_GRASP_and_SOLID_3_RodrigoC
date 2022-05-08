namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Interfaz creada en sustitución de AllInOnePrinter, ya que según el patrón Polymorfism, el código que varía según el destino 
    /// debería estar en diferentes clases con una operación polimórfica. Esta interfaz tiene la operación polimórfica "PrintTIcket()", 
    /// la cual será implementada por las clases FilePrinter y ConsolePrinter.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Operación polimórfica la cual nos permitira poder imprimir el ticket sin tener la necesidad de consultar el destino de la impresión
        /// </summary>
        /// <param name="recipe"></param>
        void PrintTicket(Recipe recipe);
    }
}