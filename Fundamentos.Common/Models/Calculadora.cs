using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a soma de dois números inteiros
        /// </summary>
        /// <param name="x">Primeiro numero da Soma </param>
        /// <param name="y">Segundo número da Soma</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"Soma de {x} + {y} = {x + y}");
        }

/// <summary>
/// Realiza a subtração de dois números inteiros
/// </summary>
/// <param name="x">primeiro numero</param>
/// <param name="y"></param>
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração de {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Multiplicação de {x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"Divisão de {x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"Potência de {x} elevado a {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI) / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * (Math.PI) / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI) / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double numero)
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"Raiz Quadrada de {numero} = {Math.Round(raiz, 4)}");
        }
        
        
    }
}