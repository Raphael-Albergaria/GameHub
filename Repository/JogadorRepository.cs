using System.Text.Json;
using GameHub.Model;

namespace GameHub.Repository;

class JogadorRepository
{ 
    private readonly string arquivoJson = "../../../jogadores.json";


    public List<Jogador> LerTodos()
    {
        var options = new JsonSerializerOptions {WriteIndented = true};
        string jsonLines = File.ReadAllText(arquivoJson);
        List<Jogador> jogadores = new List<Jogador>();
        List<Jogador>? leitura = JsonSerializer.Deserialize<List<Jogador>>(jsonLines, options);
        if(leitura != null) jogadores.AddRange(leitura);
        return jogadores;
    }

    public bool SalvarTodos(List<Jogador> jogadores){
        var options = new JsonSerializerOptions {WriteIndented = true};
        string jogadorJson = JsonSerializer.Serialize(jogadores , options);
        File.WriteAllText(arquivoJson, jogadorJson);
        return true;
    }
    //public List<Jogador> ListarTodos() {
    //
    // }
}