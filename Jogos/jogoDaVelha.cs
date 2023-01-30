namespace GameHub.Jogos
{
    public class jogoDaVelha
    {
        static string[,] arr = new string[3, 3] { { "1", "2", "3" },{ "4", "5", "6" },{ "7", "8", "9" } };
        static int turn = 1; 
        static int l;
        static int c;
        static int controle = 0;
        static void JogodaVelha(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (turn % 2 == 0)
                {
                    Console.WriteLine("Player 2 é a sua vez de jogar!");
                }
                else
                {
                    Console.WriteLine("Player 1 é a sua vez de jogar!");
                }
                Console.WriteLine("\n");
                Board();
                Console.Write("Gostaria de jogar em qual posição? ");
                
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
                        turn++;
                    }
                    else
                    {
                        arr[l,c] = "X";
                        turn++;
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
            if (controle == 1)Console.WriteLine("O jogador {0} ganhou!", (turn % 2) + 1);
            
            else  Console.WriteLine("Deu empate!");
            
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
            
            else if (arr[1,0] == arr[1,1] && arr[1,1] == arr[1,2])
            {
                return 1;
            }
            
            else if (arr[2,0] == arr[2,1] && arr[2,1] == arr[2,2])
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