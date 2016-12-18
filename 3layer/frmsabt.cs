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
    public partial class Frmsabt : Form
    {
        public int iddanshjo;
        public Frmsabt(int id)
        {
            iddanshjo = id;
            InitializeComponent();
            cbx_course.DataSource = new dars().select();
            cbx_ostad.DataSource = new ostad().select();
        }

        private void btn_sabt_Click(object sender, EventArgs e)
        {
            var entekhabvahed = new entekhabvahed();
            entekhabvahed.iddaneshjo = iddanshjo;
            entekhabvahed.iddars = (int)cbx_course.SelectedValue;
            entekhabvahed.idostad = (int)cbx_ostad.SelectedValue;
            entekhabvahed.add();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Frmsabt_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
