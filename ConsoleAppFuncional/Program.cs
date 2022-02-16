using System;

namespace ConsoleAppFuncional
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda = funcion anonima 
            //(parametros) => el cuerpo de la funcion 
            int inValor = 0;
            string resultado = "";
            
            Func<int, bool> evaluaPar =  numero => numero % 2 == 0;

            Console.WriteLine("Ingrese un valor para evaluar si es par o no");

            inValor = Convert.ToInt32(Console.ReadLine());

            resultado = evaluaPar(inValor) == true ? "es un numero par" : "no es un numero par";

            Console.WriteLine("el numero inresado " + inValor + ": " + resultado );

            Console.ReadLine();
        }
    }
}
