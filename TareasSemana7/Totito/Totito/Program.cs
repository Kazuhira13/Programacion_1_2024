

namespace Totito
{
    class Program
    {
        static char[,] board = new char[3, 3]; 

        static void Main(string[] args)
        {
            ResetBoard();
            char currentPlayer = 'X'; 

            while (true)
            {
                Console.Clear();
                PrintBoard();

                Console.Write($"Jugador {currentPlayer}, ingrese la fila (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write($"Jugador {currentPlayer}, ingrese la columna (0-2): ");
                int col = int.Parse(Console.ReadLine());

                if (board[row, col] != '\0') 
                {
                    Console.WriteLine("Posición ya ocupada. Intente de nuevo.");
                    Console.ReadKey();
                    continue;
                }

                board[row, col] = currentPlayer;

                if (CheckWin(currentPlayer))
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"¡El jugador {currentPlayer} ha ganado!");
                    Console.ReadKey();
                    ResetBoard();
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X'; 
                }
                else if (IsBoardFull())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine("¡Empate!");
                    Console.ReadKey();
                    ResetBoard();
                }
                else
                {
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X'; 
                }
            }
        }

        static void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '\0'; 
                }
            }
        }

        static void PrintBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine(" -------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + "|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] == '\0' ? " " : board[i, j]);
                    if (j != 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" -------");
        }

        static bool CheckWin(char player)
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    return true;
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                {
                    return true;
                }
            }

            
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }

            return false;
        }

        static bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '\0')
                    {
                        return false; 
                    }
                }
            }

            return true; 
        }
    }
}