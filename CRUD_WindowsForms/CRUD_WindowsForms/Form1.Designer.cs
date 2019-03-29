namespace CRUD_WindowsForms
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
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_regno = new System.Windows.Forms.TextBox();
            this.textBox_phoneno = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.cRUDDataSet = new CRUD_WindowsForms.CRUDDataSet();
            this.cRUDtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUD_tableTableAdapter = new CRUD_WindowsForms.CRUDDataSetTableAdapters.CRUD_tableTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cRUDtableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRUDtableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSet1 = new CRUD_WindowsForms.CRUDDataSet1();
            this.cRUDtableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDtableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cRUD_tableTableAdapter1 = new CRUD_WindowsForms.CRUDDataSet1TableAdapters.CRUD_tableTableAdapter();
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_sname
            // 
            this.textBox_sname.Location = new System.Drawing.Point(98, 34);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 20);
            this.textBox_sname.TabIndex = 0;
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(305, 34);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(100, 20);
            this.textBox_fname.TabIndex = 1;
            // 
            // textBox_regno
            // 
            this.textBox_regno.Location = new System.Drawing.Point(98, 79);
            this.textBox_regno.Name = "textBox_regno";
            this.textBox_regno.Size = new System.Drawing.Size(100, 20);
            this.textBox_regno.TabIndex = 2;
            // 
            // textBox_phoneno
            // 
            this.textBox_phoneno.Location = new System.Drawing.Point(305, 79);
            this.textBox_phoneno.Name = "textBox_phoneno";
            this.textBox_phoneno.Size = new System.Drawing.Size(100, 20);
            this.textBox_phoneno.TabIndex = 3;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(98, 126);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 20);
            this.textBox_address.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Father Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reg Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(19, 197);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 10;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(100, 197);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(181, 197);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(262, 197);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // cRUDDataSet
            // 
            this.cRUDDataSet.DataSetName = "CRUDDataSet";
            this.cRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDtableBindingSource
            // 
            this.cRUDtableBindingSource.DataMember = "CRUD_table";
            this.cRUDtableBindingSource.DataSource = this.cRUDDataSet;
            // 
            // cRUD_tableTableAdapter
            // 
            this.cRUD_tableTableAdapter.ClearBeforeFill = true;
            // 
            // cRUDtableBindingSource1
            // 
            this.cRUDtableBindingSource1.DataMember = "CRUD_table";
            this.cRUDtableBindingSource1.DataSource = this.cRUDDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.regnoDataGridViewTextBoxColumn,
            this.phonenoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cRUDtableBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(20, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 207);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "Student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "Student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "Student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "Student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "Father_name";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Father_name";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            // 
            // regnoDataGridViewTextBoxColumn
            // 
            this.regnoDataGridViewTextBoxColumn.DataPropertyName = "Reg_no";
            this.regnoDataGridViewTextBoxColumn.HeaderText = "Reg_no";
            this.regnoDataGridViewTextBoxColumn.Name = "regnoDataGridViewTextBoxColumn";
            // 
            // phonenoDataGridViewTextBoxColumn
            // 
            this.phonenoDataGridViewTextBoxColumn.DataPropertyName = "Phone_no";
            this.phonenoDataGridViewTextBoxColumn.HeaderText = "Phone_no";
            this.phonenoDataGridViewTextBoxColumn.Name = "phonenoDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cRUDtableBindingSource4
            // 
            this.cRUDtableBindingSource4.DataMember = "CRUD_table";
            this.cRUDtableBindingSource4.DataSource = this.cRUDDataSet1;
            // 
            // cRUDDataSet1
            // 
            this.cRUDDataSet1.DataSetName = "CRUDDataSet1";
            this.cRUDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDtableBindingSource3
            // 
            this.cRUDtableBindingSource3.DataMember = "CRUD_table";
            this.cRUDtableBindingSource3.DataSource = this.cRUDDataSet;
            // 
            // cRUDtableBindingSource2
            // 
            this.cRUDtableBindingSource2.DataMember = "CRUD_table";
            this.cRUDtableBindingSource2.DataSource = this.cRUDDataSet;
            // 
            // cRUD_tableTableAdapter1
            // 
            this.cRUD_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(587, 197);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 15;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(481, 200);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(100, 20);
            this.textBox_find.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Student ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(520, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_phoneno);
            this.Controls.Add(this.textBox_regno);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.textBox_sname);
            this.Name = "Form1";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDtableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_regno;
        private System.Windows.Forms.TextBox textBox_phoneno;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_reset;
        private CRUDDataSet cRUDDataSet;
        private System.Windows.Forms.BindingSource cRUDtableBindingSource;
        private CRUDDataSetTableAdapters.CRUD_tableTableAdapter cRUD_tableTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource cRUDtableBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cRUDtableBindingSource2;
        private System.Windows.Forms.BindingSource cRUDtableBindingSource3;
        private CRUDDataSet1 cRUDDataSet1;
        private System.Windows.Forms.BindingSource cRUDtableBindingSource4;
        private CRUDDataSet1TableAdapters.CRUD_tableTableAdapter cRUD_tableTableAdapter1;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

