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
        private WeatherRepository suppository;

        public WeatherService()
        {
            suppository = new WeatherRepository();
        }

        public List<Weather> GetAllWeathers()
        {
            return suppository.GetAllWeathers();
        }

        public void AddWeather(Weather toAdd)
        {
            suppository.AddWeather(toAdd);
        }

        public Weather GetHottestDay()
        {
            Weather hot = new Weather();
            List<Weather> climates = suppository.GetAllWeathers();
            foreach (Weather wet in climates)
            {
                if (wet.Hi >= hot.Hi)
                {
                    hot = wet;
                }
            }
            return hot;
        }

        public Weather GetLargestRange()
        {
            Weather large = new Weather();
            List<Weather> climates = suppository.GetAllWeathers();
            foreach (Weather wet in climates)
            {
                if (wet.Hi - wet.Low >= large.Hi - large.Low)
                {
                    large = wet;
                }
            }
            return large;
        }

        public List<Weather> GetWeatherDateRange(DateTime begin, DateTime end)
        {
            List<Weather> days = new List<Weather>();
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                days.Add(suppository.GetWeatherByDate(date));
            }
            return days;
        }
    }
}