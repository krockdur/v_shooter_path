using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace v_shooter_path
{
    public class TypeEntity
    {
        public TypeEntity(char letter, Brush color)
        {
            Letter = letter;
            Color = color;

            ListAttributes = new List<Attribute>();
        }
        public char Letter { get; set; }
        public Brush Color { get; set; }
        public List<Attribute> ListAttributes { get; set; }

    }
}
