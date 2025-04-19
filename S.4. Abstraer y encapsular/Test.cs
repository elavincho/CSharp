using System;
class Test
{
    static void Main()
    {
        // Crear una instancia de Empresa
        Empresa empresa = new Empresa("Mi Empresa S.A.");

        // Crear una instancia de Empleado
        Empleado empleado = new Empleado("Juan Perez", 30, "Gerente de Proyectos");

        // Asignar el empleado1 como empleado principal de la empresa1
        empresa.EmpleadoPrincipal = empleado;

        // Mostrar la información de la empresa
        empresa.mostrarInformacion();
    }
}
