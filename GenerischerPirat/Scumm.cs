namespace GenerischerPirat {
    internal class Scumm : Alkohol {
        public List<Rum> Inhalt {
            get; set;
        } = new List<Rum> ();
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
