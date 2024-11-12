using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Games> games = new List<Games>()
            {
                new Games("The Witcher 3: Wild Hunt", Genre.Action, 59.99m),
                new Games("Red Dead Redemption II", Genre.Adventure, 39.99m),
                new Games("The Elder Scrolls V: Skyrim", Genre.RPG, 49.99m),
                new Games("Pro Evolution Soccer 5", Genre.Sports, 19.99m),
                new Games("DOTA 2", Genre.Strategy, 49.99m)
            };

            Dictionary<Genre, (int totalSales, decimal totalRevenue)> salesReport = new Dictionary<Genre, (int totalSales, decimal totalRevenue)>();

            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                salesReport[(Genre)genre] = (0, 0);
            }

            int[,] fixedSales = new int[,]
            {
                { 3, 2, 1 },
                { 2, 3, 2 },
                { 1, 1, 0 },
                { 0, 2, 1 },
                { 1, 1, 1 }
            };

            for (int day = 0; day < 3; day++)
            {
                foreach (var game in games)
                {
                    int genreIndex = (int)game.Genre;
                    int salesCount = fixedSales[genreIndex, day];

                    var currentSalesData = salesReport[game.Genre];

                    currentSalesData.totalSales += salesCount;
                    currentSalesData.totalRevenue += salesCount * game.Price;

                    salesReport[game.Genre] = currentSalesData;
                }
            }

            Console.WriteLine("Отчёт по продажам игр по жанрам:");
            foreach (var report in salesReport)
            {
                Console.WriteLine($"Жанр: {report.Key}");
                Console.WriteLine($"Общее количество продаж: {report.Value.totalSales}");
                Console.WriteLine($"Общая выручка: {report.Value.totalRevenue}");
                Console.WriteLine();
            }
        }
    }
}
