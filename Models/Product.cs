using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Milk.Models
{
    abstract class Product
    {
        public string Name;
        public float Price;
        public static int Count = 100;
        public static float TotalIncome;
        public static int TotalSaled;


        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {

        }

        public abstract void Sell();

    }
}
