using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bl;

namespace _3layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var daneshjo = new Bl.daneshjo();
                if (daneshjo.login(textBox1.Text, textBox2.Text))
                {
                    var form = new frmdaneshjo(int.Parse(textBox1.Text));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری و رمز اشتباه می باشد");
                }
            }
            else
            {

                var ostad = new ostad();
                if (ostad.login(textBox1.Text, textBox2.Text))
                {
                    var form = new frmostad(int.Parse(textBox1.Text));
                    form.ShowDialog();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
