namespace GenerischerPirat {
    internal class Pirat<T> where T : Alkohol {
        T Magen;
        List<T> flaschen = new List<T>();
        public void AddFlasche(T flasche) {
            flaschen.Add(flasche);
        }
        public bool IstLeer() {
            return flaschen.Count > 0;
        }
        public void Fuellen() {
            Magen = flaschen.First();
            flaschen.RemoveAt(0);
        }
        public String Leeren(Faß<T> faß) {
            String ergebnis = Magen.Name;
            faß.Inhalt.Push(Magen);
            Magen = null;
            return ergebnis;
        }
    }
}
