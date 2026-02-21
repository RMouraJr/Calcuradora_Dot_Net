using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcualdoraDotnet.Models
{
    public class Calculadora
    {
        public void Somar(double numero1, double numero2)
        {
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
        }

        public void Subitrair(double numero1, double numero2)
        {
            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
        }

        public void Multiplicar(double numero1, double numero2)
        {
            Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
        }

        public void Dividir(double numero1, double numero2)
        {
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
        }

        public void Potencia(double baseNum, double exp) // novo método Potencia , número da base é elevado ao expoente.
        {
            double Potencia = Math.Pow(baseNum, exp); // Math.Pow é o método usado para calcular potências
            Console.WriteLine($"{baseNum} ^ {exp} = {Potencia}");
        }

        public void RaizQuadrada(double numero) // novo método RaizQuadrada , calcula a raiz quadrada de um número.
        {
            double RaizQuadrada = Math.Sqrt(numero); // Math.Sqrt é o método usado para calcular a raiz quadrada
            Console.WriteLine($" A raiz quadrada de √ {numero} = {RaizQuadrada}");
        }

        public void RaizCubica(double numero) // novo método RaizCubica , calcula a raiz cúbica de um número.
        {
            double RaizCubica = Math.Cbrt(numero); // Math.Cbrt é o método usado para calcular a raiz cúbica
            Console.WriteLine($" A raiz cúbica de ∛ {numero} = {RaizCubica}");
        }

        public void Seno(double angulo) // novo método Seno , calcula o seno de um ângulo em graus.
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double Seno = Math.Sin(radiano); // Math.Sin é o método usado para calcular o seno
            Console.WriteLine($"O seno de ({angulo}°) = {Math.Round(Seno, 4)}");
        }

        public void Coseno(double angulo) // novo método Coseno , calcula o coseno de um ângulo em graus.
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double Coseno = Math.Cos(radiano); // Math.Sin é o método usado para calcular o coseno
            Console.WriteLine($"O seno de ({angulo}°) = {Math.Round(Coseno, 4)}");
        }
        
        public void Tangente(double angulo) // novo método Tangente , calcula a tangente de um ângulo em graus.
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double Tangente = Math.Tan(radiano); // Math.Tan é o método usado para calcular o tangente
            Console.WriteLine($"O seno de ({angulo}°) = {Math.Round(Tangente, 4)}");
        }
    }
}