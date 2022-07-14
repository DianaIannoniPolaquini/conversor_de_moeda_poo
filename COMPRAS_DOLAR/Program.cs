using System;

namespace COMPRAS_DOLAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você irá comprar? ");
            double y = double.Parse(Console.ReadLine());
           
            double result = ConversorDeMoeda.ValorReais(x, y);
            
            Console.WriteLine($"Valor a ser pago em reais = {result} reais.");
        }
    }
}
