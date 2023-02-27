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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spirometrija_DataSet.Ucenici' table. You can move, or remove it, as needed.
            this.uceniciTableAdapter.Fill(this.spirometrija_DataSet.Ucenici);
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

        }

        private void sljedeci1_Click(object sender, EventArgs e)
        {
            this.uceniciBindingSource.MoveNext();
        }

        private void prethodni2_Click(object sender, EventArgs e)
        {
            this.uceniciBindingSource.MovePrevious();
        }

        private void dodaj3_Click(object sender, EventArgs e)
        {
            this.uceniciBindingSource.AddNew();
        }

        private void spremi4_Click(object sender, EventArgs e)
        {
            this.uceniciBindingSource.EndEdit();
            this.uceniciTableAdapter.Update(spirometrija_DataSet.Ucenici);
            this.uceniciTableAdapter.Fill(spirometrija_DataSet.Ucenici);
        }

        private void obrisi5_Click(object sender, EventArgs e)
        {
            this.uceniciBindingSource.RemoveCurrent();
            this.uceniciBindingSource.EndEdit();
            this.uceniciTableAdapter.Update(spirometrija_DataSet.Ucenici);
            this.uceniciTableAdapter.Fill(spirometrija_DataSet.Ucenici);
        }

        private void kraj6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); 
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
