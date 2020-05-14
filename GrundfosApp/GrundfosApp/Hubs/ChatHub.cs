using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GrundfosApp.Data;
using Microsoft.AspNetCore.SignalR;

namespace GrundfosApp.Hubs
{
    public class ChatHub : Hub
    {
        public DataService dataService { get; private set; }


        public async Task SendDataInfo()
        {
            dataService = new DataService();
            bool stop = true;
            while (stop)
            {
                dataService.MeasureFlow();
                await Clients.All.SendAsync("ReceiveDataInfo", dataService);
                Thread.Sleep(3000);
            }
        }

        //public async Task SendWaterFlowInfo()
        //{
        //    waterFlowService = new WaterFlowService();
        //    bool stop = true;
        //    while (stop)
        //    {
        //        waterFlowService.MeasureFlow();
        //        await Clients.All.SendAsync("ReceiveDataInfo", waterFlowService.waterFlow);
        //        Thread.Sleep(3000);
        //    }
        //}


    }
}
