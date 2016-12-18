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
    public partial class frmostad : Form
    {
        public int idostad;
        public frmostad(int id)
        {
            idostad = id;
            InitializeComponent();
            dgvostad.DataSource = new entekhabvahed().selectbyostad(idostad);
        }

        private void ostad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvostad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Login.ShowDialog();
        }

        private void dgvostad_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var entekhabvahed = new entekhabvahed();
            entekhabvahed.idostad = idostad;
            entekhabvahed.iddaneshjo = (int)dgvostad.Rows[e.RowIndex].Cells["iddaneshjo"].Value;
            entekhabvahed.iddars = (int)dgvostad.Rows[e.RowIndex].Cells["iddars"].Value;
            entekhabvahed.nomrh = (float)dgvostad.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            entekhabvahed.update();

        }
    }
}
