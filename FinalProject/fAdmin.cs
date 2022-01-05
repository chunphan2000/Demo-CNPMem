using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }


        private void accountantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPMDataSet.GOODS' table. You can move, or remove it, as needed.
            this.gOODSTableAdapter.Fill(this.cNPMDataSet.GOODS);

        }
    }
}
