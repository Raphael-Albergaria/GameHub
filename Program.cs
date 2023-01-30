using GameHub.Model;
using GameHub.Repository;
using GameHub.Jogos;
using System.Text.Json;

namespace GameHub;
class Program  
{
    static void Main(string[] args)
    {
    
        List<Jogador> jogadores = new List<Jogador>
        {
            new Jogador ("Raphael"),
            new Jogador ("Caroline"),
            new Jogador ("Gabriel"),
            new Jogador ("Michael"),
            new Jogador ("Tatiane"),
        };
        Console.WriteLine("seja bem vindo aqo GameHub!");
        Console.WriteLine("O que gostaria de fazer?");

        string option;
        do
        {
        option = Console.ReadLine();
            switch (option)
            {
                case "0":
                Console.WriteLine("Foi muito bom ter você conosco!");
                Console.WriteLine("Até breve!");
                Console.ReadKey();
                break;
                case "1":
                    CadastroDeJogador(jogadores);

                    break;
                case "2":
                //ver rank
                break;
                case "3":
                batalhaNaval.BatalhaNaval();
                //jogar
                break;
            }
        } while (option != "0");

    JogadorRepository repository = new JogadorRepository();
    Console.WriteLine(repository.SalvarTodos(jogadores) ? "Salvou" : "Erro ao salvar!");
    repository.LerTodos().ForEach(Console.WriteLine);
    }

    
    static void CadastroDeJogador(List<Jogador> jogadores)
    {
        Console.WriteLine("Olá seja bem vindo!");
        Console.WriteLine();
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();
        jogadores.Add(new Jogador(nome));
    }

}