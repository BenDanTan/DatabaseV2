using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class Weather:IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hi { get; set; }
        public int Low { get; set; }
    }
}