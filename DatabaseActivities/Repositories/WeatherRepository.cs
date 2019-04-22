using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class WeatherRepository
    {
        private ApplicationDbContext dbContext;

        public WeatherRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public List<Weather> GetAllWeathers()
        {
            return dbContext.Weathers.ToList();
        }

        public void AddWeather(Weather toAdd)
        {
            dbContext.Weathers.Add(toAdd);
            dbContext.SaveChanges();
        }

        public Weather GetWeatherById(int id)
        {
            return dbContext.Weathers.Find(id);
        }

        public void SaveEdits(Weather toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteWeather(Weather toDelete)
        {
            dbContext.Weathers.Remove(toDelete);
            dbContext.SaveChanges();
        }
    }
}