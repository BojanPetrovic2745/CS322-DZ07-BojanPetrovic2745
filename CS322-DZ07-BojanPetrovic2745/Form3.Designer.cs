
namespace CS322_DZ07_BojanPetrovic2745
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label kontroalDLabel;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kontroalDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.patientKontrolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new CS322_DZ07_BojanPetrovic2745.HospitalDataSet();
            this.patientIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontroalDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.patient_KontrolaTableAdapter = new CS322_DZ07_BojanPetrovic2745.HospitalDataSetTableAdapters.Patient_KontrolaTableAdapter();
            this.tableAdapterManager = new CS322_DZ07_BojanPetrovic2745.HospitalDataSetTableAdapters.TableAdapterManager();
            patientIDLabel = new System.Windows.Forms.Label();
            kontroalDLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontroalDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientKontrolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(56, 43);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 29;
            patientIDLabel.Text = "Patient ID:";
            // 
            // kontroalDLabel
            // 
            kontroalDLabel.AutoSize = true;
            kontroalDLabel.Location = new System.Drawing.Point(53, 69);
            kontroalDLabel.Name = "kontroalDLabel";
            kontroalDLabel.Size = new System.Drawing.Size(60, 13);
            kontroalDLabel.TabIndex = 30;
            kontroalDLabel.Text = "Kontroal D:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(kontroalDLabel);
            this.groupBox3.Controls.Add(this.kontroalDNumericUpDown);
            this.groupBox3.Controls.Add(patientIDLabel);
            this.groupBox3.Controls.Add(this.patientIDNumericUpDown);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(42, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 240);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pacijent Kontrola";
            // 
            // kontroalDNumericUpDown
            // 
            this.kontroalDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientKontrolaBindingSource, "KontroalD", true));
            this.kontroalDNumericUpDown.Location = new System.Drawing.Point(119, 69);
            this.kontroalDNumericUpDown.Name = "kontroalDNumericUpDown";
            this.kontroalDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.kontroalDNumericUpDown.TabIndex = 31;
            // 
            // patientKontrolaBindingSource
            // 
            this.patientKontrolaBindingSource.DataMember = "Patient_Kontrola";
            this.patientKontrolaBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientIDNumericUpDown
            // 
            this.patientIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientKontrolaBindingSource, "PatientID", true));
            this.patientIDNumericUpDown.Location = new System.Drawing.Point(119, 43);
            this.patientIDNumericUpDown.Name = "patientIDNumericUpDown";
            this.patientIDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.patientIDNumericUpDown.TabIndex = 30;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.kontroalDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.patientKontrolaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(303, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(348, 91);
            this.dataGridView3.TabIndex = 29;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // kontroalDDataGridViewTextBoxColumn
            // 
            this.kontroalDDataGridViewTextBoxColumn.DataPropertyName = "KontroalD";
            this.kontroalDDataGridViewTextBoxColumn.HeaderText = "KontroalD";
            this.kontroalDDataGridViewTextBoxColumn.Name = "kontroalDDataGridViewTextBoxColumn";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(470, 149);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(215, 60);
            this.button9.TabIndex = 22;
            this.button9.Text = "Delete Pregled";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(246, 149);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(215, 60);
            this.button8.TabIndex = 21;
            this.button8.Text = "Update Pregled";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 149);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 60);
            this.button7.TabIndex = 20;
            this.button7.Text = "Create Pregled";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // patient_KontrolaTableAdapter
            // 
            this.patient_KontrolaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KontrolaTableAdapter = null;
            this.tableAdapterManager.Patient_KontrolaTableAdapter = this.patient_KontrolaTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS322_DZ07_BojanPetrovic2745.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontroalDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientKontrolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource patientKontrolaBindingSource;
        private HospitalDataSetTableAdapters.Patient_KontrolaTableAdapter patient_KontrolaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontroalDDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown kontroalDNumericUpDown;
        private System.Windows.Forms.NumericUpDown patientIDNumericUpDown;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}