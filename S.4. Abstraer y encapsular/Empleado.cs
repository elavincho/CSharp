using System;

class Empleado
{
    // Propiedades privadas con encapsulamiento
    private string nombre;
    private int edad;
    private string cargo;

    // Constructor para inicializar las propiedades del empleado
    public Empleado(string nombre, int edad, string cargo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.cargo = cargo;
    }

    // Método para mostrar la información del empleado por consola
    public void mostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Cargo: " + cargo);
    }
}
