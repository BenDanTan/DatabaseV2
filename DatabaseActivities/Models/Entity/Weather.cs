using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class Weather:IEntity
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int hi { get; set; }
        public int low { get; set; }
    }
}