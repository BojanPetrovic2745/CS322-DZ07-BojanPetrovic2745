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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Kontrola' table. You can move, or remove it, as needed.
            this.kontrolaTableAdapter.Fill(this.hospitalDataSet.Kontrola);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.kontrolaBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.kontrolaBindingSource.EndEdit();
                this.kontrolaTableAdapter.Update(this.hospitalDataSet.Kontrola);
                this.kontrolaTableAdapter.Fill(this.hospitalDataSet.Kontrola);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Save | Update failed!" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                this.kontrolaBindingSource.RemoveCurrent();
                this.kontrolaBindingSource.EndEdit();
                this.kontrolaTableAdapter.Update(this.hospitalDataSet.Kontrola);
                this.kontrolaTableAdapter.Fill(this.hospitalDataSet.Kontrola);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!" + ex.Message);
            }
        }
    }
    }
