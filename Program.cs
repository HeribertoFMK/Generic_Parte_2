using System;
using System.Collections.Generic;
using Generic_Parte_2;
using System.Globalization;

namespace Curso_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> list = new List<int>();

            // System.Console.WriteLine("Enten N:");

            // int n = int.Parse(Console.ReadLine());

            // for (int i = 0; i < n; i++)
            // {
            //     int x = int.Parse(Console.ReadLine());
            //     list.Add(x);

            // }
            // CalculationService calcular = new CalculationService();
            // int max = calcular.Max(list);

            // System.Console.Write(" Max : ");
            // System.Console.WriteLine(max);


            List<Product> list = new List<Product>();

            System.Console.WriteLine("Enten N:");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(",");

                string nome = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                Product produto = new Product(nome, price);

                list.Add(produto);

            }
            CalculationService calcular = new CalculationService();
            Product max = calcular.Max(list);

            System.Console.Write(" Max : ");
            System.Console.WriteLine(max);










        }
    }
}
