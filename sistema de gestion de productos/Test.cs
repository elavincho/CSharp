using System;

namespace Semana8
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Creamos algunos productos de ejemplo
            Producto productoP = new ProductoPerecedero
            {
                Nombre = "Leche",
                Precio = 50.0,
                Tipo = "Perecedero",
                DiasACaducar = 4
            };

            Producto productoNoP = new ProductoNoPerecedero
            {
                Nombre = "Lentejas",
                Precio = 30.0,
                Tipo = "No Perecedero",
                Categoria = "Legumbre"
            };
        }
    }
}
