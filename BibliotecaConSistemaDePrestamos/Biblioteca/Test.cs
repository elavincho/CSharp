using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("");
            Console.WriteLine(" *** BIBLIOTECA ***");
            Console.WriteLine("");

            /* Cargamos libros*/
            Console.WriteLine("** CARGAMOS LOS LIBROS **");
            Console.WriteLine("");

            biblioteca.agregarLibro("Rayuela","Julio Cortazar","Sudamericana");
            biblioteca.agregarLibro("Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana");
            biblioteca.agregarLibro("El Principito", "Antonie de Sant-Exupery", "Salamandra");
            biblioteca.agregarLibro("Don Quijote de la Mancha", "Miguel de Cervantes", "Francisco de Robles");
            biblioteca.agregarLibro("Matar a un Ruiseñor", "J. B. Lippincott", "HarperCollins");
            biblioteca.agregarLibro("Moby Dick", "James Joyce", "Catedra");
            biblioteca.agregarLibro("La Odisea", "Homero", "Penguin");
            biblioteca.agregarLibro("El Codigo Da Vinci", "Dan Brown", "Doubleday");
            biblioteca.agregarLibro("El Alquimista", "Paulo Coelho", "Planeta");
            biblioteca.agregarLibro("El Señor de los Anillos", "J.R.R.", "Minotauro");
            biblioteca.agregarLibro("Juego de Tronos", "George R.R. Martin", "Gigamesh");
            biblioteca.agregarLibro("El Psicoanalista", "John Katzanbach", "Ediciones B");
            biblioteca.agregarLibro("El Arte de la Guerra", "Sun Tzu", "Austral");

            Console.WriteLine("");
            /* Listamos los libros*/
            biblioteca.listarLibros();
            
            Console.WriteLine("");

            /*Tratamos de ingresar un libro que ya existe*/
            Console.WriteLine("Tratamos de ingresar un libro que ya existe.");
            biblioteca.agregarLibro("El Codigo Da Vinci", "Dan Brown", "Doubleday");

            Console.WriteLine("");

            /* Eliminamos un libro*/
            Console.WriteLine("Eliminamos el Libro Rayuela.");
            biblioteca.eliminarLibro("Rayuela");
            
            Console.WriteLine("");

            /* Listamos nuevamente los libros despues de eliminar uno*/
            Console.WriteLine("Verificamos que el libro fue eliminado de la lista.");
            biblioteca.listarLibros();

            Console.WriteLine("");

            /* Eliminamos un libro que no existe*/
            Console.WriteLine("Eliminamos un Libro que no existe Ej: IFTS29.");
            biblioteca.eliminarLibro("IFTS29");

            Console.WriteLine("");

            /* Cargamos Lectores*/
            Console.WriteLine("** CARGAMOS A LOS LECTORES **");
            biblioteca.agregarLector("Flavia Berzuini", "111111");
            biblioteca.agregarLector("Valeria Thomas","222222");
            biblioteca.agregarLector("Raquel Rodriguez", "333333");
            biblioteca.agregarLector("Jonatan Uribio", "444444");
            biblioteca.agregarLector("Mario Gonzalez", "555555");

            Console.WriteLine("");

            /*Mostramos la lista de lectores*/
            biblioteca.listarLectores();

            Console.WriteLine("");

            /* Eliminamos a un Lector*/
            Console.WriteLine("Eliminamos al Lector Mario Gonzalez DNI 555555.");
            biblioteca.eliminarLector("555555");

            Console.WriteLine("");

            /* Mostramos la lista de lectores despues de eliminar a un lector*/
            Console.WriteLine(" Verificamos que el lector fue eliminado.");
            biblioteca.listarLectores();

            Console.WriteLine("");

            /*Eliminamos a un Lector que no existe*/
            Console.WriteLine("Tratamos de eliminar a un Lector ingresando un DNI incorrecto.");
            biblioteca.eliminarLector("777777");

            Console.WriteLine("");

            /*Realizamos Préstamos*/
            Console.WriteLine("** PRÉSTAMOS **");
            Console.WriteLine("1. Prestámos a Raquel Rodriguez DNI 333333 el Libro Moby Dick.");
            biblioteca.prestarLibro("Moby Dick", "333333");

            Console.WriteLine("");

            /* Volvemos a mostrar la lista de Lectores para verificar que el Libro fue asignado correctamente */
            Console.WriteLine("Volvemos a mostrar la lista de Lectores para verificar que el Libro fue asignado correctamente.");
            biblioteca.listarLectores();

            Console.WriteLine("");

            /* Volvemos a mostrar la lista de libros para verificar que el Libro ya no se encuentra en la lista */
            Console.WriteLine("Volvemos a mostrar la lista de libros para verificar que el Libro ya no se encuentra en la lista.");
            biblioteca.listarLibros();

            Console.WriteLine("");

            /*Realizamos un segundo Préstamo a Raquel Rodriguez*/
            Console.WriteLine("** PRÉSTAMOS **");
            Console.WriteLine("2. Prestámos a Raquel Rodriguez DNI 333333 el Libro El Principito.");
            biblioteca.prestarLibro("El Principito", "333333");

            Console.WriteLine("");

            /* Volvemos a mostrar la lista de Lectores para verificar que el Libro fue asignado correctamente */
            Console.WriteLine("Volvemos a mostrar la lista de Lectores para verificar que el Libro fue asignado correctamente.");
            biblioteca.listarLectores();

            Console.WriteLine("");

            /* Volvemos a mostrar la lista de libros para verificar que el Libro ya no se encuentra en la lista */
            Console.WriteLine("Volvemos a mostrar la lista de libros para verificar que el Libro ya no se encuentra en la lista.");
            biblioteca.listarLibros();

            Console.WriteLine("");

            /*Realizamos un tercer Préstamo a Raquel Rodriguez*/
            Console.WriteLine("** PRÉSTAMOS **");
            Console.WriteLine("3. Prestámos a Raquel Rodriguez DNI 333333 el Libro Juego de Tronos.");
            biblioteca.prestarLibro("Juego de Tronos", "333333");

            Console.WriteLine("");

            /* Volvemos a mostrar la lista de Lectores para verificar que el Libro fue asignado correctamente */
            Console.WriteLine("Volvemos a mostrar la lista de Lectores para verificar que el Libro fue asignado correctamente.");
            biblioteca.listarLectores();

            Console.WriteLine("");

            /* Volvemos a mostrar la lista de libros para verificar que el Libro ya no se encuentra en la lista */
            Console.WriteLine("Volvemos a mostrar la lista de libros para verificar que el Libro ya no se encuentra en la lista.");
            biblioteca.listarLibros();

            Console.WriteLine("");

            /* Intentamos realizar un cuarto Préstamo a Raquel Rodriguez*/
            Console.WriteLine("** PRÉSTAMOS **");
            Console.WriteLine("4. Intentamos préstar un cuarto Libro a Raquel Rodriguez DNI 333333 el El Arte de la Guerra.");
            biblioteca.prestarLibro("El Arte de la Guerra", "333333");

            Console.WriteLine("");

            /* Intentamos préstar a Valeria Thomas DNI 222222 un libro que no existe*/
            Console.WriteLine("** PRÉSTAMOS **");
            Console.WriteLine("Intentamos préstar a Valeria Thomas DNI 222222 un libro que no existe Ej: El Pulpito.");
            biblioteca.prestarLibro("El Pulpito", "222222");

            Console.WriteLine("");

            /* Intentamos préstar un Libro a Flavia Berzuini DNI 111111 ingresando un DNI incorrecto*/
            Console.WriteLine("** PRÉSTAMOS **");
            Console.WriteLine("Intentamos préstar un Libro a Flavia Berzuini DNI 111111 ingresando un DNI incorrecto.");
            biblioteca.prestarLibro("Cien Años de Soledad", "777777");

            Console.WriteLine("");

            






        }
    }
}
