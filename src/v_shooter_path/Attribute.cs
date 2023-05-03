using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_shooter_path
{
    class Attribute
    {
        public Attribute()
        {
            Name = string.Empty;
            Value = string.Empty;
        }
        public Attribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; set; }
        public string Value { get; set; }

    }
}
