using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        /* Atributos */
        private string titulo;
        private string autor;
        private string editorial;

        /* Constructor Vacio */
        public Libro()
        {
        }

        /* Constructor con parámetros*/
        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        /* Getters y Setters*/
        public string getTitulo()
        {
            return titulo;
        }

        public string getAutor()
        {
            return autor;
        }

        public string getEditorial()
        {
            return editorial;
        }

        public void setTitulo()
        {
            this.titulo = titulo;
        }

        public void setAutor()
        {
            this.autor = autor;
        }

        public void setEditorial()
        {
            this.editorial = editorial;
        }

        /* To String*/

        public override string ToString()
        {
            return "Titulo: " + titulo + " Autor: " + autor + " Editorial: " + editorial;
        }

    }
}
