using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListaPraticaGrafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo grafoNaoDirigido = GetGrafoNaoDirigido();
            Grafo grafoDirigido = GetGrafoDirigido();
            Console.ReadKey();
        }

        static Grafo GetGrafoNaoDirigido()
        {
            StringReader arquivo = new StringReader(Properties.Resources.GrafoNaoDirigido);
            //StreamReader arquivo = new StreamReader(@"C:\PastaQualquer\GrafoNaoDirigido.txt");
            string linha = arquivo.ReadLine();
            Grafo grafoNDirigido = new Grafo(true);
            grafoNDirigido.numVertices = int.Parse(linha);
            linha = arquivo.ReadLine();
            while (linha != null)
            {                
                var vetLinha = linha.Trim().Split(';');
                grafoNDirigido.Edges.Add(
                    new Aresta(
                        int.Parse(vetLinha[0]),
                        int.Parse(vetLinha[1]),
                        int.Parse(vetLinha[2])
                    )
                );
                linha = arquivo.ReadLine();
            }
            linha = arquivo.ReadLine(); linha = arquivo.ReadLine(); linha = arquivo.ReadLine(); linha = arquivo.ReadLine();
            return grafoNDirigido;
        }

        static Grafo GetGrafoDirigido() {
            StringReader arquivo = new StringReader(Properties.Resources.GrafoDirigido);
            //StreamReader arquivo = new StreamReader(@"C:\PastaQualquer\GrafoDirigido.txt");
            string linha = arquivo.ReadLine();
            Grafo grafoDirigido = new Grafo(false);
            grafoDirigido.numVertices = int.Parse(linha);
            linha = arquivo.ReadLine();
            while (linha != null)
            {
                var vetLinha = linha.Trim().Split(';');
                if (int.Parse(vetLinha[3])<0)
                {
                    var aux = vetLinha[0];
                    vetLinha[0] = vetLinha[1];
                    vetLinha[1] = aux;
                }
                grafoDirigido.Edges.Add(
                    new Aresta(
                        int.Parse(vetLinha[0]),
                        int.Parse(vetLinha[1]),
                        int.Parse(vetLinha[2])
                    )
                );
                linha = arquivo.ReadLine();
            }
            linha = arquivo.ReadLine(); linha = arquivo.ReadLine(); linha = arquivo.ReadLine(); linha = arquivo.ReadLine();
            return grafoDirigido;
        }


    }
}
