using System;

namespace ExamenProm1_CesarCadillo
{
    public class House : Building
    {
        public House()
        {
            name = "Casa";
            cost = 1000;
            monthlyIncome = 100;
            population = 4;
        }

        public override void Operate()
        {
            Console.WriteLine($"La casa proporciona vivienda a {population} ciudadanos y genera {monthlyIncome} de ingresos mensuales.");
        }
    }
}
