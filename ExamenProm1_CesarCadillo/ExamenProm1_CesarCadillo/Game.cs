using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProm1_CesarCadillo
{
    public class Game
    {
        private City city;

        public Game()
        {
            InitializeCity();
        }

        public void InitializeCity()
        {
            Console.WriteLine("Bienvenido a tu nuevo juego de gestión de ciudad!");
            Console.Write("Por favor, ingresa el nombre de tu ciudad: ");
            string cityName = Console.ReadLine();

            int initialMoney = 5000; 
            int initialPopulation = 100; 
            int initialMonth = 1;

            city = new City(cityName, initialMoney, initialPopulation, initialMonth);

            Console.WriteLine($"Has fundado la ciudad de {cityName} con un miserable presupuesto tan miserable como tú: ${initialMoney}.");
            Console.WriteLine("Presiona Enter para comenzar tu aventura como alcalde...");
            Console.ReadLine();
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {                
                Console.WriteLine($"Ciudad: {city.Name} - Mes: {city.CurrentMonth} - Dinero: ${city.Money} - Población: {city.Population}");
                Console.WriteLine("1. Construir Casa (Costo: $1000)");
                Console.WriteLine("2. Construir Fábrica (Costo: $5000)");
                Console.WriteLine("3. Construir Hospital (Costo: $10000)");
                Console.WriteLine("4. Construir Escuela (Costo: $7000)");
                Console.WriteLine("5. Operar Ciudad");
                Console.WriteLine("6. Avanzar al siguiente mes");
                Console.WriteLine("7. Salir");
                Console.Write("Elige una opción: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        city.AddBuilding(new House());
                        break;
                    case "2":
                        city.AddBuilding(new Factory());
                        break;
                    case "3":
                        city.AddBuilding(new Hospital());
                        break;
                    case "4":
                        city.AddBuilding(new School());
                        break;
                    case "5":
                        city.OperateCity();
                        break;
                    case "6":
                        city.NextMonth();
                        if (city.CheckGameOver())
                        {
                            Console.WriteLine("¡GAME OVER! Tu ciudad ha sido abandonada por tus habitantes o invadida por bolivianos");
                            Console.WriteLine("Presiona Enter para salir...");
                            Console.ReadKey();
                            running = false;
                        }

                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"¡Abandonaste tu ciudad, como ella lo hizo contigo! Tu ciudad {city.Name} terminó con una población de {city.Population} y ${city.Money} en manos de Chibolin.");
        }

    }
}
