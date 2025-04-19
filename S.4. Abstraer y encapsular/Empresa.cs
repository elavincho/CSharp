using System;

class Empresa
{
    // Propiedades privadas con encapsulamiento
    private string razonSocial;
    private Empleado empleadoPrincipal;

    // Constructor para inicializar las propiedades de la empresa
    public Empresa(string razonSocial)
    {
        this.razonSocial = razonSocial;
    }

    // Propiedad pública para acceder al empleado principal de la empresa
    public Empleado EmpleadoPrincipal
    {
        get { return empleadoPrincipal; }
        set { empleadoPrincipal = value; }
    }

    // Método para mostrar la información del empleado por consola
    public void mostrarInformacion()
    {
        Console.WriteLine("Razon Social: " + razonSocial);
        Console.WriteLine("Empleado principal: ");
        empleadoPrincipal.mostrarInformacion();
    }
}