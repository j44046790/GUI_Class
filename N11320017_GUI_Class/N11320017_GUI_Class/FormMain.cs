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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormButton();
            form.Show();
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form formTextBox = new FormTextBox();
            formTextBox.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new MidExan_CtoF();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form from = new FromTimer();
            from.Show();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Form from = new FormGameFinalPaseword();
            from.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form from = new FormMenu();
            from.Show();
        }
    }
}
