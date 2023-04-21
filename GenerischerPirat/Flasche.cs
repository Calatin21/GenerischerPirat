namespace GenerischerPirat {
    internal class Flasche<T> where T : IAlkohol {
        public T InhaltFluessig {
            get; set;
        }
    }
}
