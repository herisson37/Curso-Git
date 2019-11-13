using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //    double a = 1.0, b = -3.0, c = -4.0;

            //    double delta = Math.Pow(b, 2.0) - 4 * a * c;

            //    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);

            //    Console.WriteLine(x1.ToString("F2"));

            //    int a1 = 5;

            //    int b2 = 2;

            //    double resultado = (double) a1 / b2;

            //    Console.WriteLine(resultado);


            //string[] v = Console.ReadLine().Split(" ");

            //string a = v[0];
            //string b = v[1];
            //string c = v[2];

            //Console.WriteLine(a + b + c);

            //int n1 = int.Parse(Console.ReadLine());

            //char ch = char.Parse(Console.ReadLine());

            //double n2 = double.Parse(Console.ReadLine());

            //string[] vet = Console.ReadLine().Split(" ");

            //string nome = vet[0];

            //char sexo = char.Parse(vet[1]);

            //int idade = int.Parse(vet[2]);

            //double altura = double.Parse(vet[3]);

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);

            Console.WriteLine("Coloque 3 numeros: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            int test;

            Console.WriteLine("Maior: " + resultado);
            





        }

        static int Maior (int a, int b, int c)
        {

            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }


    }
}
