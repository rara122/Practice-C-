using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Bike
    {
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public Nullable<DateTime> ReleaseDate { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
