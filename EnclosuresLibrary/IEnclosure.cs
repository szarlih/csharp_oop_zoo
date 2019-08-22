using AnimalLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnclosuresLibrary
{
    interface IEnclosure
    {
        int Id { get; }
        string Name { get; }
        List<AnimalStay> StayHistory { get; }
    }
}
