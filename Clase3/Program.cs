using Clase3.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);
            Auto auto = new Auto("Fiat", "Palio");
            ImprimirDatosVehiculo(auto);

            Moto moto = new Moto("Honda", "CBR 400");
            ImprimirDatosVehiculo(moto);
             
            static void ImprimirDatosVehiculo(Vehiculo vehiculo)
            {
                Console.WriteLine($"Este vehiculo es marca {vehiculo.Marca} y modelo {vehiculo.Modelo}");
            }
            #endregion

            #region Ejercicio 2
            Console.WriteLine();
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.ObtenerLibros();
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca
            #endregion
        }




    }
}