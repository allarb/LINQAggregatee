using System;
using System.Collections.Generic;

namespace LINQAggregate
{
    public class AutoList
    {
        public static readonly List<Auto> auto = new List<Auto>
        {
            new Auto { Id = 1, Name = "Ford", Age = 14, GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e") },
            new Auto { Id = 2, Name = "KIA", Age = 9, GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7") },
            new Auto { Id = 3, Name = "Porche", Age = 5, GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e") },
            new Auto { Id = 4, Name = "Toyota", Age = 12, GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7") },
            new Auto { Id = 5, Name = "Subaru", Age = 8, GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7") }
        };
    }
}
