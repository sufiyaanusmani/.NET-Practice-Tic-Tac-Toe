namespace OldStyle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            bool gameEnded = false;
            int num;

            while(gameEnded == false)
            {
                while (true)
                {
                    board.displayBoard();
                    Console.Write("\nPlayer 1: Choose your field! ");
                    num = int.Parse(Console.ReadLine());
                    if (board.isValid(num))
                    {
                        board.fillCell(num, 'o');
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid!");
                    }
                }


                if (board.CheckForDraw())
                {
                    Console.WriteLine("Match Drawn");
                    break;
                }else if (board.CheckForWin())
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }


                while (true)
                {
                    board.displayBoard();
                    Console.Write("\nPlayer 2: Choose your field! ");
                    num = int.Parse(Console.ReadLine());
                    if (board.isValid(num))
                    {
                        board.fillCell(num, 'x');
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid!");
                    }
                }


                if (board.CheckForDraw())
                {
                    Console.WriteLine("Match Drawn");
                    break;
                }
                else if (board.CheckForWin())
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }

            }

            board.displayBoard();
            Console.ReadKey();
        }
    }
}
