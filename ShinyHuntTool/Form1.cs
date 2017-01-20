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
        OutputTextToFiles OTTF = new OutputTextToFiles();

        public Form1()
        {
            InitializeComponent();
            OTTF.startActionCounter();
        }

        //private void inputCheck_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if(e.KeyCode == Keys.Add)
        //    {

        //    }
        //}
    }
}
