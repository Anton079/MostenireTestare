using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.InterfeteExemplu
{
    public class Punct : IFigura
    {
        private int _x;
        private int _y;

        public Punct(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void Afisare()
        {
            Console.WriteLine(this);
        }

        public void Translate(int tx, int ty)
        {
            X += tx;
            Y += ty;
        }

        public IFigura Duplicare()
        {
            Punct PunctDuplicat = new Punct(X, Y);

            return PunctDuplicat;
        }


        public override string ToString()
        {
            return $"{X} {Y}";
        }

        public override bool Equals(object? obj)
        {
            Punct punct = obj as Punct;
            return this._x==punct.X && this._y==punct.Y;

        }
    }
}
