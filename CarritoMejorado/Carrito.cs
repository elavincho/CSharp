﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    internal class Carrito
    {
        private int id;
        private String dni;
        private List<Producto> items;

        public Carrito(String dni, int it)
        {
            setId(id);
            setDni(dni);
            items = new List<Producto>();
        }

        private void setId(int id)
        {
            this.id = id;
        }

        private void setDni(String dni)
        {
            this.dni = dni;
        }

        private Producto buscarProducto(String nombre)
        {
            Producto productoABuscar = null;
            int i = 0;

            while (i < items.Count && productoABuscar == null)
            {
                if (items[i].mismoNombre(nombre))
                {
                    productoABuscar = items[i];
                }
                else
                {
                    i++;
                }
            }
            return productoABuscar;
        }

        public void agregarProducto(int id, String nombre, double precioUnitario, int cantidad)
        {
            Producto item = buscarProducto(nombre);
            if (item != null)
            {
                item.sumarCantidad(cantidad);
            }
            else
            {
                items.Add(new Producto(id, nombre, precioUnitario, cantidad));
            }
        }

        private double obtenerTotal()
        {
            double total = 0;
            foreach (Producto producto in items)
            {
                total += producto.getSubtotal();
            }
            return total;
        }

        public void finalizarCompra()
        {
            foreach (Producto producto in items)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine("Venta: " + id);
            Console.WriteLine("Dni: " + dni);
            Console.WriteLine("El total a abonar es : $" + obtenerTotal());
        }

        public List<Producto> getItems()
        {
            return items;
        }
    }
}
