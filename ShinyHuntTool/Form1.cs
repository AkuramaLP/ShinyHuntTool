using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyHuntTool
{
    public partial class Form1 : Form
    {
        OutputTextToFiles OTTF = new OutputTextToFiles();               //Load OutputTextToFiles Class
        Counter count = new Counter();                                                   //L

        public Form1()
        {
            InitializeComponent();

            //Start Function from all Methods
            //OTTF.startActionCounter();                          //Delete exsiting 
            OTTF.createNeededFolders();
            count.Start();                                                //Set countChain to 0
            programmStart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count.addToCounter();                                   //adds 1 to countChain
            OTTF.writeCounterToFile();                          //Outputs countChain to file
            changeTextBox();                                          //Updates Textbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count.removeFromCounter();                         //Removes 1 from countChain
            OTTF.writeCounterToFile();                          //Outputs countChain to file
            changeTextBox();                                          //Updates Textbox
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void programmStart()
        {
            richTextBox1.Text = "0";
        }

        private void changeTextBox()
        {
            richTextBox1.Text = count.countChain.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OTTF.deleteAllData();
        }

        //private void inputCheck_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if(e.KeyCode == Keys.Add)
        //    {

        //    }
        //}
    }
}
