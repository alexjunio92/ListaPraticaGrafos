using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPraticaGrafos
{
    public class Grafo
    {
        public List<Aresta> arestas;
        public List<Vertice> vertices;
        public int numVertices;
        public bool tipo;

        public Grafo(bool tipo)
        {
            numVertices = 0;
            arestas = new List<Aresta>();
            vertices = new List<Vertice>();
            tipo = this.tipo;
        }

        #region Grafo Não-Dirigido
        public bool isAdjacente(int v1, int v2) {
            bool retorno = false;
            foreach (var adj in arestas)
            {
                if ((v1 == adj.v1.numero && v2 == adj.v2.numero) || (v2 == adj.v1.numero && v1 == adj.v2.numero))
                {
                    retorno = true;
                }
            }
            return retorno; 
        }
        public int getGrau(Vertice v1) {

            foreach (var adj in arestas)
            {
                if (v1.numero == adj.v1.numero || v1.numero == adj.v2.numero)
                {
                   v1.grau++;
                }               
            }        
            return v1.grau; 
         }
        public bool isIsolado(Vertice v1) 
        {
            if (getGrau(v1) ==0)
            {
                return true;
            }
            return false;
        }
        public bool isPendente(Vertice v1) 
        {
            if (getGrau(v1) == 1)
            {
                return true;
            }
            return false;
        }
        public bool isRegular() 
        {
            int anterior = -1;
            int proximo = 0;
            foreach (var adj in arestas)
            {
                if (anterior == -1)
                {
                    anterior = getGrau(adj.v1);
                }
                else
                {
                    proximo = getGrau(adj.v1);
                    if (anterior != proximo)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool isNulo() {

            foreach (var adj in arestas)
            {
                if (getGrau(adj.v1) != 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isEuleriano() {
            foreach (var adj in arestas)
            {
                if (getGrau(adj.v1)%2!=0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isConexo() 
        { 
            return true; 
        }
        public bool isUnicursal() { 
            return true; 
        }
        public Grafo getComplementar()
        {
            return new Grafo(true) { arestas = new List<Aresta>(), vertices = new List<Vertice>() };
        }

        public void buscaProfundiade(Vertice v) {
            
        }

        /// <summary>
        /// Esse método deve retornar, para um grafo conexo, sua Árvore Geradora Mínima obtida por meio da aplicação do algoritmo de Prim.
        /// Nesse método, deve também ser impressa uma linha de saída contendo a ordem em que o algoritmo de Prim inseriu na AGM os vértices
        /// do grafo original, sendo que o vértice inicial corresponde ao vértice passado como parâmetro. Além disso, se tivermos duas arestas
        /// com o mesmo peso, escolha aquela cuja soma dos índices dos vértices seja menor. Se tivermos um novo empate, escolha aquela incidente ao vértice de menor índice.
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public Grafo getAGMPrim(int v1)
        {
            return new Grafo(true) { arestas = new List<Aresta>(), vertices = new List<Vertice>() };
        }
        /// <summary>
        /// Esse método deve retornar, para um grafo conexo, sua
        /// Árvore Geradora Mínima obtida por meio da aplicação do algoritmo de Kruskal. Nesse
        /// método, deve também ser impressa uma linha de saída contendo a ordem em que o algoritmo
        /// de Kruskal inseriu na AGM os vértices do grafo original, sendo que o vértice inicial corresponde
        /// ao vértice passado como parâmetro. Além disso, se tivermos duas arestas com o mesmo peso,
        /// escolha aquela cuja soma dos índices dos vértices seja menor. Se tivermos um novo empate,
        /// escolha aquela incidente ao vértice de menor índice.
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public Grafo getAGMKruskal(int v1)
        {
            return new Grafo(true) { arestas = new List<Aresta>(), vertices = new List<Vertice>() };
        }
        #endregion

        #region Grafo Dirigido
        public int getGrauEntrada(int v1) 
        { 
            return 0; 
        }
        public int getGrauSaída(int v1) 
        { 
            return 0; 
        }
        public bool hasCiclo() 
        { 
            return true; 
        }
        #endregion


    }
}
