using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class WeatherVM
    {
        public WeatherUnderground Weather { get; set; }

        private string query;

        public string Query
        {
            get { return query; }
            set
            {
                query = value;
            }
        }    

        public WeatherVM()
        {
            Weather = new WeatherUnderground();
        }
    }
}
