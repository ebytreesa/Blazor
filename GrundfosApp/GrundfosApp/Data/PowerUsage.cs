using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrundfosApp.Data
{
    public class PowerUsage
    {
        public double W { get; set; }
        public string Status
        {
            get
            {
                if (W > 50)
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
