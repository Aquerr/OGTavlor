using System.Collections.Generic;

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

        List<Konstverk> Artwork = new List<Konstverk>()
        {
            new Konstverk() {Id=1,Name="Tre Pingviner",Date="06-11-2014",Artist="nån",Room="A203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath="logo.png" },
            new Konstverk() {Id=2,Name="Da",Date="06-11-2014",Artist="nån",Room="A203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath="logo.png" },
            new Konstverk() {Id=3,Name="Tre Pingviner",Date="24-05-1923",Artist="nån",Room="A203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath="logo.png" },
            new Konstverk() {Id=4,Name="Tre Pingviner",Date="15-04-1999",Artist="nån",Room="A324",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath="logo.png" },
            new Konstverk() {Id=5,Name="Tre Pingviner",Date="08-08-2003",Artist="nån",Room="B203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath="logo.png" },
            new Konstverk() {Id=6,Name="Tre Pingviner",Date="03-02-2008",Artist="nån",Room="C103",Material="Träd", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath="logo.png" },
        };
    }
}