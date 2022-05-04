using Product_Milk.Models;
using System;

namespace Product_Milk
{
    class Program
    {
        static void Main(string[] args)
        {

            Milk atena = new Milk("Atena", 2.3F, 1, 3.5D);
            atena.Sell();
            Milk palsud = new Milk("Pal sud", 1.7F, 5, 2);
            palsud.Sell();
        }
    }
}
