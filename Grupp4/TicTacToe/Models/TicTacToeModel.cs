using System;
using System.Collections.Generic;

namespace TicTacToe.Models
{
    public class TicTacToeModel
    {
        private const char PLAYER = 'X';
        private const char COMPUTER = 'O';
        private List<int> Options { get; } = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        private bool isGameOver;

        public char[] Board { get; } = new char[9];
        public string Output { get; private set; }


        public void Human(int choice)
        {
            if (Board[choice] != PLAYER && Board[choice] != COMPUTER && !isGameOver)
            {
                Board[choice] = PLAYER;
                Options.Remove(choice);
                Winner(PLAYER);
                if(!isGameOver)
                    Computer();
            }
        }

        private void Computer()
        {
            if (Options.Count != 0)
            {
                Random random = new Random();
                var computerChoice = Options[random.Next(Options.Count)];
                Options.Remove(computerChoice);
                Board[computerChoice] = COMPUTER;
                Winner(COMPUTER);
            }
            else
            {
                Output = " It's a Tie";
                isGameOver = true;
            }
        }

        private void Winner(char user)
        {
            var winCombo1 = Board[0] == user && Board[1] == user && Board[2] == user;
            var winCombo2 = Board[3] == user && Board[4] == user && Board[5] == user;
            var winCombo3 = Board[6] == user && Board[7] == user && Board[8] == user;
            var winCombo4 = Board[0] == user && Board[3] == user && Board[6] == user;
            var winCombo5 = Board[1] == user && Board[4] == user && Board[7] == user;
            var winCombo6 = Board[2] == user && Board[5] == user && Board[8] == user;
            var winCombo7 = Board[2] == user && Board[4] == user && Board[6] == user;
            var winCombo8 = Board[0] == user && Board[4] == user && Board[8] == user;

            if (winCombo1 || winCombo2 || winCombo3 || winCombo4 || winCombo5 || winCombo6 || winCombo7 || winCombo8)
            {
                Output = user + " Winner";
                isGameOver = true;
            }
        }
    }
}