using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial
{
    public class Proceso
    {
        BSecuencial BS = new BSecuencial();
        public void Procesado()
        {         
            List<int> Lista = new List<int>//LISTA DE TIPO INT
            { 78,35,243,2,65,243,12,1,20};
            int ElementoB = 20;//ELEMENTO A BUSCAR
            Console.WriteLine("BUSQUEDA SECUENCIAL EJEMPLO 1\n");
            Console.WriteLine("El elemento buscado es: {0}", ElementoB);//SOLO IMPRIMO EL ELEMENTO A BUSCAR
            BS.BusquedaSecuencial(ElementoB, Lista);//LLAMADA AL METODO QUE PIDDE COMO PARAMETROS UNA LISTA Y EL ELEMENTO A BUSCAR
        }//AL ENCONTRARLO IMPRIME LA POSICION
        public void Procesar()
        {
            List<int> Lista = new List<int>//LISTA DE TIPO INT
            { 8,3,9,3,11,7,1,27,12};
            int ElementoB = 15;//ELEMENTO A BUCAR
            Console.WriteLine("\nBUSQUEDA SECUENCIAL EJEMPLO 2\n");
            Console.WriteLine("El elemento buscado es: {0}", ElementoB);//SOLO IMPRIMO EL ELEMENTO A BUSCAR
            BS.BusquedaSecuencial(ElementoB, Lista);//LLAMADA AL METODO QUE PIDDE COMO PARAMETROS UNA LISTA Y EL ELEMENTO A BUSCAR
        }//AL NO ENCONTRARLO IMPRIME UN MENSAJE
    }
}
