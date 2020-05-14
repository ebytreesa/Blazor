using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrundfosApp.Data
{
    public class WaterFlow
    {
        public double WaterPresssure { get; set; }
        public string Status
        {
            get
            {
                if (WaterPresssure > 50)
                {
                    return "Danger";
                }
                else
                {
                    return "Normal";
                }
            }
        }
    }
}
