using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class Game3 : Game2, IPlayable
    {
        private List<int> history;

        public Game3(params int[] values) : base(values)
        {
            history = new List<int>();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            history.Add(value);
        }

        /**** Откат ходов ****/
        public void RollbackSteps(int countMovies)
        {
            if (countMovies > history.Count)
                throw new ArgumentException("Некорректное количество шагов для отката");

            int lastMove = 0;
            for (int i = 0; i < countMovies; i++)
            {
                lastMove = history.Last();
                history.Remove(lastMove);
                base.Shift(lastMove);
            }
        }
        /*********************/
    }
}
