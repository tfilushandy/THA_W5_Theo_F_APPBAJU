using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_APLIKASI_BAJU
{
    public partial class Form1 : Form
    {
        string text;
        int jmlhwelcome = 0;
        int counter= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter>jmlhwelcome)
            {
                counter = 0;
                lblwelcome.Text = "";
            }
            else
            {
                lblwelcome.Text = text.Substring(0, counter);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text = lblwelcome.Text;
            jmlhwelcome = text.Length;
            lblwelcome.Text = "";
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            Form2 baru = new Form2();
            baru.Show();
            
        }
    }
}
