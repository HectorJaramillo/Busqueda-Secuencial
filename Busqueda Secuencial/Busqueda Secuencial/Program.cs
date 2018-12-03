using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            BSecuencial BS = new BSecuencial();
            Proceso op = new Proceso();
            op.Procesado();//EJEMPLO 1
            op.Procesar();//EJEMPLO 2
            Console.ReadKey(true);
        }
    }
}
