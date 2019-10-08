using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Michelle Jimenez";
        private DateTime _dateConstructed;
        private string _address = "301 Blvd Nashville,TN";
        private string _owner = "Billy";
        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }


        public double Volume
        {
            get
            {
                return Width * Depth * Stories * 3;
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public void Construct(){
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner){
            _owner = owner;
        }
        public void GetInformation(){
            Console.WriteLine($"{_address}");
            Console.WriteLine("------------------------");
            Console.Write($"Designed by {_designer} \nConstructed on {_dateConstructed} \nOwned by {_owner} \n{Volume} cubic meters of space");
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}