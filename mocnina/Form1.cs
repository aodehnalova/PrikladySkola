using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mocnina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = null;
            
            int a = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
       
           
            long moc = 1;
            for (int i = 1; i <= n; i++) moc *= a;
            label3.Text = moc.ToString();
            
        }
    }
}
