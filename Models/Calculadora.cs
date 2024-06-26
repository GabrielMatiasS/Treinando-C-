using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemplosFundamentos
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void seno(double angulo)
        {
            double radians = angulo * Math.PI / 180;
            double seno = Math.Sin(radians);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }
        public void cosseno(double angulo)
        {
            double radians = angulo * Math.PI / 180;
            double coseno = Math.Cos(radians);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno,4)}");

        }
        public void tangente(double angulo)
        {
            double radians = angulo * Math.PI / 180;
            double tangente = Math.Tan(radians);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");

        }
        public void RaizQuadrada(double x)
        {
            double  raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quandrada de {x} = {raiz}");
        }
    }    
    
}