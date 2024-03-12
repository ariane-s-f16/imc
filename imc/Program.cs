using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu peso(kg)");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("digite sua altura( metros )");
            double alt = double.Parse(Console.ReadLine());

            double total = peso / (alt * alt) ; 

            if (total <= 16.9 ) 
            { 
                Console.WriteLine("muito abaixo do peso com imc = " + total );
            }
            else if( total > 16.9 && total <= 18.4 ) 
            {
                Console.WriteLine("abaixo do peso com imc = " + total);
            }
            else if(total >18.4 && total<= 24.9)
            {
                Console.WriteLine("peso normal com imc = " + total );
            }
            else if (total > 24.9 && total <= 29.9 ) 
            {
                Console.WriteLine("acima do peso normal com imc = " + total);
            }
            else if (total > 29.9 && total <= 34.9 )
            {
                Console.WriteLine("obsedade grau 1 com imc  = " + total );
            }
            else if (total > 34.9 && total <= 40) 
            {
                Console.WriteLine("obsidade grau 2 com imc = " + total );
            }
            else if ( total > 40) 
            {
                    Console.WriteLine("obsedade grau 3 com imc  = " + total);
            }
            else 
            {
                Console.WriteLine("RODE NOVAMENTE, INFORMAÇÃO INVÁLIDA");
            }
            Console.ReadKey();
        }
    }
}
