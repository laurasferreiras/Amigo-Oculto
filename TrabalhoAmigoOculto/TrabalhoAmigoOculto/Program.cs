using System; //importa tudo necessário para o programa rodar
using System.Collections.Generic; //importa as listas, dicionários
using System.Linq; //consulta em coleções de dados (listas, dict)
using TrabalhoAmigoOculto.classes;

class Programa
{
    static GerenciadorPessoas gerenciadorPessoas = new GerenciadorPessoas();
    static GerenciadorSorteio gerenciadorSorteio = new GerenciadorSorteio();
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    while (true)
                    {
                        Console.WriteLine("Digite o nome das pessoas, ou 0 para concluir: ");
                        string nome = Console.ReadLine();
                        gerenciadorPessoas.AdicionarPessoa(nome);
                        if (nome == "0")
                            break;
                    }
                    break;
                case "2":
                    gerenciadorPessoas.ExibirPessoas();
                    break;
                case "3":                
                    gerenciadorSorteio.RealizandoSorteio(gerenciadorPessoas.ObterPessoas());
                    break;
                case "4":
                    gerenciadorSorteio.ExibirResultado();
                    break;
                case "5":
                    gerenciadorSorteio.ReiniciarSorteio();
                    break;
                case "6":
                    Console.WriteLine("Obrigado!");
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
            

        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n ---- MENU ---- ");
            Console.WriteLine("1. Adicionar pessoas");
            if (!gerenciadorSorteio.SorteioRealizado)
            {
                Console.WriteLine("2. Exibir pessoas cadastradas");
                Console.WriteLine("3. Realizar sorteio");
            }
            else
            {
                Console.WriteLine("4. Ver pares sorteados");
                Console.WriteLine("5. Reiniciar sorteio");
            }
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: \n");

        }
    }
}

