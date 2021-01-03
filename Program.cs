using System;
using System.Linq;

namespace Minimax
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] gameBoard = new char[7, 7] {{'e','e','e','b','e','e','e'}, // e <-- empty
                                                    {'e','e','e','e','e','e','e'}, // b <-- black pawn
                                                    {'e','e','e','e','e','e','e'}, // w <-- white pawn
                                                    {'e','e','e','e','e','e','e'}, // d <-- blocked
                                                    {'e','e','e','e','e','e','e'},
                                                    {'e','e','e','e','e','e','e'},
                                                    {'e','e','e','w','e','e','e'},
                                                    };

            var gameTree = new GameTree(gameBoard);
            var tree = gameTree.CreateTree(true, 4, null);

            var minimax = new Minimax();
            tree.Value = minimax.Compute(tree, 3, true);
        }
    }
}
