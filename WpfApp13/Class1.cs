using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13
{
    public abstract class Car
    {
        public string? Model { get; set; }
        public int Year { get; set; }
        public string ?Color { get; set; }

        public string? ImagePath { get; set; }


        public override string ToString()
        {
            return $"Model:{Model} Year:{Year}Color:{Color}";
        }
    }


    public class Lada:Car{}

    public class Hyundai : Car{ }

    public class BMW:Car{ }

    public class Mercedes:Car { }
}
