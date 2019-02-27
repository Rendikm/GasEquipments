using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasEquipments.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string StartingDate { get; set; }
        public double AllowablePressure { get; set; }
    }
}
