using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("El mayor de 15 y 23 es {0}", Mayor(15, 23));

            EscribirMayusculas("Me llamo luis");
            int[] numeros={4,9,5,6,9};

            int suma = SumarMuchos(numeros);

            Console.WriteLine("La suma es {0}",suma);

            Console.ReadLine();

        }

        public static int Mayor(int n1, int n2) { 
            
            int numero=0;
            if (n1 >= n2)
                numero = n1;
            else
                numero = n2;

            return numero;
            
        }

        public static void EscribirMayusculas(String texto) {

            Console.WriteLine(texto.ToUpper());
        
        }

        public static int SumarMuchos(int[] numeros) {

            int resultado = 0;

            foreach (var numero in numeros) {
                resultado += numero;
            }

            return resultado;
        
        }

    }
}
