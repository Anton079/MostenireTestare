using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Vml;
using MostenireTestare.InterfeteExemplu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.AbstarctizareExemplu
{
    public class Linie : IFigura
    {
        private Punct p1;
        private Punct p2;

        public Linie(Punct p1, Punct p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Punct P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Punct P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public void Afisare()
        {
            Console.WriteLine(this);
        }

        public void Translate(int p1T, int p2T)
        {
            p1.Translate(p2T, p1T);
            p2.Translate(p1T, p2T);
        }

        public IFigura Duplicare()
        {
            Linie LinieDuplicata = new Linie(p1, p2);

            return LinieDuplicata;
        }

        public override string ToString()
        {
            return $"{p1},{p2}";
        }

        public override bool Equals(object? obj)
        { 
            Linie linie = obj as Linie;
            return this.p1.Equals(linie.p1) && this.p2.Equals(linie.p2);
        }

    }
}
