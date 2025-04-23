using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Lector
    {
        /* Atributos*/
        private string nombre;
        private string dni;
        private List<Libro> prestamos;

        /* Constructor Vacio*/
        public Lector()
        {
        }

        /* Constructor con parámetros*/
        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            prestamos = new List<Libro>();
        }

        /* Getters y Setters*/

        public string getNombre()
        {
            return nombre;
        }

        public string getDni()
        {
            return dni;
        }

        public void setNombre()
        {
            this.nombre = nombre;
        }

        public void setDni()
        {
            this.dni = dni;
        }

        /* To String*/

        public override string ToString()
        {
            return "Nombre: " + nombre + " DNI: " + dni + " Prestamos: " + prestamos.Count();
        }

        /* Métodos*/

        public bool puedeTomarPrestado()
        {
            return prestamos.Count < 3;
        }

        public void agregarPrestamo(Libro libro)
        {
            if (puedeTomarPrestado())
            {
                prestamos.Add(libro);
            }
        }


        /* VERIFICAR **************************
         * 
        public bool tienePrestado(string tituloLibro)
        {
            foreach (var libro in prestamos)
            {
                if (libro.getTitulo().Equals(tituloLibro, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        */
    }
}

