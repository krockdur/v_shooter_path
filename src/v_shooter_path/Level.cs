using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_shooter_path
{
    public class Level
    {
        public List<Entity>? ListEntities { get; set; }

        public int NbEntitiesInX { get; set; }
        public int NbEntitiesInY { get; set; }
        public string Filename { get; set; }
    }
}
