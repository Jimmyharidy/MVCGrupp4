using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class TicTacToeModel
    {
        public int[] Board { get; set; } = new int[10];
        public int   Input { get; set; }
        public char X { get; set; } = 'X';
        public char Y { get; set; } = '?';

        public void Test(int choice)
        {
            Input = choice;
            Board[choice] = 'O';
            Computer();
        }

        public void Computer()
        {
            Random random = new Random();
            var computerChoice = random.Next(1, 9);
            Board[computerChoice] = 'X';
        }
    }
}