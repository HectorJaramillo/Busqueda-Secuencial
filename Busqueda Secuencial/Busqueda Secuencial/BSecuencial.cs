using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial
{
    public class BSecuencial
    {
        public void BusquedaSecuencial(int Elemento, List<int> Lista)//METODO QUE PIDE COMO PARAMETRO UNA LISTA Y EL NUMERO A BUSCAR
        {
            int Tamaño = Lista.Count;//INDICO EL TAMAÑO DE LA LISTA COMO PARAMETRO
            int Posicion = 0,Contador=0;//VARIABLES QUE CONDICIONARAN

            while (Posicion < Tamaño)//MIENTRA POSICION SEA MENOR AL TAMAÑO DE LA LISTA
            {
                if (Lista[Posicion] == Elemento)//SI LA POSICION DE LA LISTA ES IGUAL AL ELEMENTO BUSCADO
                {
                    Console.WriteLine("La posicion del elemento solicitado es: {0}", Posicion);
                    Contador++;//CONTADOR +1
                    break;//TERMINA EL CICLO
                }
                else//SINO
                {
                    Posicion++;//POSICION DE LA LISTA +1
                }               
            }
            if (Contador==0)//SI EL CONTADOR ES IGUAL A 0
            {
                Console.WriteLine("No se ha encontrado el elemento solicitado");
            }        
        }
    }
}
