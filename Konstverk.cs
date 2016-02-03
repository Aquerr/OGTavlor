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

        public static List<Konstverk> Artwork = new List<Konstverk>()
        {
            new Konstverk() {Id=1,Name="Uggla",Date="06-11-2014",Artist="Henrik",Room="A203",Material="Träd", Width=50, Height=200, Comment="Nothing Here... It's just an owl", ImagePath=@"images\bild1mini.JPG" },
            new Konstverk() {Id=2,Name="Uggla",Date="06-11-2014",Artist="nån",Room="A203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath=@"images\bild2mini.JPG" },
            new Konstverk() {Id=3,Name="Exempel",Date="24-05-1923",Artist="nån",Room="A203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath=@"images\bild3mini.JPG" },
            new Konstverk() {Id=4,Name="Exempel",Date="15-04-1999",Artist="nån",Room="A324",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath=@"images\bild4mini.JPG" },
            new Konstverk() {Id=5,Name="Exempel",Date="08-08-2003",Artist="nån",Room="B203",Material="Glas", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath=@"images\bild5mini.JPG" },
            new Konstverk() {Id=6,Name="Exempel",Date="03-02-2008",Artist="nån",Room="C103",Material="Träd", Width=50, Height=200, Comment="Nothing Here... It's just some penguins", ImagePath=@"images\bild6mini.JPG" },
        };
    }
}