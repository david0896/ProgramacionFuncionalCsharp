using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppFuncional.generico;

namespace ConsoleAppFuncional
{
    public class practicasDelegadosLambda
    {
        //Crear una función anónima que nos permita conocer si un número es primo o no
        static int Contador = 0;

        public static Func<int, bool> validNumPrimo = numEvaluar =>
        {
            //int Contador = 0;

            for (int i = 1; i <= numEvaluar; i++)
            {
                if (numEvaluar % i == 0)
                {
                    //Console.WriteLine("Corresponde " + numEvaluar + " / " + i + " = " + numEvaluar / i + " (" + numEvaluar % i + ")");
                    Contador = Contador + 1;
                }
                else {
                    //Console.WriteLine("No corresponde " + numEvaluar + " / " + i + " = " + numEvaluar/i + " (" + numEvaluar%i + ")");

                }
            }

            if (Contador == 2)
            {
                return true;
            }
            else {

                return false;

            }


        };

        //Crear una función anónima que calcule el factorial dado un número entero

        public Func<int, int> factorialNum = num =>
        {
            int cont = 1, aux1 = 0, aux2 = 1;

            while (cont <= num) {
                //Console.WriteLine(cont);
                if (num == 0) return 1;
                aux1 = cont;
                aux2 *= aux1;
                cont++;
            }

            return aux2;
        };

        //Dado una lista de números enteros, crear una función anónima que nos permita conocer el promedio de dicha lista

        public Func<List<int>, int> promedioNumeros = list =>
        {
            int count = list.Count();
            int totalSum = list.Sum();

            return ((int)list.Average());//totalSum / count;
        };

        //Dado una lista de números enteros, crear una función anónima que nos permita conocer si el número 79 se encuentra dentro de la lista

        public Func<List<int>, bool> buscarNumero = list =>
        {
            return list.Contains(79);
        };

        //Crear una función anónima que recibe 3 parámetros de tipo entero. La función debe retornar verdadero si los parámetros son números primos, en caso contrario retorna falso

        public Func<int, int, int, bool> evalNumsPrimos = (num1, num2, num3) =>
        {
            bool flag = false;

            if (validNumPrimo(num1))
                flag = true;

            if (validNumPrimo(num2))
                flag = true;

            if (validNumPrimo(num3))
                flag = true;

            return flag;
        };

        public static Func<string, bool> evalPalindromoText = text =>
        {
            char[] TextOrigin = text.ToCharArray();
            Array.Reverse(TextOrigin);
            return new string(TextOrigin) == text ? true : false;
        };

        public Func<List<string>, List<Genericos>> evalPalindromoList = Lista =>
        {
            List<Genericos> listEvaluados = new List<Genericos>();
             
            foreach (string text in Lista) {
                Genericos gn = new Genericos();
                gn.texto = text;

                if (evalPalindromoText(text))
                {
                    gn.palindromo = true;
                    listEvaluados.Add(gn);
                }
                else 
                {
                    gn.palindromo = false;
                    listEvaluados.Add(gn);
                }
            }

            return listEvaluados;

        };
    }

}
