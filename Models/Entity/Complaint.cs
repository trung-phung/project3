using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models.Entity
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        public String Detail { get; set; }
        public int DeviceId { get; set; }
        public virtual ICollection<ComplaintDevice> ComplaintDevices
        {
            get;
            set;
        }        
    }
}