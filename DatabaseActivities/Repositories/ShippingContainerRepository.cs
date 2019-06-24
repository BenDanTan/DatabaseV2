using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class ShippingContainerRepository
    {
        private ApplicationDbContext dbContext;

        public ShippingContainerRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public List<ShippingContainer> GetAllShippingContainers()
        {
            return dbContext.ShippingContainers.ToList();
        }

        public void AddShippingContainer(ShippingContainer toAdd)
        {
            dbContext.ShippingContainers.Add(toAdd);
            dbContext.SaveChanges();
        }

        public ShippingContainer GetShippingContainerById(int id)
        {
            return dbContext.ShippingContainers.Find(id);
        }

        public void SaveEdits(ShippingContainer toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteShippingContainer(ShippingContainer toDelete)
        {
            dbContext.ShippingContainers.Remove(toDelete);
            dbContext.SaveChanges();
        }
    }
}