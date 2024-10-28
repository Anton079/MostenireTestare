using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.InterfeteExemplu
{
    public interface IFigura
    {

        void Afisare();

        void Translate(int p1T, int p2T);

        IFigura Duplicare();
        
    }
}
