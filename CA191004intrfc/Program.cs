using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191004intrfc
{
    class Program
    {
        static void Main(string[] args)
        {
            var saveList = new List<ISaveable>()
            {
                            new Cica() { Nev = "asdasasd" },
            new Cica() { Nev = "ghjvjh" },
            new Kocsog() { Szin = (ConsoleColor)3, Szarmazas = "Hubn" },
            new Cica() { Nev = "chzcdtrc" },
            new Kocsog() { Szin = (ConsoleColor)3, Szarmazas = "Mexiko" },
            new Cica() { Nev = "tzrtfrj" },
            new Kocsog() { Szin = (ConsoleColor)14, Szarmazas = "Japan" },
            new Cica() { Nev = "xcbvc n " }
            };

            foreach (var item in saveList)
            {
                item.SaveState();
            }



            //var list = new List<Allat>
            //{
            //    new Kutya(){ Nev = "Bodri" },
            //    new Cica() { Nev = "Lukrécica", Elet = 5 },
            //};

            //foreach (var a in list)
            //{
            //    if (a is Kutya) Console.WriteLine((a as Kutya).Ugat());
            //    if (a is Cica) Console.WriteLine((a as Cica).Nyavog());
            //}

            //object c1 = new Cica() { Nev = "egyik" };
            //Cica c2 = new Cica() { Nev = "masik" };
            //object a2 = 42;
            //object a3 = "bicikli";
            //object a4 = new int[10];

            //Console.WriteLine(c2.ToString());

            Console.ReadKey();
        }
    }
}
