using System;
namespace GameHub.Jogos
{
    public class batalhaNaval
    {
    static string[,] arr = new string[8, 8]{
        {" "," ","B","C","C"," "," "," "},
        {"A"," ","B"," ","D","D","D","D"},
        {"A"," ","B"," "," ","G"," "," "},
        {" ","E"," ","F","F","G"," ","H"},
        {" ","E"," "," "," ","G"," ","H"},
        {" ","E"," "," "," "," "," ","H"},
        {" "," "," ","I","I","I","I"," "},
        {" ","J","J","J"," "," ","K","K"},
        };

    static string[,] arrBoard = new string[8, 8]{
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        {" "," "," "," "," "," "," "," "},
        };

    static int turn = 1;
    static int l;
    static int c;
    static int controle;
    static int player1 = 0;
    static int player2 = 0;

    public static void BatalhaNaval()
        {
            do
            {
                Console.Clear();
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
                Console.Write("Em qual posição está o navio?");
                Console.WriteLine();
            Console.WriteLine("Digite primeiro a Linha(letra) e logo depois a Coluna(número)");
            Console.WriteLine("Ex: C5");
                Console.WriteLine();

                string jogada = Console.ReadLine().ToUpper();
                switch (jogada)
                {
                    case "A1":
                        l = 0;
                        c = 0;
                        break;
                    case "A2":
                        l = 0;
                        c = 1;
                        break;
                    case "A3":
                        l = 0;
                        c = 2;
                        break;
                    case "A4":
                        l = 0;
                        c = 3;
                        break;
                    case "A5":
                        l = 0;
                        c = 4;
                        break;
                    case "A6":
                        l = 0;
                        c = 5;
                        break;
                    case "A7":
                        l = 0;
                        c = 6;
                        break;
                    case "A8":
                        l = 0;
                        c = 7;
                        break;
                    case "B1":
                        l = 1;
                        c = 0;
                        break;
                    case "B2":
                        l = 1;
                        c = 1;
                        break;
                    case "B3":
                        l = 1;
                        c = 2;
                        break;
                    case "B4":
                        l = 1;
                        c = 3;
                        break;
                    case "B5":
                        l = 1;
                        c = 4;
                        break;
                    case "B6":
                        l = 1;
                        c = 5;
                        break;
                    case "B7":
                        l = 1;
                        c = 6;
                        break;
                    case "B8":
                        l = 1;
                        c = 7;
                        break;
                    case "C1":
                        l = 2;
                        c = 0;
                        break;
                    case "C2":
                        l = 2;
                        c = 1;
                        break;
                    case "C3":
                        l = 2;
                        c = 2;
                        break;
                    case "C4":
                        l = 2;
                        c = 3;
                        break;
                    case "C5":
                        l = 2;
                        c = 4;
                        break;
                    case "C6":
                        l = 2;
                        c = 5;
                        break;
                    case "C7":
                        l = 2;
                        c = 6;
                        break;
                    case "C8":
                        l = 2;
                        c = 7;
                        break;
                    case "D1":
                        l = 3;
                        c = 0;
                        break;
                    case "D2":
                        l = 3;
                        c = 1;
                        break;
                    case "D3":
                        l = 3;
                        c = 2;
                        break;
                    case "D4":
                        l = 3;
                        c = 3;
                        break;
                    case "D5":
                        l = 3;
                        c = 4;
                        break;
                    case "D6":
                        l = 3;
                        c = 5;
                        break;
                    case "D7":
                        l = 3;
                        c = 6;
                        break;
                    case "D8":
                        l = 3;
                        c = 7;
                        break;
                    case "E1":
                        l = 4;
                        c = 0;
                        break;
                    case "E2":
                        l = 4;
                        c = 1;
                        break;
                    case "E3":
                        l = 4;
                        c = 2;
                        break;
                    case "E4":
                        l = 4;
                        c = 3;
                        break;
                    case "E5":
                        l = 4;
                        c = 4;
                        break;
                    case "E6":
                        l = 4;
                        c = 5;
                        break;
                    case "E7":
                        l = 4;
                        c = 6;
                        break;
                    case "E8":
                        l = 4;
                        c = 7;
                        break;
                    case "F1":
                        l = 5;
                        c = 0;
                        break;
                    case "F2":
                        l = 5;
                        c = 1;
                        break;
                    case "F3":
                        l = 5;
                        c = 2;
                        break;
                    case "F4":
                        l = 5;
                        c = 3;
                        break;
                    case "F5":
                        l = 5;
                        c = 4;
                        break;
                    case "F6":
                        l = 5;
                        c = 5;
                        break;
                    case "F7":
                        l = 5;
                        c = 6;
                        break;
                    case "F8":
                        l = 5;
                        c = 7;
                        break;
                    case "G1":
                        l = 6;
                        c = 0;
                        break;
                    case "G2":
                        l = 6;
                        c = 1;
                        break;
                    case "G3":
                        l = 6;
                        c = 2;
                        break;
                    case "G4":
                        l = 6;
                        c = 3;
                        break;
                    case "G5":
                        l = 6;
                        c = 4;
                        break;
                    case "G6":
                        l = 6;
                        c = 5;
                        break;
                    case "G7":
                        l = 6;
                        c = 6;
                        break;
                    case "G8":
                        l = 6;
                        c = 7;
                        break;
                    case "H1":
                        l = 7;
                        c = 0;
                        break;
                    case "H2":
                        l = 7;
                        c = 1;
                        break;
                    case "H3":
                        l = 7;
                        c = 2;
                        break;
                    case "H4":
                        l = 7;
                        c = 3;
                        break;
                    case "H5":
                        l = 7;
                        c = 4;
                        break;
                    case "H6":
                        l = 7;
                        c = 5;
                        break;
                    case "H7":
                        l = 7;
                        c = 6;
                        break;
                    case "H8":
                        l = 7;
                        c = 7;
                        break;
                    default:
                        break;
                }
            if (arrBoard[l,c] != "X" && arrBoard[l,c] != "O")
            {
                if (arr[l,c] != " ")
                {
                    string temp = arr[l, c];
                    arr[l, c] = " ";
                    arrBoard[l, c] = "O";

                    if (turn % 2 != 0) player1++;
                    else player2++;

                    int existencia = 0;
                    foreach (var item in arr) if (item == temp) existencia++;

                    if (existencia == 0)
                    {
                        if (turn % 2 != 0) player1++;
                        else player2++;
                    }
                    turn++;
                }
                else
                {
                    arrBoard[l, c] = "X";
                    turn++;
                }
            }
            controle = 0;
            foreach (var item in arr) if (item != " ") controle++;
} while (controle != 0);
        if(player1 > player2)
        {
            Console.WriteLine("O player 1 Ganhou!");
        }
        else if (player1 < player2)
        {
            Console.WriteLine("O player 2 Ganhou!");
        }
        else
        {
            Console.WriteLine("Teve empate!");
        }



    }
    private static void Board()
    {
        Console.WriteLine("    1   2   3   4   5   6   7   8    ");
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("A | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | A", arrBoard[0, 0], arrBoard[0, 1], arrBoard[0, 2], arrBoard[0, 3], arrBoard[0, 4], arrBoard[0, 5], arrBoard[0, 6], arrBoard[0, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("B | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | B", arrBoard[1, 0], arrBoard[1, 1], arrBoard[1, 2], arrBoard[1, 3], arrBoard[1, 4], arrBoard[1, 5], arrBoard[1, 6], arrBoard[1, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("C | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | C", arrBoard[2, 0], arrBoard[2, 1], arrBoard[2, 2], arrBoard[2, 3], arrBoard[2, 4], arrBoard[2, 5], arrBoard[2, 6], arrBoard[2, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("D | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | D", arrBoard[3, 0], arrBoard[3, 1], arrBoard[3, 2], arrBoard[3, 3], arrBoard[3, 4], arrBoard[3, 5], arrBoard[3, 6], arrBoard[3, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("E | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | E", arrBoard[4, 0], arrBoard[4, 1], arrBoard[4, 2], arrBoard[4, 3], arrBoard[4, 4], arrBoard[4, 5], arrBoard[4, 6], arrBoard[4, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("F | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | F", arrBoard[5, 0], arrBoard[5, 1], arrBoard[5, 2], arrBoard[5, 3], arrBoard[5, 4], arrBoard[5, 5], arrBoard[5, 6], arrBoard[5, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("G | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | G", arrBoard[6, 0], arrBoard[6, 1], arrBoard[6, 2], arrBoard[6, 3], arrBoard[6, 4], arrBoard[6, 5], arrBoard[6, 6], arrBoard[6, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("H | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | H", arrBoard[7, 0], arrBoard[7, 1], arrBoard[7, 2], arrBoard[7, 3], arrBoard[7, 4], arrBoard[7, 5], arrBoard[7, 6], arrBoard[7, 7]);
        Console.WriteLine("  - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("    1   2   3   4   5   6   7   8    ");
    }
}
}
