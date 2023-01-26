namespace GameHub.Model;

public class Jogador
{
    public string Nome { get; set; } = null!;
    public int Pontuacao { get; set; } = 0;

    public override string ToString()
    {
        return $"Nome: {Nome} | Pontuação: {Pontuacao}";
    }
}