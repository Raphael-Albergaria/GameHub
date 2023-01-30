using System;
using GameHub.Model;
using GameHub.Repository;

namespace GameHub
{
    public class Jogo
    {
        public static string SelecionarJogador()
        {
            Console.WriteLine();
            Console.Write("Qual o Nome do Jogador?");
            string nomeJogador = Console.ReadLine().ToUpper();
            if (Program.jogadores.Exists(x => x.Nome == nomeJogador && x.Jogando != true))
            {
                Console.WriteLine("Jogador logado!");
                Jogador EntrarEmJogo = Program.jogadores.Find(delegate (Jogador j)
                {
                    return j.Nome == nomeJogador;
                }); EntrarEmJogo.Jogando = true;
                return nomeJogador;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Jogador não encontrado ou já selecionado");
                Console.WriteLine();
                Console.WriteLine("Gostaia de ...");
                Console.WriteLine("[1] - Cadastrar novo jogador");
                Console.WriteLine("[2] - Digitar novamente seu nome");
                Console.WriteLine("[3] - Voltar ao Menu anterior");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        nomeJogador = Program.CadastroDeJogador(Program.jogadores);
                        break;
                    case "2":
                        nomeJogador = SelecionarJogador();
                        break;
                    case "3":
                        Program.ShowMenu();
                        break;
                    default:
                        break;
                }
                return null;
            }
        }
        public static void DeslogarJogador(string jogador1, string jogador2)
        {
            Jogador Deslogar1 = Program.jogadores.Find(delegate (Jogador j)
            {
                return j.Nome == jogador1;
            }); Deslogar1.Jogando = false;
            
            Jogador Deslogar2 = Program.jogadores.Find(delegate (Jogador j)
            {
                return j.Nome == jogador2;
            }); Deslogar2.Jogando = false;
            
        }
        public static void AtualizarJogo()
        {
            JogadorRepository repository = new JogadorRepository();
            Console.WriteLine(repository.SalvarTodos(Program.jogadores) ? "Salvou" : "Erro ao salvar!");
            Program.jogadores = new List<Jogador>(repository.LerTodos());
        }
    }
}

