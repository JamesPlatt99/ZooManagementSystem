using System;
using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class FeedingScheduler : IScheduler
    {
        private static IScheduler instance;

        public static IScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FeedingScheduler();
                }

                return instance;
            }
        }

        private FeedingScheduler()
        {
        }

        public void DisplayTaskInfo()
        {
            Console.WriteLine("Feeding the animals...");
        }

        public void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal.IsHungry())
                    {
                        keeper.FeedAnimal(animal);
                    }
                }
            }
        }
    }
}