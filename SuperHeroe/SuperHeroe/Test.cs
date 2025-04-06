using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroe
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Crear los superhéroes según el enunciado
            SuperHeroe superHeroe1 = new SuperHeroe("Batman", 90, 70, -10);
            SuperHeroe superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);

            SuperHeroe superHeroe3 = new SuperHeroe("IronMan", 80, 90, 50);
            SuperHeroe superHeroe4 = new SuperHeroe("Hulk", 150, 95, 30);

            // Jugar y mostrar resultados
            string resultado1 = superHeroe1.competir(superHeroe2);
            string resultado2 = superHeroe2.competir(superHeroe1);

            string resultado3 = superHeroe3.competir(superHeroe4);
            string resultado4 = superHeroe4.competir(superHeroe3);

            string resultado5 = superHeroe4.competir(superHeroe4);

            Console.WriteLine("Resultado de Batman vs. Superman: " + resultado1);
            Console.WriteLine("");
            Console.WriteLine("Resultado de Superman vs. Batman: " + resultado2);
            Console.WriteLine("");
            Console.WriteLine("Resultado de IronMan vs. Hulk: " + resultado3);
            Console.WriteLine("");
            Console.WriteLine("Resultado de Hulk vs. IronMan: " + resultado4);
            Console.WriteLine("");
            Console.WriteLine("Resultado de Hulk vs. Hulk: " + resultado5);
        }
    }
}
