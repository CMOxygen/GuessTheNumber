using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    namespace GameModel
    {
        public class NumberGenerator
        {
            private int num = 0;
            private int min = 0;
            private int max = 0;

            public NumberGenerator(int min, int max)
            {
                if (min < 0 || max < 1)
                {
                    return;
                }
                else
                {
                    this.min = min;
                    this.max = max;
                }
            }

            public int Num { get { return num; } private set { num = value; } }
            public int Min { get { return min; } private set { min = value; } }
            public int Max { get { return max; }  private set { max = value; } }

            public void GenerateNumber()
            {
                // Creates random number between min and max object values
                Random rnd = new Random();
                num = rnd.Next(min, max + 1);
            }
        }
    }
}
