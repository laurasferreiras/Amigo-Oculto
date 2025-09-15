using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAmigoOculto.classes
{
    public class GerenciadorSorteio
    {
        private Dictionary<string, string> duplasSorteadas = new Dictionary<string, string>();
        private Random random = new Random();
        public bool SorteioRealizado { get; private set; } = false;

        public void RealizandoSorteio(List<string> pessoas)
        {
            if (SorteioRealizado)
            {
                Console.WriteLine("Sorteio já foi realizado anteriormente.");
                return;
            }

            if (pessoas == null || pessoas.Count <= 1)
            {
                Console.WriteLine("É necessário ao menos 2 pessoas para realizar o sorteio");
                return;
            }

            Console.WriteLine("Realizando sorteio...");
      
            var pessoasDisponiveis = new List<string>(pessoas); //lista com as pessoas cadastradas
            var resultadoTemporario = new Dictionary<string, string>(); //dicionario vazio
            bool sucesso = false;
            int tentativas = 0;
            const int maxTentativas = 1000;

            while (!sucesso && tentativas < maxTentativas)
            {
                tentativas++;
                resultadoTemporario.Clear();
                var sorteados = pessoasDisponiveis.OrderBy(x => random.Next()).ToList();
                sucesso = true;

                for (int i = 0; i < pessoasDisponiveis.Count; i++)
                {
                    string pessoa = pessoasDisponiveis[i];
                    string amigoOculto = sorteados[i];

                    if (pessoa == amigoOculto || (resultadoTemporario.ContainsKey(amigoOculto) && resultadoTemporario[amigoOculto]==pessoa))
                    {
                        sucesso = false;
                        break;
                    }

                    resultadoTemporario[pessoa] = amigoOculto;

                }
            }
            if (!sucesso)
            {
                Console.WriteLine("Não foi possível realizar o sorteio.");
                return;
            }

            duplasSorteadas = resultadoTemporario;
            SorteioRealizado = true;
            Console.WriteLine("Sorteio realizado com sucesso!");

        }

        public string ObterAmigoSorteado(string pessoa)
        {
            if (!SorteioRealizado)
            {
                return "Sorteio não realizado";
            }

            if (duplasSorteadas.ContainsKey(pessoa))
            {
                return duplasSorteadas[pessoa];
            }

            return "Pessoa não encontrada no sorteio";
        }

        public void ExibirResultado()
        {
            if (!SorteioRealizado)
            {
                Console.WriteLine("Sorteio não realizado"); 
                return;
            }

            foreach (var dupla in duplasSorteadas)
            {
                Console.WriteLine($"{dupla.Key} -->{dupla.Value}");
            }

        }
        public void ReiniciarSorteio()
        {
            duplasSorteadas.Clear();
            SorteioRealizado = false;
            Console.WriteLine("Sorteio reiniciado. Você pode realizar um novo sorteio.");
        }

    }
}

// oi tesste