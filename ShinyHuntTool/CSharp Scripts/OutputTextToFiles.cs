using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinyHuntTool
{
    class OutputTextToFiles
    {
        Counter count = new Counter();

        public void startActionCounter()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt", textOutputToFile);
        }

        public void writeToFileCounter()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\Shiny.txt", textOutputToFile);
        }

        public void saveCounter()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\Shiny.txt", textOutputToFile);
        }
    }
}
