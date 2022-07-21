using Project3.Models;
using Project3.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project3
{
    public class DbInitializer : DropCreateDatabaseAlways<ModelContext>
    {
        protected override void Seed(ModelContext db)
        {
            var laps = new List<Lap>
            {
                new Lap
                {
                    LapName = "Lap 1"
                },
                new Lap
                {
                    LapName = "Lap 2"
                }
            };
         

            laps.ForEach(s => db.Laps.Add(s));
            db.SaveChanges();
        }
    }
    }