using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGTavlor
{
    public class Konstverk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Artist { get; set; }
        public string Room { get; set; }
        public string Material { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Comment { get; set; }
        public string ImagePath { get; set; }
    }
}