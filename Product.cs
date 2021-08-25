using System.Globalization;
using System.Collections.Generic;
using System;
namespace Generic_Parte_2
{
    public class Product : IComparable
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;

        }

        public override string ToString()
        {
            return Nome
                   + " ,"
                   + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {

            if (!(obj is Product))
            {

                throw new ArgumentException("Comparing Error: arguments is note a product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);

        }


    }

}