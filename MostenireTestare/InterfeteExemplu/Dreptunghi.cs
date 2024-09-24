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

        public void Translatare(int tx, int ty)
        {
            coltStangaJos.Translate(tx, ty);
            coltDreaptaSus.Translate(tx, ty);
        }

     

    }
}
