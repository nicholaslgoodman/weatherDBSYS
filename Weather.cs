﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApp.Models
{
    public class Weather
    {
        // zip, city, state, time, temperature, feelslike, 
        // humidity, windspeed, airpressure, visibility, uv index

        [Key, Column(Order = 0)]
        public int ZIP { get; set; }
        [Key, Column(Order = 1)]
        public string City { get; set; }
        [Key, Column(Order = 2)]
        public string State { get; set; }
        [Key, Column(Order = 3)]

        [DataType(DataType.Date)]
        public Date Day { get; set; }
        public decimal Temperature { get; set; }
        public decimal FeelsLike { get; set; }
        public string WindDirection { get; set; }
        public decimal WindSpeed { get; set; }
        public decimal Humidity { get; set; }
        public decimal AirPressure { get; set; }
        public decimal Visibility { get; set; }
        public decimal UVIndex { get; set; }

        [DataType(TimeSpan)]
        public TimeSpan Sunrise { get; set; }

        [DataType(TimeSpan)]
        public TimeSpan Sunset { get; set; }

        //[DataType(TimeSpan)]
        public TimeSpan Moonrise { get; set; }

        [DataType(TimeSpan)]
        public TimeSpan Moonset { get; set; }
    }
}
