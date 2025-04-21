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
        public Lector(string nombre, string dni, List<Libro> prestamos)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.prestamos = prestamos;
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

        public List<Libro> getprestamos()
        {
            return prestamos;
        }

        /* To String*/

        public override string ToString()
        {
            return "Nombre: " + nombre + " DNI: " + dni + " Prestamos: " + prestamos;
        }
    }
}
