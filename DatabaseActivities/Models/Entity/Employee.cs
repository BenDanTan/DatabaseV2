using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime hireDate { get; set; }
    }
}