using System;

namespace ConsoleApp1.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public Guid Uid { get; set; }
    }
}
