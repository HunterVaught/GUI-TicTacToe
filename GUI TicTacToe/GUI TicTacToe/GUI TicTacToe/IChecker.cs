using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_TicTacToe
{
    public interface IChecker
    {
        void Accumulate(int i, string s);
        void Clear();
        bool Xwin();
        bool Owin();
        bool Tie();
    }
}
