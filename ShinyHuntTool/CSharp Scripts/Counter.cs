using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinyHuntTool
{
    class Counter
    {
        public int countChain;

        public void Start()
        {
            countChain = 0;
        }

        public void addToCounter()
        {
            countChain++;
        }

        public void removeFromCounter()
        {
            countChain--;
        }
    }
}
