using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGTavlor
{
    class Konstverk
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string Datum { get; set; }
        public string Konstnär { get; set; }
        public string Rum { get; set; }
        public string Material { get; set; }
        public int Bredd { get; set; }
        public int Höjd { get; set; }
        public string Kommentar { get; set; }
        public string ImagePath { get; set; }
    }
}
