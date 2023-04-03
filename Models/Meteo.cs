using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MeteoApp.Models
{
    public struct Coord
    {
        public float lon;
        public float lat;
    }
    public struct Weather
    {
        public float id;
        public string main;
        public string description;
        public float icon;
    }
    public struct Base
    {

    }
    public struct Main
    {
        public float temp;
        public float feels_like;
        public float pressure;
        public float humidity;
        public float temp_max;
        public float temp_min;
        public float grnd_level;
        public float sea_level;
    }
    public struct Visibility
    {

    }
    public struct Wind
    {
        public float speed;
        public float deg;
        public float gust;
    }
    public struct Clouds
    {
        public float all;
    }
    public struct Rain
    {
        public float oneh;
        public float threeh;
    }
    public struct Snow
    {
        public float oneh;
        public float threeh;
    }
    public struct Dt
    {

    }
    public struct Sys
    {
        public float type;
        public float id;
        public string message;
        public string country;
        public float sunrise;
        public float sunset;
    }
    public struct Timezone
    {

    }

    public class Meteo
    {
        public Coord Coord { get; set; }
        public Weather Weather { get; set; }
        public Base Base { get; set; }
        public Main Main { get; set; }
        public Visibility Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public Dt Dt { get; set; }
        public Sys Sys { get; set; }
        public Timezone Timezone { get; set; }

    }
}

