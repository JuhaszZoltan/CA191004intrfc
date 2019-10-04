using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191004intrfc
{
    class Allat
    {
        int x; int y;
        public string Nev { get; set; }
        public bool Sex { get; set; }
        public void Mozog(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
