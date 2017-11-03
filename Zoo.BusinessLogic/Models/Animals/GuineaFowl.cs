using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class GuineaFowl : Animal, ICanHaveMuckSweptOut
    {
        public DateTime LastSwept { get; set; }

        public GuineaFowl(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
    }
}