using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191004intrfc
{
    class Kocsog : ISaveable
    {
        public ConsoleColor Szin { get; set; }
        public string Szarmazas { get; set; }

        public void SaveState()
        {
            var sw = new StreamWriter(
                DateTime.Now.ToShortDateString() + ".txt",
                true, Encoding.UTF8);

            sw.WriteLine("------");
            sw.WriteLine("KÖCSÖG");
            sw.WriteLine($"SZIN={this.Szin}");
            sw.WriteLine($"ORSZ={Szarmazas}");
            sw.Close();

        }
    }
}
