using GameHub.Model;
using GameHub.Repository;

namespace GameHub.Jogos
{
    public class jogoDaVelha
    {
        //static string vencedor;
        //static string perdedordor;
        static string player1;
        static string player2;
        static string[,] arr;
        static int turn = 1; 
        static int l;
        static int c;
        static int controle = 0;
        public static void JogoDaVelha()
        {
            arr = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            Console.Clear();
            Console.WriteLine();
            Console.Write("Selecione o 1° jogador: ");
            player1 = Jogo.SelecionarJogador();
            Console.Clear();
            Console.Write("Selecione o 2° jogador: ");
            player2 = Jogo.SelecionarJogador();
            do
            {
                Console.Clear();
                Console.WriteLine("{0}:X e {1}:O", player1 , player2);
                Board();
                turn++;
                if (turn % 2 == 0)
                {
                    Console.WriteLine("{0} em qual posição gostaria de jogar!", player2);
                }
                else
                {
                    Console.WriteLine("{0} em qual posição gostaria de jogar!", player1);
                }
                
                int jogada = int.Parse(Console.ReadLine());
                switch (jogada)
                {
                    case 1:
                        l= 0;
                        c= 0;
                        break;
                    case 2:
                        l = 0;
                        c = 1;
                        break;
                    case 3:
                        l = 0;
                        c = 2;
                        break;
                    case 4:
                        l = 1;
                        c = 0;
                        break;
                    case 5:
                        l = 1;
                        c = 1;
                        break;
                    case 6:
                        l = 1;
                        c = 2;
                        break;
                    case 7:
                        l = 2;
                        c = 0;
                        break;
                    case 8:
                        l = 2;
                        c = 1;
                        break;
                    case 9:
                        l = 2;
                        c = 2;
                        break;
                    default:
                        break;
                }
    
                
                if (arr[l, c] != "X" && arr[l, c] != "O")
                {
                    if (turn % 2 == 0) 
                    {
                        arr[l,c] = "O";  
                    }
                    else
                    {
                        arr[l,c] = "X";
                    }
                }
                else
                {
                    Console.WriteLine("A jogada {0} já está marcada com um {1}", jogada, arr[l,c]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Aguarde que estamos redirecionando.....");
                    Thread.Sleep(2000);
                }
                controle = ChecarVitoria();
            }
            while (controle != 1 && controle != -1);
            Console.Clear();
            Board();
            if (controle == 1)
            {
                if (turn %2 == 0)
                {
                Console.WriteLine($"{player2} ganhou!");
                    Jogador PontosGanhos = Program.jogadores.Find(delegate (Jogador j)
                {
                    return j.Nome == player2;
                }); PontosGanhos.Pontuacao = PontosGanhos.Pontuacao + 10;

                    Jogador PontosPerdidos = Program.jogadores.Find(delegate (Jogador j)
                    {
                        return j.Nome == player1;
                    }); PontosPerdidos.Pontuacao = PontosPerdidos.Pontuacao - 5;
                }
                else
                {
                    Console.WriteLine($"{player1} ganhou!");
                    Jogador PontosGanhos = Program.jogadores.Find(delegate (Jogador j)
                    {
                        return j.Nome == player1;
                    }); PontosGanhos.Pontuacao = PontosGanhos.Pontuacao + 10;

                    Jogador PontosPerdidos = Program.jogadores.Find(delegate (Jogador j)
                    {
                        return j.Nome == player2;
                    }); PontosPerdidos.Pontuacao = PontosPerdidos.Pontuacao - 5;
                }
            }
            else Console.WriteLine("Deu empate!");
            Jogador PontosEmpate1 = Program.jogadores.Find(delegate (Jogador j)
            {
                return j.Nome == player1;
            }); PontosEmpate1.Pontuacao = PontosEmpate1.Pontuacao + 5;

            Jogador PontosEmpate2 = Program.jogadores.Find(delegate (Jogador j)
            {
                return j.Nome == player2;
            }); PontosEmpate2.Pontuacao = PontosEmpate2.Pontuacao + 5;

            Jogo.DeslogarJogador(player1, player2);
            Jogo.AtualizarJogo();
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0,0], arr[0,1], arr[0,2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1,0], arr[1,1], arr[1,2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[2,0], arr[2,1], arr[2,2]);
            Console.WriteLine("     |     |      ");
        }
        private static int ChecarVitoria()
        {
            //Checagem horizontal
            if (arr[0,0] == arr[0,1] && arr[0,1] == arr[0,2])
            {
                return 1;
            }
            else if (arr[1,0] == arr[1,1] && arr[1,1] == arr[1,2])
            {
                return 1;
            }
            else if (arr[2,0] == arr[2,1] && arr[2,1] == arr[2,2])
            {
                return 1;
            }
    
            //Checagem vertical
            else if (arr[0,0] == arr[1,0] && arr[1,0] == arr[2,0])
            {
                return 1;
            }
            
            else if (arr[0,1] == arr[1,1] && arr[1,1] == arr[2,1])
            {
                return 1;
            }
            
            else if (arr[0,2] == arr[1,2] && arr[1,2] == arr[2,2])
            {
                return 1;
            }
            
            //Checagem das diagonais
            else if (arr[0,0] == arr[1,1] && arr[1,1] == arr[2,2])
            {
                return 1;
            }
            else if (arr[0,2] == arr[1,1] && arr[1,1] == arr[2,0])
            {
                return 1;
            }
            
            //condição de empate
            else if (arr[0,0] != "1" && arr[0,1] != "2" && arr[0,2] != "3" && arr[1,0] != "4" && arr[1,1] != "5" && arr[1,2] != "6" && arr[2,0] != "7" && arr[2,1]  != "8" && arr[2,2] != "9")
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}