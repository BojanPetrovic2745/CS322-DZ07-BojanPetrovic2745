using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ07_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.Columns[0].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientBindingSource.EndEdit();
                this.patientTableAdapter.Update(this.hospitalDataSet.Patient);
                this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Save | Update failed!" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                this.patientBindingSource.RemoveCurrent();
                this.patientBindingSource.EndEdit();
                this.patientTableAdapter.Update(this.hospitalDataSet.Patient);
                this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
