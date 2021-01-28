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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient_Kontrola' table. You can move, or remove it, as needed.
            this.patient_KontrolaTableAdapter.Fill(this.hospitalDataSet.Patient_Kontrola);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.patientKontrolaBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientKontrolaBindingSource.EndEdit();
                this.patient_KontrolaTableAdapter.Update(this.hospitalDataSet.Patient_Kontrola);
                this.patient_KontrolaTableAdapter.Fill(this.hospitalDataSet.Patient_Kontrola);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Save | Update failed!" + ex.Message);
            }
        }
    }
}
