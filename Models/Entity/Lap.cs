using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models.Entity
{
    public class Lap
    {
        
        public int LapId { get; set; }
        public String LapName { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        
    }
}