using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_shooter_path
{
    internal class Attribute
    {
        public Attribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;

    }
}
