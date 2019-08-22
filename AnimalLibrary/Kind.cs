namespace AnimalLibrary
{
    using AnimalLibrary.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Kind
    {
        public string Name { get; private set; }
        public Kingdoms Kingdom { get; set; }
    }
}
