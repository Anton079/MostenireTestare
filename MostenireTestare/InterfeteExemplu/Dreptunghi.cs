using DocumentFormat.OpenXml.Vml.Office;
using MostenireTestare.AbstarctizareExemplu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.InterfeteExemplu
{
    public class Dreptunghi:IFigura
    {
        private Punct coltStangaJos;
        private Punct coltDreaptaSus;

        public Dreptunghi(Punct coltStangaJos, Punct coltDreaptaSus)
        {
            this.coltStangaJos = coltStangaJos;
            this.coltDreaptaSus = coltDreaptaSus;
        }

        public void Afisare()
        {
            Console.WriteLine(this);
        }

        public Punct ColtStangaJos
        {
            get { return coltStangaJos; }
            set { coltStangaJos = value;}
        }

        public Punct ColtDreaptaSus
        {
            get { return coltDreaptaSus; }
            set { coltDreaptaSus = value; }
        }

        public void Translate(int tx, int ty)
        {
            coltStangaJos.Translate(tx, ty);
            coltDreaptaSus.Translate(tx, ty);
        }

        public IFigura Duplicare()
        {
            Dreptunghi dreptunghi = new Dreptunghi(coltStangaJos, coltDreaptaSus);

            return dreptunghi;
        }

        public override string ToString()
        {
            return $"{coltStangaJos},{coltDreaptaSus}";
        }

        public override bool Equals(object? obj)
        {
            Dreptunghi dreptunghi = obj as Dreptunghi;
            return this.coltStangaJos.Equals(dreptunghi.coltStangaJos) && this.coltDreaptaSus.Equals(dreptunghi.coltDreaptaSus);
        }
    }
}
