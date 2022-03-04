using System.Collections.Generic;
using System;
using ConsoleAppFuncional.generico;


namespace ConsoleAppFuncional
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambdasExpression();

            //MisDelegados myDelegates = new MisDelegados();
            //MisDelegados.DelegadoOperacion retiro = myDelegates.retiro;
            //MisDelegados.DelegadoOperacion deposito = myDelegates.deposito;
            //Console.WriteLine("Saldo restante: " + myDelegates.RealizaOperacion(deposito, 1001, 1000));
            //Console.WriteLine("Saldo restante: " + myDelegates.RealizaOperacion(retiro, 1001, 1000));

            ////usando lambada para agregar una nueva funcionalidad al delegado 
            //MisDelegados.DelegadoOperacion depositoInteres = (cantidad, monto) =>
            //{

            //    if (cantidad > 100)
            //    {
            //        return cantidad + monto + (cantidad * 0.02f);
            //    }

            //    return cantidad + monto;
            //};

            //Console.WriteLine("Saldo restante: " + myDelegates.RealizaOperacion(depositoInteres, 140, 300));

            //Console.WriteLine(new practicasDelegadosLambda().validNumPrimo(233));

            //Console.WriteLine("El factorial de 4 es: " + new practicasDelegadosLambda().factorialNum(7));

            //Console.WriteLine(new practicasDelegadosLambda().validNumPrimo(233));

            //Console.WriteLine(new practicasDelegadosLambda().promedioNumeros(new List<int>()
            //    {
            //        2,
            //        4,
            //        6
            //    })
            //);

            //Console.WriteLine(new practicasDelegadosLambda().buscarNumero(new List<int>()
            //    {
            //        79,
            //        4,
            //        6
            //    })
            //);

            //Console.WriteLine(new practicasDelegadosLambda().evalNumsPrimos(7,7,7));

            //Console.WriteLine(new practicasDelegadosLambda().evalPalindromoText("ojo"));

            foreach (Genericos gn in new practicasDelegadosLambda().evalPalindromoList(new List<string>()
                {
                    "oso",
                    "sol",
                    "ojo",
                    "carro"
                })) {

                Console.WriteLine(gn.texto + ": " + (gn.palindromo == true ? "palindromo" : "no palindromo"));
            
            }
        }

        public static void lambdasExpression() {
            //lambda = funcion anonima 
            //(parametros) => el cuerpo de la funcion 
            int inValor = 0;
            int valorUno = 0;
            int valorDos = 0;
            string resultado = "";

            Func<int, bool> evaluaPar = numero => numero % 2 == 0;

            Console.WriteLine("Ingrese un valor para evaluar si es par o no");

            inValor = Convert.ToInt32(Console.ReadLine());

            resultado = evaluaPar(inValor) == true ? "es un numero par" : "no es un numero par";

            Console.WriteLine("el numero inresado " + inValor + ": " + resultado);

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

            //////////////////////////////////////////////////////////////////////////////////////

            Action<string, int> saludar = (mensaje, numero) =>
            {

                Console.WriteLine(mensaje + numero);

            };

            saludar("Hola mundo :)  ", 404);
        }
    }
}
