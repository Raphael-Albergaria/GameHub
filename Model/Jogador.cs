namespace GameHub.Model;

public class Jogador
{
    public string Nome { get; set; } = null!;
    public int Pontuacao { get; set; } = 0;
    public bool Jogando { get; set; } = false;

    public override string ToString()
    {
        return $"{Pontuacao} pts. | Nome: {Nome}";
    }

    public Jogador(string nome)
    {
        Nome = nome;
    }
}