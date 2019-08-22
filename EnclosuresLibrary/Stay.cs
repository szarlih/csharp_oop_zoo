using AnimalLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnclosuresLibrary
{
    public class AnimalStay
    {
        public Animal Animal { get; }

        public DateTime FromDate { get; }

        public DateTime? ToDate { get; }

        public bool IsInside
        {
            get
            {
                return ToDate == null;
            }
        }
    }
}
