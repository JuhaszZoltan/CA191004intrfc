using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191004intrfc
{
    class Cica : Allat, ISaveable
    {
        public int Elet { get; set; } = 9;
        public string Nyavog() => "meow - meow";
        public new string ToString()
        {
            return Nev;
        }

        public void SaveState()
        {
            var sw = new StreamWriter(
                DateTime.Now.ToShortDateString() + ".txt",
                true, Encoding.UTF8);

            sw.WriteLine("-------");
            sw.WriteLine("Cica");
            sw.WriteLine($"NEV={Nev}");
            sw.WriteLine($"ELET={Elet}");
            sw.Close();
        }
    }
}
