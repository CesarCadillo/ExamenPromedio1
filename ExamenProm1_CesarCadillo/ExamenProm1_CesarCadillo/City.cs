using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenProm1_CesarCadillo
{
    public class City
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Population { get; set; }
        public int CurrentMonth { get; set; }
        public List<IBuilding> Buildings { get; set; }
        private int consecutiveBuildingMonths;
        private int monthsWithoutBuilding;

        public City(string name, int money, int population, int currentMonth)
        {
            Name = name;
            Money = money;
            Population = population;
            CurrentMonth = currentMonth;
            Buildings = new List<IBuilding>();
            consecutiveBuildingMonths = 0;
            monthsWithoutBuilding = 0;
        }

        public void AddBuilding(Building building)
        {
            if (Money >= building.GetCost())
            {
                Buildings.Add(building);
                Money -= building.GetCost();
                Population += building.GetPopulation();
                consecutiveBuildingMonths++;
                monthsWithoutBuilding = 0;

                Console.WriteLine($"Se ha construido un {building.GetName()}. La población aumenta en {building.GetPopulation()}.");
            }
            else
            {
                Console.WriteLine("No hay suficiente dinero para construir este edificio.");
            }
        }

        public void OperateCity()
        {
            Console.WriteLine($"\nOperando la ciudad {Name} en el mes {CurrentMonth}:");
            foreach (var building in Buildings)
            {
                building.Operate();
            }
        }

        public bool CheckGameOver()
        {
            if (Population <= 0)
            {
                Console.WriteLine("HORA DE INVADIR ESPAÑAAA");
                return true;
            }

            if (CurrentMonth >= 15)
            {
                Console.WriteLine("MIGRACIÓN BOLIVIANA CORRAAAAN");
                return true;
            }

            return false;
        }

        public void NextMonth()
        {
            CurrentMonth++;
            int totalIncome = Buildings.Sum(b => (b as Building).GetMonthlyIncome()); //sumar los ingresos de todos los edificios
            Money += totalIncome;

            if (consecutiveBuildingMonths > 0)
            {
                consecutiveBuildingMonths++;
                monthsWithoutBuilding = 0;
            }
            else
            {
                monthsWithoutBuilding++;
                consecutiveBuildingMonths = 0;
            }

            //3 meses consecutivos de construcción y nos invaden 10% de invasores del cerro san cristobal
            if (consecutiveBuildingMonths >= 3)
            {
                int populationIncrease = Population / 10; 
                Population += populationIncrease;
                Console.WriteLine($"¡La población ha aumentado en {populationIncrease} debido al crecimiento constante!");
                consecutiveBuildingMonths = 0; 
            }

            //Disminuye la población ya que no se construyó durante 3 meses consecutivos y se irán 5% de invasores del cerro san cristobal
            if (monthsWithoutBuilding >= 3)
            {
                int populationDecrease = Population / 20; 
                Population -= populationDecrease;
                Console.WriteLine($"La población ha disminuido en {populationDecrease} debido a la falta de desarrollo.");
                monthsWithoutBuilding = 0;
            }

            Console.WriteLine($"\nAvanzando al mes {CurrentMonth}. Ingresos del mes: {totalIncome}");
            Console.WriteLine($"Dinero actual: {Money}");
            Console.WriteLine($"Población actual: {Population}");
        }
    }
}
