using GameHub.Model;
using GameHub.Repository;
using GameHub.Jogos;
using System.Text.Json;

namespace GameHub;
class Program  
{
    static void MenuDeJogos()
    {
        Console.Clear();
        Console.WriteLine("Que jogo Gostaria de jogar?");
        Console.WriteLine();
        Console.WriteLine("[1] - Jogo da Velha");
        Console.WriteLine("[2] - Batalha naval");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                jogoDaVelha.JogoDaVelha();
                break;
            case "2":
                batalhaNaval.BatalhaNaval();
                break;
            default:
                break;
        }

    }
    public static string ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Esse é o Menu principal do GameHub");
        Console.WriteLine();
        Console.WriteLine("O que gostaria de fazer?");
        Console.WriteLine();
        Console.WriteLine("[1] - Cadastrar novo Jogador");
        Console.WriteLine("[2] - Jogar");
        Console.WriteLine("[3] - Ver ranking");
        Console.WriteLine("[0] - Para sair do Hub");
        Console.WriteLine();
        Console.Write("Digite a opção desejada: ");

        option = Console.ReadLine();

        switch (option)
        {
            case "0":
                Console.Clear();
                Console.WriteLine("Foi muito bom ter você conosco!");
                Console.WriteLine("Até breve!");
                Console.ReadKey();
                break;
            case "1":
                CadastroDeJogador(jogadores);

                break;
            case "2":
                MenuDeJogos();
                break;
            case "3":
                MostrarRanking();
                break;
        }

        return option;
    }

    private static void MostrarRanking()
    {
        Console.Clear();
        List<Jogador> rankingJogadores = jogadores.OrderByDescending(d => d.Pontuacao).ToList();
        jogadores.OrderByDescending(d => d.Pontuacao);

        foreach (var item in rankingJogadores)
        {
            Console.WriteLine(item.ToString());
        }
            Console.ReadKey();

    }

    public static List<Jogador> jogadores;
    static string option;
    public static void Main(string[] args)
    {
        JogadorRepository repository = new JogadorRepository();
        jogadores = new List<Jogador>(repository.LerTodos());

        
        Console.WriteLine("Bem Vindo(a) ao Hub de Games");
        Console.WriteLine();
        Console.WriteLine("Aperte Enter para iniciar");
        Console.ReadKey();

        do
        {
        option = ShowMenu();
        
        } while (option != "0");

    Console.WriteLine(repository.SalvarTodos(jogadores) ? "Salvou" : "Erro ao salvar!");
        // repository.LerTodos().ForEach(Console.WriteLine);
    }

    static string SelecionarJogador()
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digte o nome do jogador: ");
        string nomeJogador = Console.ReadLine().ToUpper();
        if (jogadores.Exists(x => x.Nome == nomeJogador))
        {
            Console.WriteLine("Jogador logado!");
        }
        else
        {
            Console.WriteLine("Jogador não encontrado");
        }
        return nomeJogador;
    }

    public static string CadastroDeJogador(List<Jogador> jogadores)
    {
        Console.Clear();
        Console.WriteLine("Olá seja bem vindo!");
        Console.WriteLine();
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine().ToUpper();
        if (jogadores.Exists(x => x.Nome == nome))
        {
            Console.Clear();
            Console.WriteLine("Nome de Jogador já cadastrado");
            Console.WriteLine();
            Console.WriteLine("Gostatia de ...");
            Console.WriteLine("[1] - Cadastrar novo jogador");
            Console.WriteLine("[2] - Digitar novamente seu nome");
            Console.WriteLine("[3] - Voltar ao menu anterior");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    nome = Program.CadastroDeJogador(Program.jogadores);
                    break;
                case "2":
                    nome = SelecionarJogador();
                    break;
                case "3":
                    ShowMenu();
                    break;
                default:
                    break;
            }
            return nome;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Seja bem vindo {nome}!");
            Console.WriteLine("Que comecem os Jogos!");
            Console.ReadKey();
            jogadores.Add(new Jogador(nome));
            return nome;

        }

    }
}

