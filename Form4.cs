using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminarski.inf
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Spirometrija_DataSet.Ucenici' table. You can move, or remove it, as needed.
            this.UceniciTableAdapter.Fill(this.Spirometrija_DataSet.Ucenici);

            this.reportViewer1.RefreshReport();
        }
    }
}
