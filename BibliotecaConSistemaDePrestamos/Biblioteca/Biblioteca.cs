using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
        /* Atributos */
        private List<Libro> libros;

        private List<Lector> lectores;

        /* En el constructor de Biblioteca instanciamos la lista
         * de Libros y Lectores para poder utilizarla */
        public Biblioteca()
        {
            this.libros = new List<Libro>();

            this.lectores = new List<Lector>();
        }

        /* Creamos un método para buscar de un libros*/
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

        /* Creamos un método para agregar Libros*/
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
                Console.WriteLine("Titulo: " + titulo + " Autor: " + autor + " Editorial " + editorial + " - Libro agregado correctamente.");
            }
            else
            {
                Console.WriteLine("El libro " + titulo + " ya fue cargado previamente.");
            }
            return resultado;
        }

        /* Creamos un método para mostrar Libros*/
        public void listarLibros()
        {
            Console.WriteLine("** LISTA DE LIBROS **");
            Console.WriteLine("");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        /* Creamos un método para eliminar Libros*/
        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine("El libro " + libro + " eliminado correctamente.");
                resultado = true;
            }
            else
            {
                Console.WriteLine("No se puedo eliminar el libro. ¡Por favor verifique el titulo ingresado!");
            }
            return resultado;
        }

        /* Creamos un método para buscar de un Lectores por su DNI*/
        private Lector buscarLector(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni)) i++;
            {
                if (i != lectores.Count)
                {
                    lectorBuscado = lectores[i];
                }
            }

            return lectorBuscado;
        }

        /* Creamos un método para agregar Lectores*/
        public bool agregarLector(string nombre, string dni)
        {
            bool resultado = false;
            Lector lector;
            lector = buscarLector(nombre);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        /* Creamos un método para mostrar Lectores*/
        public void listarLectores()
        {
            Console.WriteLine("** LISTA DE LECTORES **");
            Console.WriteLine("");
            foreach (var lector in lectores)
            {
                Console.WriteLine(lector);
            }
        }


        /* Creamos un método para eliminar Lectores por su dni*/
        public bool eliminarLector(string dni)
        {
            bool resultado = false;
            Lector lector;
            lector = buscarLector(dni);
            if (lector != null)
            {
                lectores.Remove(lector);
                Console.WriteLine("El lector " + lector + " eliminado correctamente.");
                resultado = true;
            }
            else
            {
                Console.WriteLine("No se puedo eliminar el lector. ¡Por favor verifique el DNI ingresado!");
            }
            return resultado;
        }

        // Método para prestar un libro
        public string prestarLibro(string tituloLibro, string dniLector)
        {
            // Verificamos si el Lector existe
            Lector lector = null;
            foreach (var l in lectores)
            {
                if (l.getDni().Equals(dniLector, StringComparison.OrdinalIgnoreCase))
                {
                    lector = l;
                    Console.WriteLine("LECTOR ENCONTRADO");
                    break;
                }
            }

            // En el caso que no exista un Lector
            if (lector == null)
            {
                Console.WriteLine("LECTOR INEXISTENTE");
                Console.WriteLine("NO SE PUDO REALIZAR EL PRESTAMO");
                return "LECTOR INEXISTENTE";
            }

            // Verificamos si el Lector puede tomar más préstamos
            if (!lector.puedeTomarPrestado())
            {
                Console.WriteLine("TOPE DE PRESTAMO ALCAZADO");
                return "TOPE DE PRESTAMO ALCAZADO";
            }

            // Buscamos el Libro en la Biblioteca
            Libro libroAPrestar = null;
            foreach (var libro in libros)
            {
                if (libro.getTitulo().Equals(tituloLibro, StringComparison.OrdinalIgnoreCase))
                {
                    libroAPrestar = libro;
                    Console.WriteLine("LIBRO ENCONTRADO");
                    break;
                }
            }

            // En el caso de que el Libro no exista
            if (libroAPrestar == null)
            {
                Console.WriteLine("LIBRO INEXISTENTE");
                Console.WriteLine("NO SE PUDO REALIZAR EL PRESTAMO");
                return "LIBRO INEXISTENTE";
            }

            // REALIZAMOS EL PRESTAMO

            // Sacamos el Libro de la Biblioteca
            libros.Remove(libroAPrestar);
            // Asignamos el Libro al Lector
            lector.agregarPrestamo(libroAPrestar);
            Console.WriteLine("PRESTAMO EXITOSO");
            return "PRESTAMO EXITOSO";
        }
    }
}
