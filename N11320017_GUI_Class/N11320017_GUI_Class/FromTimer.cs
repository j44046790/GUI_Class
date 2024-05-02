using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11320017_GUI_Class
{
    public partial class FromTimer : Form
    {
        int second;
        public FromTimer()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
