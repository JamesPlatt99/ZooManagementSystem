using System;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public static class Tasks
    {
        public static void SweepMuckFromAnimal(ICanHaveMuckSweptOut animalToSweep)
        {
            animalToSweep.LastSwept = DateTime.Now;
        }
    }
}