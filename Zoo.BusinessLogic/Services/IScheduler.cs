using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public interface IScheduler
    {
        void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals);

        void DisplayTaskInfo();
    }
}