using MostenireTestare.InterfeteExemplu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.AbstarctizareExemplu
{
    public class Cerc : IFigura
    {
        private Punct centru;
        private int raza;

        public Cerc(Punct centru, int raza)
        {
            this.centru = centru;
            this.raza = raza;
        }

        public Punct Centru
        {
            get { return centru; }
            set { centru = value; }
        }

        public int Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public void Afisare()
        {
            Console.WriteLine(this);
        }

        public void Translate(int tx, int ty)
        {
            centru.Translate(tx, ty);
        }

        public IFigura Duplicare()
        {
            Cerc CercDuplicata = new Cerc(new Punct(centru.X , centru.Y), raza);

            return CercDuplicata;
        }

        public override string ToString()
        {
            return $"{centru},{raza}";
        }

        public override bool Equals(object? obj)
        {
            Cerc cerc = obj as Cerc;
            return this.centru.Equals(cerc.centru) && this.raza == cerc.raza;
        }
    }
}
