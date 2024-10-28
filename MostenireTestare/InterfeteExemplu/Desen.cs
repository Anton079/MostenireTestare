using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.InterfeteExemplu
{
    public class Desen:IFigura
    {
        private List<IFigura> figuri;

        public Desen()
        {
            figuri = new List<IFigura>();
        }

        public void AdaugaFiguri(IFigura figura)
        {
            figuri.Add(figura);
        }

        public void StergeFigura(IFigura figura)
        {
            figuri.Remove(figura);
        }

        public void Afisare()
        {
            foreach(IFigura x in figuri)
            {
                x.Afisare();
            }
        }

        public void Translate(int dx, int dy)
        {
            foreach(IFigura x in figuri)
            {
                x.Translate(dx, dy);
            }
        }

        public IFigura Duplicare()
        {
            Desen desen = new Desen();

            foreach(IFigura x in figuri)
            {
                x.Duplicare();
            }

            return desen;
        }

    }
}
