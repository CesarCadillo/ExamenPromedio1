using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProm1_CesarCadillo
{
    public class City
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Population { get; set; }
        public int CurrentMonth { get; set; }
        public List<IBuilding> Buildings { get; set; }

        public City(string name, int money, int population, int currentMonth)
        {
            Name = name;
            Money = money;
            Population = population;
            CurrentMonth = currentMonth;
            Buildings = new List<IBuilding>();            
        }

    }
}
