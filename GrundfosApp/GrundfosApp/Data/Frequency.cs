using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrundfosApp.Data
{
    public class Frequency
    {
        public double Hz { get; set; }
        public string Status
        {
            get
            {
                if (Hz > 50)
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

