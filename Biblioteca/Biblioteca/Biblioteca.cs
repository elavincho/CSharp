using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {

        private List<Libro> libros;

        /* En el constructor de Biblioteca instanciamos la lista
         * de libros para poder utilizarla */
        public Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        /* Creamos un método para buscar de un libros
         * por su nombre*/

        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo)) i++;
            {
                if (i != libros.Count)
                {
                    libroBuscado = libros[i];
                }
            }

            return libroBuscado;
        }

        /* Creamos un método para agregar libros con parámetros*/

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        /* Creamos un método para mostrar libros*/

        public void listarLibros()
        {
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        /* Creamos un método para eliminar libros*/

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if(libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }


    }
}
