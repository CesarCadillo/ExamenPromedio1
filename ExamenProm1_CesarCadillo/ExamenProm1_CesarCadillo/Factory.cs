using System;

namespace ExamenProm1_CesarCadillo
{
    public class Factory : Building
    {
        public Factory()
        {
            name = "Fábrica";
            cost = 5000;
            monthlyIncome = 500;
            population = 20;
        }

        public override void Operate()
        {
            Console.WriteLine($"La fábrica emplea a {population} ciudadanos y genera {monthlyIncome} de ingresos mensuales.");
        }
    }    
}
