using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace N11320017_GUI_Class
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv","時間,主食,飲料\n",Encoding.UTF8);
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String main = "", drinking = "";

            foreach(Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {

                        main += chk.Text + " "; // main = main + chk.Text
                        //MessageBox.Show(chk.Text);
                    }
                }
            }


            foreach(Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if(chk.Checked)
                    {
                        drinking += chk.Text + " "; // drinking = dinking + chk.Text
                        //MessageBox.Show(chk.Text);
                    }
                }
                
                
                 


            }

            main = main.Remove(main.Length - 1, 1);
            drinking = drinking.Remove(drinking.Length - 1, 1);

            DateTime currentDateTime = DateTime.Now;
            String OrderTime = currentDateTime.ToString("yyyy/MM/dd HH/mm/ss");



            File.AppendAllText("OrderData.csv", OrderTime+","+main+"," + drinking + "\n");
            //MessageBox.Show("主餐:" + main + "\n飲料:" + drinking);
            MessageBox.Show("點餐成功");





        }


       
    }
}
