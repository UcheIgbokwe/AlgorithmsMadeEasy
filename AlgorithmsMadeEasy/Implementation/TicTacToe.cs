using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsMadeEasy.Implementation
{
    class TicTacToe
    {
        #region UcheIgbokwe
        //20200804
        //Design a Tic-tac-toe game that is played between two players on a n x n grid.
        #endregion
        private int[] rows;
        private int[] cols;
        private int diags;
        private int xDiags;
        private int n;

        public TicTacToe(int n)
        {
            this.n = n;
            rows = new int[n];
            cols = new int[n];
            diags = 0;
            xDiags = 0;
        }

        /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            //row = 1, col = 0
            int count = player == 1 ? 1 : -1;

            rows[row] += count;
            cols[col] += count;

            if (row == col)
            {
                diags += count;
            }

            if (row + col == n - 1)
            {
                xDiags += count;
            }

            if (Math.Abs(rows[row]) == n || Math.Abs(cols[col]) == n || diags == n || xDiags == n)
            {
                return count > 0 ? 1 : 2;
            }

            return 0;
        }

    }
}
