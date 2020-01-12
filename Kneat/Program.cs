using Kneat.Business;
using Kneat.Exceptions;
using Kneat.Model;
using System;
using System.Collections.Generic;

namespace Kneat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("\nPlease, type the distance in mega lights.");
                    double distanceInMGLT = MGLTCalculation.ValidateMGLTInput(Console.ReadLine());

                    Console.WriteLine("\nGetting all the starships available.");
                    System.Threading.Thread.Sleep(1000);

                    List<StarshipModel> starships = Starship.GetStarshipsAsync();
                    int Id = 1;

                    System.Threading.Thread.Sleep(3000);

                    Console.WriteLine("\n{0,5} | {1,-30}| {2,1}", "Id", "Name", "Amount of Stops");
                    starships.ForEach((starship) =>
                    {
                        if (starship.Consumables != "unknown" && starship.MGLT != "unknown")
                        {
                            if (MGLTCalculation.ValidateConsumable(starship.Consumables))
                            {
                                starship.ConsumablesInHours = MGLTCalculation.ConsumablesToHours(starship.Consumables);
                                starship.Stops = MGLTCalculation.CalculateStops(
                                    distanceInMGLT, Convert.ToInt32(starship.MGLT), starship.ConsumablesInHours);
                            }
                        }

                        System.Threading.Thread.Sleep(300);
                        Console.WriteLine("{0, 5} | {1,-30}| {2,1}",
                            Id++, starship.Name,
                            starship.Stops != null ? starship.Stops.ToString() : "unknown");
                    });

                    Console.WriteLine("\nPress ESC or press another key to try again!");


                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                Console.WriteLine("\nThanks!");
                Console.WriteLine("Closing the application.");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n");

                if (ex is NegativeValueException || ex is ValueIsNotANumberException)
                {
                    Console.WriteLine("Try again!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Main(args);
                }
            }
        }
    }
}
