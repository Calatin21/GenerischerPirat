﻿namespace GenerischerPirat {
    internal class Program {
        static void Main(string[] args) {
            Faß<Alkohol> pott = new Faß<Alkohol>();
            Pirat<Alkohol> hook = new Pirat<Alkohol>();
            Flasche<Rum> flascheRum1 = new Flasche<Rum>() { InhaltFluessig = new Rum() { Name = "Captain Morgan", Plantage = "Falmouth", Information = "Alkoholgehalt 35%" } };
            Flasche<Rum> flascheRum2 = new Flasche<Rum>() { InhaltFluessig = new Rum() { Name = "Weißer Rum", Plantage = "St. Kitts", Information = "Alkoholgehalt 42%" } };
            Flasche<Rum> flascheRum3 = new Flasche<Rum>() { InhaltFluessig = new Rum() { Name = "Brauner Rum", Plantage = "St. Nevis", Information = "Alkoholgehalt 33%" } };

            Flasche<Scumm> flascheScumm1 = new Flasche<Scumm>() { InhaltFluessig = new Scumm() { Name = "Monkey Island", Information = "Selbstgebrauter Alkohol mit 75% Alkohol" } };
            flascheScumm1.InhaltFluessig.Inhalt.Add(flascheRum2.InhaltFluessig);
            flascheScumm1.InhaltFluessig.Inhalt.Add(flascheRum3.InhaltFluessig);

            hook.AmMann.Add(flascheRum1);
            hook.AmMann.Add(flascheRum2);
            hook.AmMann.Add(flascheScumm1);
        }
    }
}