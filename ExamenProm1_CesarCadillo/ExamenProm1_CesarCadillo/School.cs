using System;

namespace ExamenProm1_CesarCadillo
{
    public class School : Building
    {
        public School()
        {
            name = "Escuela";
            cost = 7000;
            monthlyIncome = 100;
            population = 30;
        }

        public override void Operate()
        {
            Console.WriteLine($"La escuela educa a los jóvenes, emplea a {population} ciudadanos y genera {monthlyIncome} de ingresos mensuales.");
        }
    }
}
