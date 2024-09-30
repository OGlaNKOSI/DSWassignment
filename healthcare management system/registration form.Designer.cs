namespace WindowsFormsApp1
{
    partial class Registrationform
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
            this.regName = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.RegSubmit = new System.Windows.Forms.Button();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.txtIdno = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.RegistrationHeading = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.regName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncreate)).BeginInit();
            this.SuspendLayout();
            // 
            // regName
            // 
            this.regName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.regName.BackColor = System.Drawing.Color.Transparent;
            this.regName.Controls.Add(this.button2);
            this.regName.Controls.Add(this.Create);
            this.regName.Controls.Add(this.dataGridView1);
            this.regName.Controls.Add(this.label8);
            this.regName.Controls.Add(this.RegSubmit);
            this.regName.Controls.Add(this.txtPatientId);
            this.regName.Controls.Add(this.label7);
            this.regName.Controls.Add(this.textBox6);
            this.regName.Controls.Add(this.label3);
            this.regName.Controls.Add(this.txtHomeAddress);
            this.regName.Controls.Add(this.txtGender);
            this.regName.Controls.Add(this.label6);
            this.regName.Controls.Add(this.label5);
            this.regName.Controls.Add(this.label4);
            this.regName.Controls.Add(this.txtDateOfBirth);
            this.regName.Controls.Add(this.label);
            this.regName.Controls.Add(this.label2);
            this.regName.Controls.Add(this.label1);
            this.regName.Controls.Add(this.txtCellNo);
            this.regName.Controls.Add(this.txtIdno);
            this.regName.Controls.Add(this.txtSurname);
            this.regName.Controls.Add(this.txtFirstName);
            this.regName.Controls.Add(this.RegistrationHeading);
            this.regName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.regName.Location = new System.Drawing.Point(249, 2);
            this.regName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(662, 797);
            this.regName.TabIndex = 1;
            this.regName.Paint += new System.Windows.Forms.PaintEventHandler(this.regName_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 27;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(13, 580);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(123, 46);
            this.Create.TabIndex = 26;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 554);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(357, 182);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 455);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Patient ID:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RegSubmit
            // 
            this.RegSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RegSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegSubmit.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegSubmit.Location = new System.Drawing.Point(13, 498);
            this.RegSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegSubmit.Name = "RegSubmit";
            this.RegSubmit.Size = new System.Drawing.Size(600, 48);
            this.RegSubmit.TabIndex = 23;
            this.RegSubmit.Text = "Submit";
            this.RegSubmit.UseVisualStyleBackColor = false;
            this.RegSubmit.Click += new System.EventHandler(this.RegSubmit_Click);
            // 
            // txtPatientId
            // 
            this.txtPatientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientId.Location = new System.Drawing.Point(162, 448);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(457, 26);
            this.txtPatientId.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Blood group:";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox6.Location = new System.Drawing.Point(471, 262);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 26);
            this.textBox6.TabIndex = 20;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Home Address:";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomeAddress.Location = new System.Drawing.Point(162, 402);
            this.txtHomeAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(457, 26);
            this.txtHomeAddress.TabIndex = 18;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(162, 312);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(148, 28);
            this.txtGender.TabIndex = 17;
            this.txtGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = " Cell number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date of birth:";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(162, 269);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(148, 26);
            this.txtDateOfBirth.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(33, 229);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 25);
            this.label.TabIndex = 8;
            this.label.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // txtCellNo
            // 
            this.txtCellNo.Location = new System.Drawing.Point(162, 354);
            this.txtCellNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(148, 26);
            this.txtCellNo.TabIndex = 4;
            // 
            // txtIdno
            // 
            this.txtIdno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtIdno.Location = new System.Drawing.Point(162, 222);
            this.txtIdno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdno.Name = "txtIdno";
            this.txtIdno.Size = new System.Drawing.Size(457, 26);
            this.txtIdno.TabIndex = 3;
            this.txtIdno.Text = "988";
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSurname.Location = new System.Drawing.Point(162, 182);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(457, 26);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Text = "mashamba";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(162, 149);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(457, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "mary";
            // 
            // RegistrationHeading
            // 
            this.RegistrationHeading.AutoSize = true;
            this.RegistrationHeading.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationHeading.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegistrationHeading.Location = new System.Drawing.Point(86, 35);
            this.RegistrationHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegistrationHeading.Name = "RegistrationHeading";
            this.RegistrationHeading.Size = new System.Drawing.Size(505, 34);
            this.RegistrationHeading.TabIndex = 0;
            this.RegistrationHeading.Text = "Hospital Patient Registartion form";
            this.RegistrationHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncreate
            // 
            this.btncreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btncreate.Image = global::WindowsFormsApp1.Resource1.openart_image_f0WpZqST_1724571258787_raw;
            this.btncreate.Location = new System.Drawing.Point(-172, -14);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(1318, 1014);
            this.btncreate.TabIndex = 0;
            this.btncreate.TabStop = false;
            // 
            // Registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 694);
            this.Controls.Add(this.regName);
            this.Controls.Add(this.btncreate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registrationform";
            this.Tag = "Registrationform";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.regName.ResumeLayout(false);
            this.regName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btncreate;
        private System.Windows.Forms.Panel regName;
        private System.Windows.Forms.Label RegistrationHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.TextBox txtIdno;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button RegSubmit;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Create;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}