using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProm1_CesarCadillo
{
    public class City
    {
        public string name { get; set; }
        public int money { get; set; }
        public int population { get; set; }
        public int currentMonth { get; set; }

        public City(string name, int money, int population, int currentMonth)
        {
            this.name = name;
            this.money = money;
            this.population = population;
            this.currentMonth = currentMonth;
        }

    }
}
