using System;

namespace ExamenProm1_CesarCadillo
{
    public class Hospital : Building
    {
        public Hospital()
        {
            name = "Hospital";
            cost = 10000;
            monthlyIncome = 200;
            population = 50;
        }

        public override void Operate()
        {
            Console.WriteLine($"El hospital atiende a la población, emplea a {population} ciudadanos y genera {monthlyIncome} de ingresos mensuales.");
        }
    }
}
