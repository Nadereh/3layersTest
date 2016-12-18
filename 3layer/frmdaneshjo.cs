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
    public partial class frmdaneshjo : Form
    {
        public int iddanshjo;
        public frmdaneshjo(int id)
        {
            iddanshjo = id;
            InitializeComponent();
            dgvvahed.DataSource = new entekhabvahed().selectbydaneshjo(iddanshjo);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (new Frmsabt(iddanshjo).ShowDialog() == DialogResult.OK)
            {
                dgvvahed.DataSource = new entekhabvahed().selectbydaneshjo(iddanshjo);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا واحد انتخاب شده حذف شود؟", "عملیلات حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entekhabvahed = new entekhabvahed();
                entekhabvahed.iddaneshjo = iddanshjo;
                entekhabvahed.iddars = (int)dgvvahed.SelectedRows[0].Cells["iddars"].Value;
                entekhabvahed.idostad = (int)dgvvahed.SelectedRows[0].Cells["idostad"].Value;
                entekhabvahed.delete();
                dgvvahed.DataSource = new entekhabvahed().selectbydaneshjo(iddanshjo);

            }
        }
    }
}
