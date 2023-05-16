using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace v_shooter_path
{
    public class Entity
    {
        public char Letter { get; set; }
        public int CaseX { get; set; }
        public int CaseY { get; set; }

        public List<Attribute> ListAttributes { get; set; } = new List<Attribute>();
    }
}
