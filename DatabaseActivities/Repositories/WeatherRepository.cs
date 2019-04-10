using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
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

        public Weather GetWeatherByDate(DateTime date) {
            return dbContext.Weathers.Find(date);
        }
    }
}