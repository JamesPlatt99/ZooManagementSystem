using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;

namespace Zoo.ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            var lions = new[]
            {
                new Lion(new DateTime(2010, 4, 28)),
                new Lion(new DateTime(2012, 5, 11))
            };
            var otherAnimals = new Animal[] {
                new Rabbit(new DateTime(2014, 1, 1)),
                new GuineaFowl(new DateTime(2009,4,20)),
                new Zebra(new DateTime(2008, 12, 1))
            };
            var animals = lions.Union<Animal>(otherAnimals).ToList();

            var keepers = new[]
            {
              new Keeper(lions),
              new Keeper(otherAnimals)
            };

            List<IScheduler> Schedulers = new List<IScheduler>
            {
                FeedingScheduler.Instance,
                GroomingScheduler.Instance,
                MuckSweepingScheduler.Instance
            };

            while (true)
            {
                foreach (IScheduler scheduler in Schedulers)
                {
                    scheduler.DisplayTaskInfo();
                    scheduler.AssignJobs(keepers,animals);
                }
                Console.WriteLine("Done. Results:");

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal);
                }

                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}