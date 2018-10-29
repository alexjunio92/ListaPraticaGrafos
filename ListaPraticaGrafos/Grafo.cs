using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPraticaGrafos
{
    class Grafo
    {
        public List<int> Edges;
        public List<int> Vertices;

        public Grafo()
        {
            
        }
        public void InstanciaInicial() {
            
        }

        #region Grafo Não-Dirigido
        public bool isAdjacente(int v1, int v2) { return true; }
        public int getGrau() { return 0; }
        public bool isIsolado() { return true; }
        public bool isPendente() { return true; }
        public bool isRegular() { return true; }
        public bool isNulo() { return true; }
        public bool isConexo() { return true; }
        public bool isEuleriano() { return true; }
        public bool isUnicursal() { return true; }
        public Grafo getComplementar()
        {
            return new Grafo
            {
                Edges = new List<int>(),
                Vertices = new List<int>()
            };
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
            return new Grafo
            {
                Edges = new List<int>(),
                Vertices = new List<int>()
            };
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
            return new Grafo
            {
                Edges = new List<int>(),
                Vertices = new List<int>()
            };
        }
        #endregion

        #region Grafo Dirigido
        public int getGrauEntrada(int v1) { return 0; }
        public int getGrauSaída(int v1) { return 0; }
        public bool hasCiclo() { return true; }

        #endregion


    }
}
