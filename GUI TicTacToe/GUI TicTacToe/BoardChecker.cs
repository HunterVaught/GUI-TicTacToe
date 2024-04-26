using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_TicTacToe
{
    class BoardChecker : IChecker
    {
        //fields
        string[] arr = { "", "", "", "", "", "", "", "", "" };

        //commit without the prepare-commit-msg.sample
        int commit = 0;

        //accumulate x or o in 
        public void Accumulate(int i, string s)
        {
            arr[i] = s;
        }
        public void Clear()
        {
            for (int i = 0; i < 9; i++)
                arr[i] = "";
        }
        public bool Xwin()
        {
            if (arr[0] == "X" && arr[1] == "X" && arr[2] == "X")
                return true;
            else if (arr[3] == "X" && arr[4] == "X" && arr[5] == "X")
                return true;
            else if (arr[6] == "X" && arr[7] == "X" && arr[8] == "X")
                return true;
            else if (arr[0] == "X" && arr[4] == "X" && arr[8] == "X")
                return true;
            else if (arr[2] == "X" && arr[4] == "X" && arr[6] == "X")
                return true;
            else if (arr[0] == "X" && arr[3] == "X" && arr[6] == "X")
                return true;
            else if (arr[1] == "X" && arr[4] == "X" && arr[7] == "X")
                return true;
            else if (arr[2] == "X" && arr[5] == "X" && arr[8] == "X")
                return true;
            return false;
        }
        public bool Owin()
        {
            if (arr[0] == "O" && arr[1] == "O" && arr[2] == "O")
                return true;
            else if (arr[3] == "O" && arr[4] == "O" && arr[5] == "O")
                return true;
            else if (arr[6] == "O" && arr[7] == "O" && arr[8] == "O")
                return true;
            else if (arr[0] == "O" && arr[4] == "O" && arr[8] == "O")
                return true;
            else if (arr[2] == "O" && arr[4] == "O" && arr[6] == "O")
                return true;
            else if (arr[0] == "O" && arr[3] == "O" && arr[6] == "O")
                return true;
            else if (arr[1] == "O" && arr[4] == "O" && arr[7] == "O")
                return true;
            else if (arr[2] == "O" && arr[5] == "O" && arr[8] == "O")
                return true;
            return false;
        }
        public bool Tie()
        {
            bool full = true;
            for (int i = 0; i < 9; i++)
            {
                if (arr[i] != "X" && arr[i] != "O")
                    full = false;
            }
            if (!Xwin() && !Owin() && full)
                return true;
            return false;
        }
    }
}
