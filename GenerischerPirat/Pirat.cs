namespace GenerischerPirat {
    internal class Pirat<T> where T : IAlkohol {
        private T Magen {
            get; set;
        }
        private List<Flasche<T>> flaschen { get; set; } = new List<Flasche<T>>();
        public void AddFlasche(Flasche<T> flasche) {
            flaschen.Add(flasche);
        }
        public bool IstLeer() {
            return flaschen.Count == 0;
        }
        public void Fuellen() {
            Magen = flaschen.First().InhaltFluessig;
            flaschen.RemoveAt(0);
        }
        public String Leeren(Faß<T> faß) {
            String ergebnis = Magen.Name;
            faß.Inhalt.Push(Magen);
            Magen = default(T);
            return ergebnis;
        }
    }
}
