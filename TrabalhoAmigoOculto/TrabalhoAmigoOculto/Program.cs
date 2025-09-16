using System; 
using System.Collections.Generic; 
using System.Linq; 
using TrabalhoAmigoOculto.classes;
using System.Threading;
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
                    Console.WriteLine("Digite seu nome: ");
                    string consultaNome = Console.ReadLine();
                    Console.WriteLine("Seu amigo oculto é:");
                    Thread.Sleep(1000);
                    Console.WriteLine("3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("1...");
                    Thread.Sleep(1000);
                    Console.WriteLine(gerenciadorSorteio.ObterAmigoSorteado(consultaNome));
                    break;
                case "6":
                    gerenciadorSorteio.ReiniciarSorteio();
                    break;
                case "7":
                    Console.WriteLine("Obrigado!");
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
            
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n ----- MENU ----- ");
            
            if (!gerenciadorSorteio.SorteioRealizado)
            {
                Console.WriteLine("1. Adicionar pessoas");
                Console.WriteLine("2. Exibir pessoas cadastradas");
                Console.WriteLine("3. Realizar sorteio");
            }
            else
            {
                Console.WriteLine("4. Ver pares sorteados");
                Console.WriteLine("5. Consultar seu amigo oculto");
                Console.WriteLine("6. Reiniciar sorteio");
            }
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: \n");

        }
    }
}

