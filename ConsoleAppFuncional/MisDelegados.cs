using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFuncional
{
    class MisDelegados
    {
        //delegado 
        public delegate float DelegadoOperacion(float valor1, float valor2);

        //ejercicio cajero
        //deposito
        public float deposito(float cantidad, float monto) {
            Console.WriteLine("Deposito realizado");
            return cantidad + monto;
        }

        public float retiro(float cantidad, float monto) {
            if (cantidad > monto) {
                Console.WriteLine("No es posible hacer el retiro");
                return 0.0f;
            }

            Console.WriteLine("Retiro realizado");
            return monto - cantidad;
        }

        public float RealizaOperacion(DelegadoOperacion dOperacion, float cantidad, float monto) {
            Console.WriteLine("Operacion iniciada");
            return dOperacion(cantidad, monto);
        }

    }
}
