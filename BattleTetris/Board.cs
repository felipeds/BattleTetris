using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTetris
{
    class Board
    {
        private bool[,] status = new bool[10,20];

        private Block currentBlock;

        private List<Block> nextBlock = new List<Block>();

        //instantiate the board and configure it.
        public Board()
        {
            for(int i = 0; i < StaticConfiguration.NR_NEXT_BLOCKS; i++)
            {
                nextBlock.Add(new Block());
            }
        }

        public void updateBoard()
        {

        }
    }
}
