using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPraticaGrafos
{
    public class Vertice
    {
        public int grau;
        public int numero;

        public Vertice(int numero) {
            this.numero = numero;
            grau = 0;
        }
        
    }
}
