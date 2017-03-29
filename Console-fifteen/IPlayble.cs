using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    public interface IPlayable
    {
        int Size { get; }
        int this[int i, int j] { get; }
        void Randomize();
        void Shift(int value);
        bool IsWinner();
    }
}
