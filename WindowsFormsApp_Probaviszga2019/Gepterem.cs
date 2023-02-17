using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Probaviszga2019
{
    internal class Gepterem
    {
        readonly int[,] ertekeles;
        readonly int helyDb;
        readonly string nev;
        readonly int sorDb;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }

        public int[,] Ertekeles => ertekeles;

        public int HelyDb => helyDb;

        public string Nev => nev;

        public int SorDb => sorDb;
    }
}
