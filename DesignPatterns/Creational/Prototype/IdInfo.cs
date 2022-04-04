using System;

namespace DesignPatterns.Creational.Prototype
{
    public class IdInfo : ICloneable
    {
        public Guid IdNumber { get; set; }

        public IdInfo()
        {
            IdNumber = Guid.NewGuid();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
