using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Controller
    {
        int counter = 1;
        bool[] buttonsClicked = { false, false, false, false, false, false, false, false, false };
        int[] spotsMarked = { 3, 4, 5, 6, 7, 8, 9, 10, 11};
        bool winCon = false;

        public Controller()
        {

        }

        public int getCounter()
        {
            return counter;
        }
        public void updateCounter()
        {
            counter++;
        }
        public bool getButtonClicked(int a)
        {
            return buttonsClicked[a];
        }
        public void setButtonClicked(int a, bool b)
        {
            buttonsClicked[a] = b;
        }
        public void setSpotMark(int spot, int mark)
        {
            spotsMarked[spot] = mark;
        }
        public bool checkWin()
        { 
            if (spotsMarked[0] == spotsMarked[1] && spotsMarked[0] == spotsMarked[2])
                winCon = true;
            else if (spotsMarked[0] == spotsMarked[4] && spotsMarked[0] == spotsMarked[8])
                winCon = true;
            else if (spotsMarked[0] == spotsMarked[3] && spotsMarked[0] == spotsMarked[6])
                winCon = true;
            else if (spotsMarked[1] == spotsMarked[4] && spotsMarked[1] == spotsMarked[7])
                winCon = true;
            else if (spotsMarked[2] == spotsMarked[4] && spotsMarked[2] == spotsMarked[6])
                winCon = true;
            else if (spotsMarked[2] == spotsMarked[5] && spotsMarked[2] == spotsMarked[8])
                winCon = true;
            else if (spotsMarked[3] == spotsMarked[4] && spotsMarked[3] == spotsMarked[5])
                winCon = true;
            else if (spotsMarked[6] == spotsMarked[7] && spotsMarked[6] == spotsMarked[8])
                winCon = true;

            return winCon;
        }
    }
}
