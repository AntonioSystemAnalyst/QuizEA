using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizEA
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            Program.Key = "open";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTFundamental_Click(object sender, EventArgs e)
        {
            Program.path = "resources\\perguntas\\N1.txt";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.path = "resources\\perguntas\\N2.txt";
            this.Close();
        }
    }
}
