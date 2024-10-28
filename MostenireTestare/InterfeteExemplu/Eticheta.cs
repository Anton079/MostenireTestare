using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.InterfeteExemplu
{
    public class Eticheta : Dreptunghi
    {

        private string eticheta;

        public Eticheta(Punct coltStangaJos, Punct coltDreaptaSus, string eticheta) : base(coltStangaJos, coltDreaptaSus)
        {
            this.eticheta = eticheta;
        }

        public void Afisare()
        {
            Console.WriteLine(this);
        }

        public void Translate(int tx, int ty)
        {
            base.Translate(tx, ty);
        }

        public IFigura Duplicare()
        {
            Eticheta eticheta = new Eticheta(base.ColtStangaJos, base.ColtDreaptaSus, this.eticheta);

            return eticheta;
        }

        public string ToString()
        {
            return $"{base.ColtStangaJos}{eticheta}{base.ColtDreaptaSus}";
        }

        public override bool Equals(object? obj)
        {
            Eticheta eticheta = obj as Eticheta;

            return this.Equals(eticheta);
        }

    }
}
