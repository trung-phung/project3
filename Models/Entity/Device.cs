using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models.Entity
{
    public class Device
    {
        public int DeviceId { get; set; }
        public String DeviceName { get; set; }
        public String Status { get; set; }
        public int LapId { get; set; }
        public virtual Lap Lap { get; set; }
    }
}