using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class ConsoleGameUI
    {
        public IPlayable GameInterface;

        public ConsoleGameUI(IPlayable fifteen)
        {
            GameInterface = (IPlayable)fifteen;
        }

        public void Print()
        {
            var fifteen = (IPlayable)GameInterface;
            for (int i = 0; i < GameInterface.Size; i++)
            {
                for (int j = 0; j < GameInterface.Size; j++)
                {
                    Console.Write(GameInterface[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        public void Move()
        {
            int value = Convert.ToInt32(Console.ReadLine());

            try
            {
                GameInterface.Shift(value);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Невозможно передвинуть");
                Move();
            }

            Console.Clear();
            Print();
        }

    }
}
