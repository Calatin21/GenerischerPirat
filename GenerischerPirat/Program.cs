namespace GenerischerPirat {
    internal class Program {
        static void Main(string[] args) {
            Faß<Alkohol> pott = new Faß<Alkohol>();
            Pirat<Alkohol> hook = new Pirat<Alkohol>();
            Rum rum1 = new Rum() { Name = "Captain Morgan", Plantage = "Falmouth", Information = "Alkoholgehalt 35%" };
            Rum rum2 = new Rum() { Name = "Weißer Rum", Plantage = "St. Kitts", Information = "Alkoholgehalt 42%" };
            Rum rum3 = new Rum() { Name = "Brauner Rum", Plantage = "St. Nevis", Information = "Alkoholgehalt 33%" };

            Scumm scumm1 = new Scumm() { Name = "Monkey Island", Information = "Selbstgebrauter Alkohol mit 75% Alkohol" };
            scumm1.Inhalt.Add(rum2);
            scumm1.Inhalt.Add(rum3);

            hook.AddFlasche(rum1);
            hook.AddFlasche(rum2);
            hook.AddFlasche(scumm1);
            hook.Fuellen();
            Console.WriteLine(hook.Leeren(pott));
            hook.Fuellen();
            Console.WriteLine(hook.Leeren(pott));
            hook.Fuellen();
            Console.WriteLine(hook.Leeren(pott));
        }
    }
}