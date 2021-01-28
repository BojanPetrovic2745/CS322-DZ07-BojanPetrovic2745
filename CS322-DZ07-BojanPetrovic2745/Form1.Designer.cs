
namespace CS322_DZ07_BojanPetrovic2745
{
    partial class Form1
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label jmbgLabel;
            System.Windows.Forms.Label simptomiLabel;
            System.Windows.Forms.Label terapijaLabel;
            System.Windows.Forms.Label izlecenLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmbgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simptomiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izlecenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new CS322_DZ07_BojanPetrovic2745.HospitalDataSet();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.jmbgTextBox = new System.Windows.Forms.TextBox();
            this.simptomiTextBox = new System.Windows.Forms.TextBox();
            this.terapijaTextBox = new System.Windows.Forms.TextBox();
            this.izlecenCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patientTableAdapter = new CS322_DZ07_BojanPetrovic2745.HospitalDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new CS322_DZ07_BojanPetrovic2745.HospitalDataSetTableAdapters.TableAdapterManager();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            jmbgLabel = new System.Windows.Forms.Label();
            simptomiLabel = new System.Windows.Forms.Label();
            terapijaLabel = new System.Windows.Forms.Label();
            izlecenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(15, 58);
            imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(33, 16);
            imeLabel.TabIndex = 2;
            imeLabel.Text = "ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(15, 103);
            prezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(59, 16);
            prezimeLabel.TabIndex = 4;
            prezimeLabel.Text = "prezime:";
            // 
            // jmbgLabel
            // 
            jmbgLabel.AutoSize = true;
            jmbgLabel.Location = new System.Drawing.Point(15, 158);
            jmbgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jmbgLabel.Name = "jmbgLabel";
            jmbgLabel.Size = new System.Drawing.Size(41, 16);
            jmbgLabel.TabIndex = 6;
            jmbgLabel.Text = "jmbg:";
            // 
            // simptomiLabel
            // 
            simptomiLabel.AutoSize = true;
            simptomiLabel.Location = new System.Drawing.Point(15, 210);
            simptomiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            simptomiLabel.Name = "simptomiLabel";
            simptomiLabel.Size = new System.Drawing.Size(65, 16);
            simptomiLabel.TabIndex = 8;
            simptomiLabel.Text = "simptomi:";
            // 
            // terapijaLabel
            // 
            terapijaLabel.AutoSize = true;
            terapijaLabel.Location = new System.Drawing.Point(15, 252);
            terapijaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            terapijaLabel.Name = "terapijaLabel";
            terapijaLabel.Size = new System.Drawing.Size(56, 16);
            terapijaLabel.TabIndex = 10;
            terapijaLabel.Text = "terapija:";
            // 
            // izlecenLabel
            // 
            izlecenLabel.AutoSize = true;
            izlecenLabel.Location = new System.Drawing.Point(15, 290);
            izlecenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            izlecenLabel.Name = "izlecenLabel";
            izlecenLabel.Size = new System.Drawing.Size(53, 16);
            izlecenLabel.TabIndex = 12;
            izlecenLabel.Text = "izlecen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.jmbgDataGridViewTextBoxColumn,
            this.simptomiDataGridViewTextBoxColumn,
            this.terapijaDataGridViewTextBoxColumn,
            this.izlecenDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDpaDataGridViewTextBoxColumn
            // 
            this.iDpaDataGridViewTextBoxColumn.DataPropertyName = "IDpa";
            this.iDpaDataGridViewTextBoxColumn.HeaderText = "IDpa";
            this.iDpaDataGridViewTextBoxColumn.Name = "iDpaDataGridViewTextBoxColumn";
            this.iDpaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // jmbgDataGridViewTextBoxColumn
            // 
            this.jmbgDataGridViewTextBoxColumn.DataPropertyName = "jmbg";
            this.jmbgDataGridViewTextBoxColumn.HeaderText = "jmbg";
            this.jmbgDataGridViewTextBoxColumn.Name = "jmbgDataGridViewTextBoxColumn";
            // 
            // simptomiDataGridViewTextBoxColumn
            // 
            this.simptomiDataGridViewTextBoxColumn.DataPropertyName = "simptomi";
            this.simptomiDataGridViewTextBoxColumn.HeaderText = "simptomi";
            this.simptomiDataGridViewTextBoxColumn.Name = "simptomiDataGridViewTextBoxColumn";
            // 
            // terapijaDataGridViewTextBoxColumn
            // 
            this.terapijaDataGridViewTextBoxColumn.DataPropertyName = "terapija";
            this.terapijaDataGridViewTextBoxColumn.HeaderText = "terapija";
            this.terapijaDataGridViewTextBoxColumn.Name = "terapijaDataGridViewTextBoxColumn";
            // 
            // izlecenDataGridViewCheckBoxColumn
            // 
            this.izlecenDataGridViewCheckBoxColumn.DataPropertyName = "izlecen";
            this.izlecenDataGridViewCheckBoxColumn.HeaderText = "izlecen";
            this.izlecenDataGridViewCheckBoxColumn.Name = "izlecenDataGridViewCheckBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(120, 49);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(132, 22);
            this.imeTextBox.TabIndex = 3;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(120, 95);
            this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(132, 22);
            this.prezimeTextBox.TabIndex = 5;
            // 
            // jmbgTextBox
            // 
            this.jmbgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "jmbg", true));
            this.jmbgTextBox.Location = new System.Drawing.Point(120, 149);
            this.jmbgTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jmbgTextBox.Name = "jmbgTextBox";
            this.jmbgTextBox.Size = new System.Drawing.Size(132, 22);
            this.jmbgTextBox.TabIndex = 7;
            // 
            // simptomiTextBox
            // 
            this.simptomiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "simptomi", true));
            this.simptomiTextBox.Location = new System.Drawing.Point(120, 202);
            this.simptomiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.simptomiTextBox.Name = "simptomiTextBox";
            this.simptomiTextBox.Size = new System.Drawing.Size(132, 22);
            this.simptomiTextBox.TabIndex = 9;
            // 
            // terapijaTextBox
            // 
            this.terapijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "terapija", true));
            this.terapijaTextBox.Location = new System.Drawing.Point(120, 244);
            this.terapijaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.terapijaTextBox.Name = "terapijaTextBox";
            this.terapijaTextBox.Size = new System.Drawing.Size(132, 22);
            this.terapijaTextBox.TabIndex = 11;
            // 
            // izlecenCheckBox
            // 
            this.izlecenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientBindingSource, "izlecen", true));
            this.izlecenCheckBox.Location = new System.Drawing.Point(159, 278);
            this.izlecenCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.izlecenCheckBox.Name = "izlecenCheckBox";
            this.izlecenCheckBox.Size = new System.Drawing.Size(40, 37);
            this.izlecenCheckBox.TabIndex = 13;
            this.izlecenCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create Pacijent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update Pacijent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(755, 300);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete Pacijent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(izlecenLabel);
            this.groupBox1.Controls.Add(this.izlecenCheckBox);
            this.groupBox1.Controls.Add(terapijaLabel);
            this.groupBox1.Controls.Add(this.terapijaTextBox);
            this.groupBox1.Controls.Add(simptomiLabel);
            this.groupBox1.Controls.Add(this.simptomiTextBox);
            this.groupBox1.Controls.Add(jmbgLabel);
            this.groupBox1.Controls.Add(this.jmbgTextBox);
            this.groupBox1.Controls.Add(prezimeLabel);
            this.groupBox1.Controls.Add(this.prezimeTextBox);
            this.groupBox1.Controls.Add(imeLabel);
            this.groupBox1.Controls.Add(this.imeTextBox);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1014, 377);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacijent";
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KontrolaTableAdapter = null;
            this.tableAdapterManager.Patient_KontrolaTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = CS322_DZ07_BojanPetrovic2745.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1042, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 64);
            this.button4.TabIndex = 31;
            this.button4.Text = "Kontrola";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1042, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 64);
            this.button5.TabIndex = 32;
            this.button5.Text = "Zakazi Pregled";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 427);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simptomiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn izlecenDataGridViewCheckBoxColumn;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox jmbgTextBox;
        private System.Windows.Forms.TextBox simptomiTextBox;
        private System.Windows.Forms.TextBox terapijaTextBox;
        private System.Windows.Forms.CheckBox izlecenCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

