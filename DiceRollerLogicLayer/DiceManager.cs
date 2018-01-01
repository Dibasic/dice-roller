using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLogicLayer
{
    public class DiceManager
    {
        public int d2 { get; set; }
        public int d3 { get; set; }
        public int d4 { get; set; }
        public int d6 { get; set; }
        public int d8 { get; set; }
        public int d10 { get; set; }
        public int d12 { get; set; }
        public int d20 { get; set; }
        public int d100 { get; set; }
        public int dx { get; set; }
        public int x { get; set; }
        public int add { get; set; }

        private Random rng;
        public DiceManager()
        {
            rng = new Random();
        }
        public int Roll()
        {
            int result = 0;

            result += RollDice(2, d2);
            result += RollDice(3, d3);
            result += RollDice(4, d4);
            result += RollDice(6, d6);
            result += RollDice(8, d8);
            result += RollDice(10, d10);
            result += RollDice(12, d12);
            result += RollDice(20, d20);
            result += RollDice(100, d100);

            if (x > 0)
            {
                result += RollDice(x, dx);
            }

            result += add;

            return result;
        }
        private int RollDice(int sides, int times)
        {
            int result = 0;

            for (int i = 0; i < times; i++)
            {
                result += RollDie(sides);
            }

            return result;
        }
        private int RollDie(int sides)
        {
            int result = rng.Next(1, sides + 1);
            return result;
        }
    }
}
