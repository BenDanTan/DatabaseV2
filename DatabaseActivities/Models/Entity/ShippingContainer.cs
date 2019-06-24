using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class ShippingContainer:IEntity
    {
        public int Id { get; set; }
        public int weight { get; set; }
        public String destination { get; set; }
    }
}