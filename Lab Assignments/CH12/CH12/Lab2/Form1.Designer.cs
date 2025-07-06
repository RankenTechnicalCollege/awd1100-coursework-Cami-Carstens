namespace Lab2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUpc = new System.Windows.Forms.TextBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.btnUpcSearch = new System.Windows.Forms.Button();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultUpc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblError2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAccessKey2 = new System.Windows.Forms.TextBox();
            this.txtVerifyUpc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblItemAddSuccess = new System.Windows.Forms.Label();
            this.lblError3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtDistributor = new System.Windows.Forms.TextBox();
            this.txtUnitsPerCase = new System.Windows.Forms.TextBox();
            this.txtCostPerCase = new System.Windows.Forms.TextBox();
            this.txtAccessKey3 = new System.Windows.Forms.TextBox();
            this.txtNewStorePrice = new System.Windows.Forms.TextBox();
            this.txtNewUpc = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Inventory and Price Inquiry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search by UPC:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtUpc
            // 
            this.txtUpc.Location = new System.Drawing.Point(364, 100);
            this.txtUpc.Name = "txtUpc";
            this.txtUpc.Size = new System.Drawing.Size(168, 22);
            this.txtUpc.TabIndex = 4;
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Location = new System.Drawing.Point(232, 92);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(75, 31);
            this.btnNameSearch.TabIndex = 5;
            this.btnNameSearch.Text = "Search";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // btnUpcSearch
            // 
            this.btnUpcSearch.Location = new System.Drawing.Point(555, 92);
            this.btnUpcSearch.Name = "btnUpcSearch";
            this.btnUpcSearch.Size = new System.Drawing.Size(75, 30);
            this.btnUpcSearch.TabIndex = 6;
            this.btnUpcSearch.Text = "Search";
            this.btnUpcSearch.UseVisualStyleBackColor = true;
            this.btnUpcSearch.Click += new System.EventHandler(this.btnUpcSearch_Click);
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.Location = new System.Drawing.Point(26, 140);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(0, 16);
            this.lblResultName.TabIndex = 7;
            // 
            // lblResultUpc
            // 
            this.lblResultUpc.AutoSize = true;
            this.lblResultUpc.Location = new System.Drawing.Point(364, 140);
            this.lblResultUpc.Name = "lblResultUpc";
            this.lblResultUpc.Size = new System.Drawing.Size(0, 16);
            this.lblResultUpc.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblError1);
            this.groupBox1.Controls.Add(this.btnUpdatePrice);
            this.groupBox1.Controls.Add(this.txtAccessKey);
            this.groupBox1.Controls.Add(this.txtNewPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 241);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Store Price:";
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.BackColor = System.Drawing.SystemColors.Control;
            this.lblError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(20, 178);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 16);
            this.lblError1.TabIndex = 5;
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(43, 137);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(156, 38);
            this.btnUpdatePrice.TabIndex = 4;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(24, 104);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(193, 27);
            this.txtAccessKey.TabIndex = 3;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(21, 46);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(196, 27);
            this.txtNewPrice.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Access Key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Price:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblError2);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtAccessKey2);
            this.groupBox2.Controls.Add(this.txtVerifyUpc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 241);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Item:";
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(28, 178);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 16);
            this.lblError2.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAccessKey2
            // 
            this.txtAccessKey2.Location = new System.Drawing.Point(28, 104);
            this.txtAccessKey2.Name = "txtAccessKey2";
            this.txtAccessKey2.Size = new System.Drawing.Size(207, 27);
            this.txtAccessKey2.TabIndex = 3;
            // 
            // txtVerifyUpc
            // 
            this.txtVerifyUpc.Location = new System.Drawing.Point(28, 46);
            this.txtVerifyUpc.Name = "txtVerifyUpc";
            this.txtVerifyUpc.Size = new System.Drawing.Size(207, 27);
            this.txtVerifyUpc.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Access Key:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Verify UPC:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblItemAddSuccess);
            this.groupBox3.Controls.Add(this.lblError3);
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Controls.Add(this.txtDistributor);
            this.groupBox3.Controls.Add(this.txtUnitsPerCase);
            this.groupBox3.Controls.Add(this.txtCostPerCase);
            this.groupBox3.Controls.Add(this.txtAccessKey3);
            this.groupBox3.Controls.Add(this.txtNewStorePrice);
            this.groupBox3.Controls.Add(this.txtNewUpc);
            this.groupBox3.Controls.Add(this.txtNewName);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(40, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 258);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Item:";
            // 
            // lblItemAddSuccess
            // 
            this.lblItemAddSuccess.AutoSize = true;
            this.lblItemAddSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAddSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblItemAddSuccess.Location = new System.Drawing.Point(301, 207);
            this.lblItemAddSuccess.Name = "lblItemAddSuccess";
            this.lblItemAddSuccess.Size = new System.Drawing.Size(0, 16);
            this.lblItemAddSuccess.TabIndex = 16;
            // 
            // lblError3
            // 
            this.lblError3.AutoSize = true;
            this.lblError3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError3.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Location = new System.Drawing.Point(21, 207);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(0, 16);
            this.lblError3.TabIndex = 15;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(301, 163);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(237, 35);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtDistributor
            // 
            this.txtDistributor.Location = new System.Drawing.Point(411, 121);
            this.txtDistributor.Name = "txtDistributor";
            this.txtDistributor.Size = new System.Drawing.Size(127, 27);
            this.txtDistributor.TabIndex = 13;
            // 
            // txtUnitsPerCase
            // 
            this.txtUnitsPerCase.Location = new System.Drawing.Point(411, 84);
            this.txtUnitsPerCase.Name = "txtUnitsPerCase";
            this.txtUnitsPerCase.Size = new System.Drawing.Size(127, 27);
            this.txtUnitsPerCase.TabIndex = 12;
            // 
            // txtCostPerCase
            // 
            this.txtCostPerCase.Location = new System.Drawing.Point(411, 43);
            this.txtCostPerCase.Name = "txtCostPerCase";
            this.txtCostPerCase.Size = new System.Drawing.Size(127, 27);
            this.txtCostPerCase.TabIndex = 11;
            // 
            // txtAccessKey3
            // 
            this.txtAccessKey3.Location = new System.Drawing.Point(101, 171);
            this.txtAccessKey3.Name = "txtAccessKey3";
            this.txtAccessKey3.Size = new System.Drawing.Size(137, 27);
            this.txtAccessKey3.TabIndex = 10;
            // 
            // txtNewStorePrice
            // 
            this.txtNewStorePrice.Location = new System.Drawing.Point(101, 130);
            this.txtNewStorePrice.Name = "txtNewStorePrice";
            this.txtNewStorePrice.Size = new System.Drawing.Size(138, 27);
            this.txtNewStorePrice.TabIndex = 9;
            // 
            // txtNewUpc
            // 
            this.txtNewUpc.Location = new System.Drawing.Point(101, 94);
            this.txtNewUpc.Name = "txtNewUpc";
            this.txtNewUpc.Size = new System.Drawing.Size(138, 27);
            this.txtNewUpc.TabIndex = 8;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(100, 53);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(138, 27);
            this.txtNewName.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(298, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Distributor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(294, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Units Per Case:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(291, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Cost Per Case:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Access Key:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Store Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "UPC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 728);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultUpc);
            this.Controls.Add(this.lblResultName);
            this.Controls.Add(this.btnUpcSearch);
            this.Controls.Add(this.btnNameSearch);
            this.Controls.Add(this.txtUpc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUpc;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Button btnUpcSearch;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label lblResultUpc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAccessKey2;
        private System.Windows.Forms.TextBox txtVerifyUpc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtDistributor;
        private System.Windows.Forms.TextBox txtUnitsPerCase;
        private System.Windows.Forms.TextBox txtCostPerCase;
        private System.Windows.Forms.TextBox txtAccessKey3;
        private System.Windows.Forms.TextBox txtNewStorePrice;
        private System.Windows.Forms.TextBox txtNewUpc;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblItemAddSuccess;
    }
}

