using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEmployee sam = new cEmployee();
            sam.firstname = "ali";
            sam.lastname = "yahyavi";
            sam.identity = "75755623";
            label1.Text = sam.Concatinate();

        }
    }
}
