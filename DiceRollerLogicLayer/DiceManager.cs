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
        public DiceManager()
        {
            
        }
        public int Roll()
        {
            int result = 0;

            Random rng = new Random();

            for (int i = 0; i < d2; i++)
            {
                result += rng.Next(1, 3);
            }

            for (int i = 0; i < d3; i++)
            {
                result += rng.Next(1, 4);
            }

            for (int i = 0; i < d4; i++)
            {
                result += rng.Next(1, 5);
            }

            for (int i = 0; i < d6; i++)
            {
                result += rng.Next(1, 7);
            }

            for (int i = 0; i < d8; i++)
            {
                result += rng.Next(1, 9);
            }

            for (int i = 0; i < d10; i++)
            {
                result += rng.Next(1, 11);
            }

            for (int i = 0; i < d12; i++)
            {
                result += rng.Next(1, 13);
            }

            for (int i = 0; i < d20; i++)
            {
                result += rng.Next(1, 21);
            }

            for (int i = 0; i < d100; i++)
            {
                result += rng.Next(1, 101);
            }

            if (x > 0)
            {
                for (int i = 0; i < dx; i++)
                {
                    result += rng.Next(1, x+1);
                }
            }

            result += add;

            return result;
        }
    }
}
