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

            Console.WriteLine(
            @"Pontifícia Universidade Católica
            Sistemas de Informação - Algoritmos em Grafos
            Alex Junio Rodrigues & Vitor Dias Calabria");


            Grafo grafoNaoDirigido = GetGrafoNaoDirigido();
            Grafo grafoDirigido = GetGrafoDirigido();


            var x = grafoNaoDirigido.getGrau(new Vertice(1));
            var y = grafoNaoDirigido.isIsolado(new Vertice(1));

            Console.ReadKey();
        }

        static Grafo GetGrafoNaoDirigido()
        {
            StringReader arquivo = new StringReader(Properties.Resources.GrafoNaoDirigido);
            //Comentar a linha de cima e descomentar a de baixo com o arquivo desejado
            //StreamReader arquivo = new StreamReader(@"C:\PastaQualquer\GrafoNaoDirigido.txt");
            string linha = arquivo.ReadLine();
            Grafo grafoNDirigido = new Grafo(true);
            grafoNDirigido.numVertices = int.Parse(linha);
            linha = arquivo.ReadLine();
            while (linha != null)
            {                
                var vetLinha = linha.Trim().Split(';');
                grafoNDirigido.arestas.Add(
                    new Aresta(
                        new Vertice(int.Parse(vetLinha[0])),
                        new Vertice(int.Parse(vetLinha[1])),
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
            //Comentar a linha de cima e descomentar a de baixo com o arquivo desejado
            //StreamReader arquivo = new StreamReader(@"C:\PastaQualquer\GrafoDirigido.txt");
            string linha = arquivo.ReadLine();
            Grafo grafoDirigido = new Grafo(false);
            grafoDirigido.numVertices = int.Parse(linha);
            linha = arquivo.ReadLine();
            while (linha != null)
            {
                var vetLinha = linha.Trim().Split(';');
                //No caso do grafo direcionado o v1, sempre estará apontando para o v2 num sentido único
                if (int.Parse(vetLinha[3])<0)
                {
                    var aux = vetLinha[0];
                    vetLinha[0] = vetLinha[1];
                    vetLinha[1] = aux;
                }
                grafoDirigido.arestas.Add(
                    new Aresta(
                        new Vertice(int.Parse(vetLinha[0])),
                        new Vertice(int.Parse(vetLinha[1])),
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
