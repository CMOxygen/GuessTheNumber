using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    namespace GameModel
    {
        public class SuccessCounter
        {
            private int counter = 0;

            public int Counter { get { return counter; } private set { } }

            public void IncreaseCount() { counter++; }
            public void ResetCount() { counter = 0; }
        }
    }
}
