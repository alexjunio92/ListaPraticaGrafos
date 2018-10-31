using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPraticaGrafos
{

    public class Aresta
    {
        public Vertice v1;
        public Vertice v2;
        public int  peso;

        public Aresta(Vertice v1, Vertice v2, int peso)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.peso = peso;
        }
    }
}
