using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Milk.Models
{
    class Milk : Product
    {
        private double _volume;
        private double _fatRate;

        public double Volume
        {


            set
            {
                if (value != 0.250 || value != 0.5 || value != 1)

                    Console.WriteLine("Enter right volume (0.25 Lt, 0.5 Lt, 1Lt");

                else

                    _volume = value;

            }
            get
            {
                return _volume;

            }
        }
        public double FatRate { get; set; }
        public Milk(string name, float price, double volume, double fatRate) : base(name, price)
        {
            _volume = volume;
            FatRate = fatRate;

        }
        public Milk()
        {

        }

        public override void Sell()
        {
            if (Count >= 1)
            {


                Count--;
                TotalIncome += Price;
                TotalSaled++;

                Console.WriteLine($"Milk name : {Name} , Price : {Price} , " +
                    $"\n Volume {_volume} , FatRate {FatRate}, Count :" +
                    $" {Count}, \n Total saled : {TotalSaled}," +
                    $" \n Total income : {TotalIncome}");


            }
            else
            {
                Console.WriteLine("There is no product");

            }
        }
    }
}
