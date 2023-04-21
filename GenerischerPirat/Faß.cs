namespace GenerischerPirat {
    internal class Faß<T> where T : IAlkohol {
        public Stack<T> Inhalt {
            get; set;
        } = new Stack<T>(); 
    }
}
