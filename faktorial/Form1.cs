using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = null;
           
            int n = Convert.ToInt32(textBox2.Text);
            long fakt = 1;
            for (int i = 2; i <= n; i++) fakt *= i;
            label4.Text = fakt.ToString();
      
        }
    }
}
