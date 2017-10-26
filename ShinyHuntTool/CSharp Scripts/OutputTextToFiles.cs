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
        public bool DEBUG = false;

        public void startActionCounter()
        {
            if(DEBUG == true)
            {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt")))
                {
                    try
                    {
                        System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt"));
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);

                        
                        return;
                    }
                }

                string textOutputToFile = count.countChain.ToString();
                System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt"), textOutputToFile);
            }
            else if(DEBUG == false)
            {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt")))
                {
                    try
                    {
                        System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt"));
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }

                string textOutputToFile = count.countChain.ToString();
                System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt"), textOutputToFile);
            }
        }

        public void writeCounterToFile()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt"), textOutputToFile);
        }

        public void saveCounter()
        {
            string textOutputToFile = count.countChain.ToString();
            System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt" ), textOutputToFile);
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
                if(System.IO.Directory.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt")))
                {
                    try
                    {
                        System.IO.Directory.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.txt"), true);
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
