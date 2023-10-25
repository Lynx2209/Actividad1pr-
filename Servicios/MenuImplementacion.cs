using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1pr.__.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumero()
        {
            int n;
            Console.WriteLine("Introduzca un número");
            n = Convert.ToInt32(Console.ReadLine());


            return n;

        }
    }
}