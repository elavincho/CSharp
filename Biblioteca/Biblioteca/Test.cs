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
            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("Libro 5");
            biblioteca.listarLibros();

            void cargarLibros(int cantidad)
            {
                bool pude;
                for (int i = 1; i < cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro " + i, "Autor " + i, "Editorial " + i);
                    if (pude)
                    {
                        Console.WriteLine("Libro " + i + " agregado correctamente.");
                    }else
                    {
                        Console.WriteLine("Libro " + i + " ya existe en la biblioteca");
                    }
                }
            }






        }
    }
}
