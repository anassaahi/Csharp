using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
namespace Gameincsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char dir1 = 'r';
            char dir2 = 'r';
            char dir3 = 'r';
            char[,] board = new char[10, 30];
            Player player = new Player('P', 20, 8);
            Enemy enemy1 = new Enemy('e', 2, 2);
            Enemy enemy2 = new Enemy('x', 17, 3);
            Enemy enemy3 = new Enemy('n', 26, 4);
            Thread.Sleep(150);
            string[] boardRows = {
    "############################",
    "#                          #",
    "#                          #",
    "#                          #",
    "#                          #",
    "#                          #",
    "#                          #",
    "#                          #",
    "#                          #",
    "############################"
};
            for (int i = 0; i < boardRows.Length; i++)
            {
                for (int j = 0; j < boardRows[i].Length; j++)
                {
                    board[i, j] = boardRows[i][j];
                }
            }
            board[player.pY, player.pX] = player.playerchar;
            board[enemy1.eY, enemy1.eX] = enemy1.enemychar;
            board[enemy2.eY, enemy2.eX] = enemy2.enemychar;
            board[enemy3.eY, enemy3.eX] = enemy3.enemychar;
            Console.Clear();
            printboard(board);
            while (true)
            {
                Thread.Sleep(150);
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveplayerleft(player, board);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveplayerright(player, board);
                }
                if (enemystrike(enemy1, board, dir1))
                {
                    if (dir1 == 'l')
                        dir1 = 'r';



                    else if (dir1 == 'r')
                        dir1 = 'l';
                }

                if (enemystrike(enemy2, board, dir2))
                {
                    if (dir2 == 'l')
                        dir2 = 'r';
                    else if (dir2 == 'r')
                        dir2 = 'l';
                }
                if (enemystrike(enemy3, board, dir3))
                {
                    if (dir3 == 'l')
                        dir3 = 'r';
                    else if (dir3 == 'r')
                        dir3 = 'l';
                }
                moveenemy(enemy1, board, dir1);
                moveenemy(enemy2, board, dir2);
                moveenemy(enemy3, board, dir3);
                Console.Clear();
                printboard(board);
            }
        }
        static void printboard(char[,] board)
        {
            string print = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    print += board[i, j];
                }
                print += "\n";
            }
            Console.Write(print);
        }
        static void moveplayerright(Player player, char[,] board)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (board[i, j] == player.playerchar)
                    {
                        board[i, j] = ' ';
                        if (j < 26)
                        {
                            board[i, j + 1] = player.playerchar;
                        }
                        else
                        {
                            board[i, j] = player.playerchar;
                        }
                        break;
                    }
                }
            }
        }
        static void moveplayerleft(Player player, char[,] board)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (board[i, j] == player.playerchar)
                    {
                        board[i, j] = ' ';
                        if (j > 1)
                        {
                            board[i, j - 1] = player.playerchar;
                        }
                        else
                        {
                            board[i, j] = player.playerchar;
                        }
                        break;
                    }
                }
            }
        }
        static void moveenemy(Enemy enemy, char[,] board, char direction)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (board[i, j] == enemy.enemychar)
                    {
                        board[i, j] = ' ';
                        if (direction == 'l')
                        {
                            board[i, j - 1] = enemy.enemychar;
                        }
                        else if (direction == 'r')
                        {
                            board[i, j + 1] = enemy.enemychar;
                        }
                        break;
                    }
                }
            }
        }
        static bool enemystrike(Enemy enemy, char[,] board, char direction)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (board[i, j] == enemy.enemychar)
                    {
                        if (direction == 'l')
                        {
                            if (board[i, j - 1] == ' ')
                                return false;
                            else
                                return true;
                        }
                        else if (direction == 'r')
                        {
                            if (board[i, j + 1] == ' ')
                                return false;
                            else
                                return true;
                        }
                        break;
                    }
                }
            }
            return true;
        }
    }
}



