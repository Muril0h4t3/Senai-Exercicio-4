using System;

namespace senai.operadores.ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura");

            Console.WriteLine("Informe a temperatura");
            float temp = float.Parse(Console.ReadLine());

            Console.WriteLine("A temperatura é de: " + temp + "° Celsius");

            float fah = (float)( (9* temp + 160) / 5 );

            Console.WriteLine("A temperatura é de: " + fah + "° Fahrenheit");
        }
    }
}
