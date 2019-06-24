using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;

namespace DatabaseActivities.Service
{

    public class ShippingContainerService
    {
        private ShippingContainerRepository repository;
        public ShippingContainerService()
        {
            repository = new ShippingContainerRepository();
        }

        public List<ShippingContainer> GetAllShippingContainers()
        {
            return repository.GetAllShippingContainers();
        }

        public void AddShippingContainer(ShippingContainer toAdd)
        {
            repository.AddShippingContainer(toAdd);
        }

        public ShippingContainer GetShippingContainerById(int id)
        {
            return repository.GetShippingContainerById(id);
        }

        public void SaveEdits(ShippingContainer toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteShippingContainer(ShippingContainer toDelete)
        {
            repository.DeleteShippingContainer(toDelete);
        }
    }
}