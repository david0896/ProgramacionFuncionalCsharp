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
            int valorUno = 0;
            int valorDos = 0;
            string resultado = "";
            
            Func<int, bool> evaluaPar =  numero => numero % 2 == 0;

            Console.WriteLine("Ingrese un valor para evaluar si es par o no");

            inValor = Convert.ToInt32(Console.ReadLine());

            resultado = evaluaPar(inValor) == true ? "es un numero par" : "no es un numero par";

            Console.WriteLine("el numero inresado " + inValor + ": " + resultado );

            Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////////

            Func<int, int, int> Sumatotal = (numeroUno, numeroDos) => numeroUno + numeroDos;

            Console.WriteLine("Ingrese dos numeros para mostrar el producto de su suma");

            valorUno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Presione ENTER para ingresar el siguiente numero");

            valorDos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("el numero resultado de la suma entre  " + valorUno + " y " + valorDos + " es: " + Sumatotal(valorUno, valorDos) + "\n");

            ///////////////////////////////////////////////////////////////////////////////////

            Func<string, bool> validadorCorreo = correo =>
            {

                if (!correo.EndsWith("gmail.com", StringComparison.CurrentCulture))
                {
                    Console.WriteLine("Correo no valido");
                    return false;
                }

                return true;
            };

            Console.WriteLine("Correo ingresado es: " + validadorCorreo("prueba@gmail.com"));

        }
    }
}
