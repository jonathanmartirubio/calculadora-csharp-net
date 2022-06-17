using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class tCalculadora
    {
        private double valor1;
        private double valor2;
        private string operador;

        public double Valor1
        {
            get
            {
                return valor1;
            }

            set
            {
                valor1 = value;
            }
        }

        public double Valor2
        {
            get
            {
                return valor2;
            }

            set
            {
                valor2 = value;
            }
        }

        public string Operador
        {
            get
            {
                return operador;
            }

            set
            {
                operador = value;
            }
        }

        private double Sumar(double valor1, double valor2)
        {
            double suma = valor1 + valor2;
            return suma;
        }

        private double Restar(double valor1, double valor2)
        {
            double resta = valor1 - valor2;
            return resta;
        }

        private double Multiplicar(double valor1, double valor2)
        {
            double multiplicacion = valor1 * valor2;
            return multiplicacion;
        }

        private double Dividir(double valor1, double valor2)
        {
            double division = valor1 / valor2;
            return division;
        }

        private double Resto(double valor1, double valor2)
        {
            double resto = valor1 % valor2;
            return resto;
        }

        private double RaizCuadrada(double valor1)
        {
            double raizcuadrada = Math.Sqrt(valor1);
            return raizcuadrada;
        }

        public double Operar()
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = Sumar(valor1, valor2);
                    break;
                case "-":
                    resultado = Restar(valor1, valor2);
                    break;
                case "*":
                    resultado = Multiplicar(valor1, valor2);
                    break;
                case "/":
                    resultado = Dividir(valor1, valor2);
                    break;
                case "%":
                    resultado = Resto(valor1, valor2);
                    break;
                case "2":
                    resultado = Multiplicar(valor1, valor2);
                    break;
                case "√":
                    resultado = RaizCuadrada(valor1);
                    break;
            }

            return resultado;
        }
    }
}
