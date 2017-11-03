using System;
using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class MuckSweepingScheduler : IScheduler
    {
        private static MuckSweepingScheduler instance;

        public static MuckSweepingScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MuckSweepingScheduler();
                }

                return instance;
            }
        }

        private MuckSweepingScheduler()
        {
        }

        public void DisplayTaskInfo()
        {
            Console.WriteLine("Sweeping the animals...");
        }

        public void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal is ICanHaveMuckSweptOut sweepableAnimal)
                    {
                        keeper.SweepAnimal(sweepableAnimal);
                    }
                }
            }
        }
    }
}