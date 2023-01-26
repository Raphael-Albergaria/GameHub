using GameHub.Model;
using GameHub.Repository    ;
using System.Text.Json;

namespace GameHub;
class Program
{
    static void Main(string[] args)
    {
    List<Jogador> jogadores = new List<Jogador>
    {
        new Jogador {Nome = "Raphael"},
        new Jogador {Nome = "Caroline"},
        new Jogador {Nome = "Gabriel"},
        new Jogador {Nome = "Michael"},
        new Jogador {Nome = "Tatiane"},
    };

    JogadorRepository repository = new JogadorRepository();
    Console.WriteLine(repository.SalvarTodos(jogadores) ? "Salvou" : "Erro ao salvar!");
    repository.LerTodos().ForEach(Console.WriteLine);
    }
}
