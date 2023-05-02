using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace v_shooter_path
{
    internal class Entity
    {
        public Entity(int case_x, int case_y, Brush rectColor)
        {
            CaseX = case_x;
            CaseY = case_y;
            
            RectColor = rectColor;
        }

        public char Letter { get; set; }
        public int CaseX { get; set; }
        public int CaseY { get; set; }
        public Brush RectColor { get; set; } = Brushes.Black;
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

    }
}
