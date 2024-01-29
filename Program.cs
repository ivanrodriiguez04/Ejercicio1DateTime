namespace Ejercicio1DateTime 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 29/01/2024
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 29/01/2024
        /// </summary>
        static void Main(string[] args) 
        {
            //Creamos una variable y le añadimos la informacion
            DateTime fechaActual = DateTime.Now;
            //Le añadimos un formato en especifico
            fechaActual.ToString("yy - MM - ddThh:mm: ss.ms");
            //Mostramos el resultado
            Console.WriteLine("Fecha formato-tiempo: "+fechaActual.ToString());

        }
    }
}
