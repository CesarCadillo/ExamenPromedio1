using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProm1_CesarCadillo
{
    public abstract class Building : IBuilding
    {
        protected string name;
        protected int cost;
        protected int monthlyIncome;
        protected int population;

        public string GetName() => name;
        public int GetCost() => cost;
        public int GetMonthlyIncome() => monthlyIncome;
        public int GetPopulation() => population;

        public abstract void Operate();
    }
}
