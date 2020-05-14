using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrundfosApp.Data
{
    public class DataService
    {

        public WaterFlow waterflow { get; set; } = new WaterFlow();
        public PowerUsage powerUsage { get; set; } = new PowerUsage();
        public Frequency frequency { get; set; } = new Frequency();

        public void MeasureFlow()
        {
            var rnd = new Random();
            waterflow.WaterPresssure = rnd.Next(0, 99);
            powerUsage.W = rnd.Next(0, 99);
            frequency.Hz = rnd.Next(0, 99);
        }

        public Task<WaterFlow> MeasureFlows()
        {
            var rnd = new Random();
            return Task.FromResult(new WaterFlow { WaterPresssure = rnd.Next(0, 99) });
        }

        public Task<PowerUsage> MeasureW()
        {
            var rnd = new Random();
            return Task.FromResult(new PowerUsage { W = rnd.Next(0, 99) });
        }

        public Task<Frequency> MeasureHz()
        {
            var rnd = new Random();
            return Task.FromResult(new Frequency { Hz = rnd.Next(0, 99) });
        }  

    }

   
}
   
