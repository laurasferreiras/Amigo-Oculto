using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAmigoOculto.classes
{
    public class GerenciadorPessoas
    {
        public List<string> pessoas = new List<string>();
        public bool AdicionarPessoa(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome inválido");
                return false;
            }

            if (pessoas.Contains(nome, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nome já cadastrado");
                return false;
            }

            pessoas.Add(nome);
            Console.WriteLine($"Pessoa {nome} cadastrada com sucesso!");
            return true;

        }
        public List<string> ObterPessoas()
        {
            return new List<string>(pessoas);
        }

        public void ExibirPessoas()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
                return;
            }
            Console.WriteLine("Pessoas cadastradas:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"- {pessoa}");
            }


        }
    }
}

// testee
