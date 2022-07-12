using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models.Entity
{
    public class ComplaintDevice
    {
        public int ComplaintDeviceId { get; set; }
        public int ComplaintId { get; set; }
        public int DeviceId { get; set; }
        public virtual Complaint Complaint { get; set; }
        public virtual Device Device { get; set; }
    }
}