namespace Lab1_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.btnDefine = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpAddNew = new System.Windows.Forms.GroupBox();
            this.txtNewDefinition = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpResult.SuspendLayout();
            this.grpAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flash Cards";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter term you would like defined:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(51, 111);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(303, 22);
            this.txtTerm.TabIndex = 2;
            // 
            // btnDefine
            // 
            this.btnDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefine.Location = new System.Drawing.Point(427, 94);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(242, 39);
            this.btnDefine.TabIndex = 3;
            this.btnDefine.Text = "Define";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(12, 149);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(776, 116);
            this.grpResult.TabIndex = 4;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Definition";
            this.grpResult.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(31, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 18);
            this.lblResult.TabIndex = 0;
            // 
            // grpAddNew
            // 
            this.grpAddNew.Controls.Add(this.label4);
            this.grpAddNew.Controls.Add(this.txtNewTerm);
            this.grpAddNew.Controls.Add(this.label3);
            this.grpAddNew.Controls.Add(this.btnAdd);
            this.grpAddNew.Controls.Add(this.txtNewDefinition);
            this.grpAddNew.Location = new System.Drawing.Point(12, 284);
            this.grpAddNew.Name = "grpAddNew";
            this.grpAddNew.Size = new System.Drawing.Size(776, 252);
            this.grpAddNew.TabIndex = 5;
            this.grpAddNew.TabStop = false;
            this.grpAddNew.Text = "Add New Defintion";
            this.grpAddNew.Visible = false;
            // 
            // txtNewDefinition
            // 
            this.txtNewDefinition.Location = new System.Drawing.Point(6, 151);
            this.txtNewDefinition.Name = "txtNewDefinition";
            this.txtNewDefinition.Size = new System.Drawing.Size(749, 22);
            this.txtNewDefinition.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(415, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(242, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Term:\r\n";
            // 
            // txtNewTerm
            // 
            this.txtNewTerm.Location = new System.Drawing.Point(10, 66);
            this.txtNewTerm.Name = "txtNewTerm";
            this.txtNewTerm.Size = new System.Drawing.Size(253, 22);
            this.txtNewTerm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "New Definition:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.grpAddNew);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpAddNew.ResumeLayout(false);
            this.grpAddNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpAddNew;
        private System.Windows.Forms.TextBox txtNewDefinition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewTerm;
    }
}

