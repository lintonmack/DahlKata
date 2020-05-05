using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Models
{
    public class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }
    }
}
