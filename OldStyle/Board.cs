using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OldStyle
{
    internal class Board
    {
        private char[,] board;

        public Board()
        {
            board = new char[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = '1';
                }
            }
        }

        public void displayBoard()
        {
            Console.Clear();
            int counter = 1;
            for(int i=0;i< 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
                        if (board[i, j] == '1')
                        {
                            Console.Write($" {counter} |");
                        }
                        else
                        {
                            Console.Write($" {board[i, j]} |");
                        }
                        
                    }
                    else
                    {
                        if (board[i, j] == '1')
                        {
                            Console.Write($" {counter} ");
                        }
                        else
                        {
                            Console.Write($" {board[i, j]} ");
                        }
                    }
                    counter++;
                }
                if(i < 2)
                {
                    Console.WriteLine("\n-----------");
                }
                else
                {
                    Console.WriteLine();
                }
                
            }
        }

        public void fillCell(int num, char ch)
        {
            int adjustedNumber = num - 1;
            int row = adjustedNumber / 3;
            int col = adjustedNumber % 3;

            board[row, col] = ch;
        }

        public bool isValid(int num)
        {
            int adjustedNumber = num - 1;
            int row = adjustedNumber / 3;
            int col = adjustedNumber % 3;
            if((row >= 0 && row < 3) && (col >= 0 && col < 3))
            {
                if (board[row, col] == '1')
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckForWin()
        {
            // Check rows, columns, and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && (board[i, 0] == 'o' || board[i, 0] == 'x')) ||
                    (board[0, i] == board[1, i] && board[1, i] == board[2, i] && (board[0, i] == 'o' || board[0, i] == 'x')))
                {
                    return true;
                }
            }

            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && (board[0, 0] == 'o' || board[0, 0] == 'x')) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && (board[0, 2] == 'o' || board[0, 2] == 'x')))
            {
                return true;
            }

            return false;
        }

        public bool CheckForDraw()
        {
            // Check if all cells are filled
            foreach (char cell in board)
            {
                if (cell != 'x' && cell != 'o')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
