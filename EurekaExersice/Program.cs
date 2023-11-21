using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       Eureka.SumDigPow(1, 340);

    }



    public static class Eureka
    {
        public static long[] SumDigPow(long a, long b)
        {
            
            ArrayList numeros = new ArrayList();
           
            string ComprobarNumPosiciones = "";
            int posiciones = 0;
            int comprobarLongitudNumero = 0;
            
            int sumaPorComprobar = 0;
            if (a > b) return [-1];
           
            for (long i = a; i <= b; i++) 
            {
                ComprobarNumPosiciones = i.ToString();
                posiciones = ComprobarNumPosiciones.Length;
                comprobarLongitudNumero = (int)i;
                long numeroTomado = 0;
             
                while (comprobarLongitudNumero > 0) 
                {
                    numeroTomado = comprobarLongitudNumero % 10;
                    comprobarLongitudNumero /= 10;
                    

                  
                    sumaPorComprobar = (int)(sumaPorComprobar + Math.Pow(numeroTomado, posiciones));
                    //Console.WriteLine($"Este es la suma {sumaPorComprobar} , este  es el numero {i}");
                    posiciones--;

                }
                
                if(sumaPorComprobar == i) 
                {
                    
                    numeros.Add(i);
                    foreach(long o in numeros) 
                    {
                      
                    }
                }
                
                sumaPorComprobar = 0;
                posiciones = 0;
                comprobarLongitudNumero = 0;
            }
            long [] numerosEureka = new long[numeros.Count];
           for(int i = 0; i <= numerosEureka.Length-1; i++) 
            {
                numerosEureka[i] = (long)numeros[i];
            }

            return numerosEureka;

        }
    }
}