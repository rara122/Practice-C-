using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BikeContext())
            {
                var m1 = new Manufacturer { ManufacturerName = "Kawasaki" };
                var m2 = new Manufacturer { ManufacturerName = "Ducati" };
                var m3 = new Manufacturer { ManufacturerName = "Yamaha" };
                context.Manufacturers.Add(m1);
                context.Manufacturers.Add(m2);
                context.Bikes.Add(new Bike { BikeName = "Ninja",  Manufacturer = m1});
                context.Bikes.Add(new Bike { BikeName = "Scramber", Manufacturer = m2 });
                context.Bikes.Add(new Bike { BikeName = "Fizzer", Manufacturer = m3 });

                context.SaveChanges();

                var results = context.Bikes.Where(b => b.Manufacturer.ManufacturerName == "Yamaha").ToList();
            }
        }
    }
}
