using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public interface ICanHaveMuckSweptOut
    {
        DateTime LastSwept { get; set; }

        string ToString();
    }
}