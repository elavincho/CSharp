using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAgregarClase
{
    internal class Persona
    {
        // Atributos
        private string nombre;
        private int edad;

        // Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }


        // Métodos get
        public string getNombre()
        {
            return nombre;
        }

        public int getEdad()
        {
            return edad;
        }

        // Métodos set
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        // Encapsulamiento por Properties
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
