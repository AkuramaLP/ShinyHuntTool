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
            if(System.IO.File.Exists(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt"))
            {
                try
                {
                    System.IO.File.Delete(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt");
                }
                catch(System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt", textOutputToFile);
        }

        public void writeCounterToFile()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt", textOutputToFile);
        }

        public void saveCounter()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt", textOutputToFile);
        }
    }
}
