using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class WeatherService
    {
        private WeatherRepository repository;

        public WeatherService()
        {
            repository = new WeatherRepository();
        }

        public List<Weather> GetAllWeathers()
        {
            return repository.GetAllWeathers();
        }

        public void AddWeather(Weather toAdd)
        {
            repository.AddWeather(toAdd);
        }

        public Weather GetWeatherById(int id)
        {
            return repository.GetWeatherById(id);
        }

        public void SaveEdits(Weather toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteWeather(Weather toDelete)
        {
            repository.DeleteWeather(toDelete);
        }
    }
}