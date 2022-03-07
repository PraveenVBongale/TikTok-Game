using System;

namespace TikTokGame
{
    public static class TikTokGame
    {
        private static char[] board = new char[10];

        static TikTokGame()
        {
            Array.Fill(board, ' ');
        }

        public static void DisplayBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                Console.Write(board[i] + " ");
                if (i % 3 == 0)
                    Console.WriteLine();
            }
        }
    }
}