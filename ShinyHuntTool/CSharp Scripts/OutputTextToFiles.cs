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
        private bool DEBUG = false;

        public void startActionCounter()
        {
            if(DEBUG == true)
            {
                if (System.IO.File.Exists(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt"))
                {
                    try
                    {
                        System.IO.File.Delete(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }

                string textOutputToFile = count.countChain.ToString();
                System.IO.File.WriteAllText(@"C:\Users\Jonathan.Witt\Desktop\TEST\ShinyCounter.txt", textOutputToFile);
            }
            else if(DEBUG == false)
            {
                if (System.IO.File.Exists(@"C:\ShinyHuntTool\ShinyCounter.txt"))
                {
                    try
                    {
                        System.IO.File.Delete(@"C:\ShinyHuntTool\ShinyCounter.txt");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }

                string textOutputToFile = count.countChain.ToString();
                System.IO.File.WriteAllText(@"C:\ShinyHuntTool\ShinyCounter.txt", textOutputToFile);
            }
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

        public void createNeededFolders()
        {
            if(DEBUG == false)
            {
                string folderName = @"C:\ShinyHuntTool";
                string pathString = System.IO.Path.Combine(folderName, "SubFolder");

                System.IO.Directory.CreateDirectory(pathString);
            }
            startActionCounter();
        }

        public void deleteAllData()             //When Installed Change Path
        {
            if(DEBUG == false)
            {
                if(System.IO.Directory.Exists(@"C:\ShinyHuntTool"))
                {
                    try
                    {
                        System.IO.Directory.Delete(@"C:\ShinyHuntTool", true);
                    }
                    catch(System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
