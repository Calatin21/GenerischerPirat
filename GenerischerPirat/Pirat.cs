namespace GenerischerPirat {
    internal class Pirat<T> where T : Alkohol {
        public T Magen {
            get; set;
        }
        public List<Flasche<T>> AmMann {
            get; set;
        } = new List<Flasche<T>>();
        public bool IstLeer() {
            return AmMann.Count > 0;
        }
        public void Fuellen() {
            Magen = AmMann.First().InhaltFluessig;
           AmMann.RemoveAt(0);

        }
        public String Leeren(Faß<T> faß) {
            String ergebnis = Magen.Name;
            faß.Inhalt.Push(Magen);
            Magen = null;
            return ergebnis;
        }
    }
}
