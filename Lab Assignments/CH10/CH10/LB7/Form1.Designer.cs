namespace LB7
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCourseSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboStudentId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbEngOutput = new System.Windows.Forms.RichTextBox();
            this.rtbPsychOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboRemoveCourseSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Student ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Add Student To Current Course:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(155, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 62);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(137, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(299, 22);
            this.txtLastName.TabIndex = 35;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(137, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(299, 22);
            this.txtFirstName.TabIndex = 34;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(137, 60);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(299, 22);
            this.txtStudentId.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email Address:";
            // 
            // cboCourseSelection
            // 
            this.cboCourseSelection.FormattingEnabled = true;
            this.cboCourseSelection.Location = new System.Drawing.Point(137, 226);
            this.cboCourseSelection.Name = "cboCourseSelection";
            this.cboCourseSelection.Size = new System.Drawing.Size(299, 24);
            this.cboCourseSelection.TabIndex = 0;
            this.cboCourseSelection.SelectedIndexChanged += new System.EventHandler(this.cboCourseSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Course Selection:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Silver;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(155, 577);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(262, 58);
            this.btnRemove.TabIndex = 46;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboStudentId
            // 
            this.cboStudentId.BackColor = System.Drawing.Color.White;
            this.cboStudentId.FormattingEnabled = true;
            this.cboStudentId.Location = new System.Drawing.Point(137, 503);
            this.cboStudentId.Name = "cboStudentId";
            this.cboStudentId.Size = new System.Drawing.Size(299, 24);
            this.cboStudentId.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 22);
            this.label6.TabIndex = 44;
            this.label6.Text = "Remove Student By Course and ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Student ID:";
            // 
            // rtbEngOutput
            // 
            this.rtbEngOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEngOutput.Location = new System.Drawing.Point(463, 48);
            this.rtbEngOutput.Name = "rtbEngOutput";
            this.rtbEngOutput.Size = new System.Drawing.Size(536, 295);
            this.rtbEngOutput.TabIndex = 48;
            this.rtbEngOutput.Text = "";
            // 
            // rtbPsychOutput
            // 
            this.rtbPsychOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPsychOutput.Location = new System.Drawing.Point(463, 385);
            this.rtbPsychOutput.Name = "rtbPsychOutput";
            this.rtbPsychOutput.Size = new System.Drawing.Size(536, 270);
            this.rtbPsychOutput.TabIndex = 49;
            this.rtbPsychOutput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "ENGLISH COMPOSITION 101";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "ADVANCED PSYCHOLOGY 202";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Course Selection:";
            // 
            // cboRemoveCourseSelection
            // 
            this.cboRemoveCourseSelection.FormattingEnabled = true;
            this.cboRemoveCourseSelection.Location = new System.Drawing.Point(137, 452);
            this.cboRemoveCourseSelection.Name = "cboRemoveCourseSelection";
            this.cboRemoveCourseSelection.Size = new System.Drawing.Size(299, 24);
            this.cboRemoveCourseSelection.TabIndex = 53;
            this.cboRemoveCourseSelection.SelectedIndexChanged += new System.EventHandler(this.cboRemoveCourseSelection_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 686);
            this.Controls.Add(this.cboRemoveCourseSelection);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbPsychOutput);
            this.Controls.Add(this.rtbEngOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cboStudentId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCourseSelection);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCourseSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboStudentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbEngOutput;
        private System.Windows.Forms.RichTextBox rtbPsychOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboRemoveCourseSelection;
    }
}

