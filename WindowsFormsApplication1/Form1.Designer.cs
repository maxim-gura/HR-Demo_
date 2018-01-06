namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marital_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residency_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empList_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.add_Emp_btn = new System.Windows.Forms.Button();
            this.editEmp_btn = new System.Windows.Forms.Button();
            this.delEmp_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.full_name,
            this.dob,
            this.marital_status,
            this.emp_start_date,
            this.nationality,
            this.residency_status});
            this.dataGridView1.Location = new System.Drawing.Point(177, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(627, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle7;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Full name";
            this.full_name.Name = "full_name";
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Date of birth";
            this.dob.Name = "dob";
            // 
            // marital_status
            // 
            this.marital_status.DataPropertyName = "marital_status";
            this.marital_status.HeaderText = "Marital status";
            this.marital_status.Name = "marital_status";
            // 
            // emp_start_date
            // 
            this.emp_start_date.DataPropertyName = "emp_start_date";
            this.emp_start_date.HeaderText = "Employment start";
            this.emp_start_date.Name = "emp_start_date";
            // 
            // nationality
            // 
            this.nationality.DataPropertyName = "nationality";
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            // 
            // residency_status
            // 
            this.residency_status.DataPropertyName = "residency_status";
            this.residency_status.HeaderText = "Residency status";
            this.residency_status.Name = "residency_status";
            // 
            // empList_btn
            // 
            this.empList_btn.Location = new System.Drawing.Point(3, 7);
            this.empList_btn.Name = "empList_btn";
            this.empList_btn.Size = new System.Drawing.Size(169, 28);
            this.empList_btn.TabIndex = 3;
            this.empList_btn.Text = "EMPLOYEES LIST";
            this.empList_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empList_btn.UseVisualStyleBackColor = true;
            this.empList_btn.Click += new System.EventHandler(this.btn_emp_List_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "LEAVE CALENDAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.empList_btn);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.add_Emp_btn);
            this.panel1.Controls.Add(this.editEmp_btn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.delEmp_btn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 400);
            this.panel1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 27);
            this.button7.TabIndex = 10;
            this.button7.Text = "ORG STRUCTURE";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 27);
            this.button6.TabIndex = 9;
            this.button6.Text = "SALARY CHART";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // add_Emp_btn
            // 
            this.add_Emp_btn.Location = new System.Drawing.Point(73, 47);
            this.add_Emp_btn.Name = "add_Emp_btn";
            this.add_Emp_btn.Size = new System.Drawing.Size(96, 27);
            this.add_Emp_btn.TabIndex = 6;
            this.add_Emp_btn.Text = "Add";
            this.add_Emp_btn.UseVisualStyleBackColor = true;
            this.add_Emp_btn.Click += new System.EventHandler(this.btn_add_Emp_Click);
            // 
            // editEmp_btn
            // 
            this.editEmp_btn.Location = new System.Drawing.Point(73, 112);
            this.editEmp_btn.Name = "editEmp_btn";
            this.editEmp_btn.Size = new System.Drawing.Size(96, 28);
            this.editEmp_btn.TabIndex = 8;
            this.editEmp_btn.Text = "Edit";
            this.editEmp_btn.UseVisualStyleBackColor = true;
            // 
            // delEmp_btn
            // 
            this.delEmp_btn.Location = new System.Drawing.Point(73, 80);
            this.delEmp_btn.Name = "delEmp_btn";
            this.delEmp_btn.Size = new System.Drawing.Size(96, 26);
            this.delEmp_btn.TabIndex = 7;
            this.delEmp_btn.Text = "Delete";
            this.delEmp_btn.UseVisualStyleBackColor = true;
            this.delEmp_btn.Click += new System.EventHandler(this.delEmp_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(177, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 31);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(805, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My HR DEMO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button empList_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editEmp_btn;
        private System.Windows.Forms.Button delEmp_btn;
        private System.Windows.Forms.Button add_Emp_btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn marital_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn residency_status;
    }
}

