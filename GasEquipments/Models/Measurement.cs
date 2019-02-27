using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasEquipments.Models
{
    public class Measurement
    {
        public int MeasurementId { get; set; }
        public string Date { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }

        public int EquipmentId { get; set; } // ссылка на связанную модель Equipment
        public Equipment Equipment { get; set; }
    }
}
