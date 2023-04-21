namespace GenerischerPirat {
    internal class Scumm : IAlkohol {
        public string Name {
            get; set;
        }
        public string Information {
            get; set;
        }
        public List<Rum> Inhalt {
            get; set;
        }
        public void Herkuenfte() {
            foreach (Rum item in Inhalt) {
                Console.WriteLine(item.Plantage);
            }
        }
        public void Informationen() {
            foreach (Rum item in Inhalt) {
                Console.WriteLine(item.Information);
            }
        }
    }
}
