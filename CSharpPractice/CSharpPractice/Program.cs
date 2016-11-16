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
                List<Bike> bikes = new List<Bike>();
                bikes.Add(new Bike { BikeName = "Ninja" });
                bikes.Add(new Bike { BikeName = "Scramber" });

                context.Bikes.AddRange(bikes);
                context.SaveChanges();

            }
        }
    }
}
