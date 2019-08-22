using AnimalLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class Animal
    {
        #region Properties

        public int Id { get; }

        public Kind Species { get; }

        public AnimalState State { get; }

        DateTime BirthDate { get; }

        public int WeightInGrams { get; }

        public FoodType Meal { get; }

        #endregion

        #region Methods
        public int GetAge(AgeType ageType)
        {
            if (State == AnimalState.Dead)
            {
                return -1;
            }

            switch (ageType)
            {
                case AgeType.Days:
                    return (DateTime.Now - BirthDate).Days;
                case AgeType.Years:
                    return DateTime.Now.Year - BirthDate.Year;
                default:
                    return -1;
            }
        }

        #endregion
    }
}
