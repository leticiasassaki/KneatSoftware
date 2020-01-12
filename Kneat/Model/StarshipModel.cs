using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Model
{
    public class StarshipModel
    {
        public string Name { get; set; }
        public string MGLT { get; set; }
        public string Consumables { get; set; }
        public int ConsumablesInHours { get; set; }
        public double? Stops { get; set; }
    }
}
