namespace Prog120_S24_ExtraCredit_TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board =
            {
                {'X', 'O', ' '}, // Row 1
                {' ', 'X', 'O'}, // Row 2
                {'O', ' ', 'X'}, // Row 3
            };

            char[,] board2 =
            {
                {'X', ' ', 'O'}, // Row 1
                {'O', ' ', 'O'}, // Row 2
                {'X', ' ', 'O'}, // Row 3
            };

            if (CheckForWin(board2))
            {
                Console.WriteLine("This board has a winner");
                // If(X is the winner) Console.WriteLine(X won)
            }
            else
            {
                Console.WriteLine("This is a loosing board");
            }
        } // Main

        public static bool CheckForWin(char[,] board)
        {
            // Write the code to check the board to see if it is a winning board.
            // Extra Credit 10 points - Check to see if either player won on the diagnol
            // Extra Credit 10 points - (Optional) check to see if any player won on the veritcal or horizontal
            // EXTRA  credit - Display who won
            return false;
        }
    } // Class
} // namespace
