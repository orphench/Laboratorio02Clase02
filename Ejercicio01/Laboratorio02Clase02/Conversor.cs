using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase02
{
    class Conversor
    {
        public static string DecimalBinario(Double numero) 
        {
            string binario = "";
            
            while (numero > 0)
            {
                int resto = (int)numero % 2;
                binario = binario + resto;
                numero = numero / 2;
                int resultado = (int)numero / 2;

                if (resultado < 3) 
                {
                    break;
                }

                
            }
            return binario;
            //Console.WriteLine("binario: {0}",binario);
           
        }

        public static double BinarioDecimal(string binario) 
        {
            double numero = 0;
            int dato;
            int exponente = binario.Length - 1;

            for (int i = 0; i < binario.Length; i++)
            {
                //int.TryParse(binario, out dato);//combierte binario(string) a dato(int)

                if (int.Parse(binario.Substring(i,1))==1)
                {
                    numero = numero + int.Parse(
                }
                
                //lstgo -(i+1)

                numero = dato * 10;
            }
            
                
            
            

            return numero;
        }


    }
}
