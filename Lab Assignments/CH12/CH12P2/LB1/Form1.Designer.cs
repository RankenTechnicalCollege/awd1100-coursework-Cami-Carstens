namespace LB1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblNameOrFoodError = new System.Windows.Forms.Label();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkChocolateSyrup = new System.Windows.Forms.CheckBox();
            this.chkLime = new System.Windows.Forms.CheckBox();
            this.chkPeach = new System.Windows.Forms.CheckBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.lblToppingsError = new System.Windows.Forms.Label();
            this.lblMixinError = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grpSundaeToppings = new System.Windows.Forms.GroupBox();
            this.grpDrinkMixins = new System.Windows.Forms.GroupBox();
            this.grpSundaeToppings.SuspendLayout();
            this.grpDrinkMixins.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "What name do you want on the order?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 22);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do you want a sundae?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Do you want a soda?";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(36, 531);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(222, 41);
            this.btnAddToOrder.TabIndex = 7;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblNameOrFoodError
            // 
            this.lblNameOrFoodError.AutoSize = true;
            this.lblNameOrFoodError.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameOrFoodError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOrFoodError.ForeColor = System.Drawing.Color.Red;
            this.lblNameOrFoodError.Location = new System.Drawing.Point(38, 125);
            this.lblNameOrFoodError.Name = "lblNameOrFoodError";
            this.lblNameOrFoodError.Size = new System.Drawing.Size(257, 18);
            this.lblNameOrFoodError.TabIndex = 8;
            this.lblNameOrFoodError.Text = "Name required/ No food selected";
            this.lblNameOrFoodError.Visible = false;
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(41, 215);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(53, 20);
            this.chkSundae.TabIndex = 9;
            this.chkSundae.Text = "Yes";
            this.chkSundae.UseVisualStyleBackColor = true;
            this.chkSundae.CheckedChanged += new System.EventHandler(this.chkSundae_CheckedChanged);
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(272, 215);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(53, 20);
            this.chkSoda.TabIndex = 10;
            this.chkSoda.Text = "Yes";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(9, 40);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(85, 20);
            this.chkSprinkles.TabIndex = 11;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(9, 77);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(56, 20);
            this.chkNuts.TabIndex = 12;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkChocolateSyrup
            // 
            this.chkChocolateSyrup.AutoSize = true;
            this.chkChocolateSyrup.Location = new System.Drawing.Point(9, 115);
            this.chkChocolateSyrup.Name = "chkChocolateSyrup";
            this.chkChocolateSyrup.Size = new System.Drawing.Size(128, 20);
            this.chkChocolateSyrup.TabIndex = 13;
            this.chkChocolateSyrup.Text = "Chocolate Syrup";
            this.chkChocolateSyrup.UseVisualStyleBackColor = true;
            // 
            // chkLime
            // 
            this.chkLime.AutoSize = true;
            this.chkLime.Location = new System.Drawing.Point(10, 40);
            this.chkLime.Name = "chkLime";
            this.chkLime.Size = new System.Drawing.Size(99, 20);
            this.chkLime.TabIndex = 14;
            this.chkLime.Text = "Lime Flavor";
            this.chkLime.UseVisualStyleBackColor = true;
            // 
            // chkPeach
            // 
            this.chkPeach.AutoSize = true;
            this.chkPeach.Location = new System.Drawing.Point(10, 77);
            this.chkPeach.Name = "chkPeach";
            this.chkPeach.Size = new System.Drawing.Size(109, 20);
            this.chkPeach.TabIndex = 15;
            this.chkPeach.Text = "Peach Flavor";
            this.chkPeach.UseVisualStyleBackColor = true;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(10, 115);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(112, 20);
            this.chkMango.TabIndex = 16;
            this.chkMango.Text = "Mango Flavor";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // lblToppingsError
            // 
            this.lblToppingsError.AutoSize = true;
            this.lblToppingsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsError.ForeColor = System.Drawing.Color.Red;
            this.lblToppingsError.Location = new System.Drawing.Point(33, 455);
            this.lblToppingsError.Name = "lblToppingsError";
            this.lblToppingsError.Size = new System.Drawing.Size(187, 18);
            this.lblToppingsError.TabIndex = 17;
            this.lblToppingsError.Text = "Only 2 toppings allowed";
            this.lblToppingsError.Visible = false;
            // 
            // lblMixinError
            // 
            this.lblMixinError.AutoSize = true;
            this.lblMixinError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMixinError.ForeColor = System.Drawing.Color.Red;
            this.lblMixinError.Location = new System.Drawing.Point(269, 455);
            this.lblMixinError.Name = "lblMixinError";
            this.lblMixinError.Size = new System.Drawing.Size(168, 18);
            this.lblMixinError.TabIndex = 18;
            this.lblMixinError.Text = "Only 1 mix-in allowed";
            this.lblMixinError.Visible = false;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(473, 96);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(387, 347);
            this.rtbOutput.TabIndex = 19;
            this.rtbOutput.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(655, 455);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPrice.TabIndex = 22;
            // 
            // grpSundaeToppings
            // 
            this.grpSundaeToppings.Controls.Add(this.chkSprinkles);
            this.grpSundaeToppings.Controls.Add(this.chkNuts);
            this.grpSundaeToppings.Controls.Add(this.chkChocolateSyrup);
            this.grpSundaeToppings.Location = new System.Drawing.Point(32, 265);
            this.grpSundaeToppings.Name = "grpSundaeToppings";
            this.grpSundaeToppings.Size = new System.Drawing.Size(201, 161);
            this.grpSundaeToppings.TabIndex = 23;
            this.grpSundaeToppings.TabStop = false;
            this.grpSundaeToppings.Text = "Sundae Toppings";
            this.grpSundaeToppings.Visible = false;
            // 
            // grpDrinkMixins
            // 
            this.grpDrinkMixins.Controls.Add(this.chkLime);
            this.grpDrinkMixins.Controls.Add(this.chkPeach);
            this.grpDrinkMixins.Controls.Add(this.chkMango);
            this.grpDrinkMixins.Location = new System.Drawing.Point(253, 265);
            this.grpDrinkMixins.Name = "grpDrinkMixins";
            this.grpDrinkMixins.Size = new System.Drawing.Size(200, 161);
            this.grpDrinkMixins.TabIndex = 24;
            this.grpDrinkMixins.TabStop = false;
            this.grpDrinkMixins.Text = "Drink Mix-ins";
            this.grpDrinkMixins.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 625);
            this.Controls.Add(this.grpDrinkMixins);
            this.Controls.Add(this.grpSundaeToppings);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lblMixinError);
            this.Controls.Add(this.lblToppingsError);
            this.Controls.Add(this.chkSoda);
            this.Controls.Add(this.chkSundae);
            this.Controls.Add(this.lblNameOrFoodError);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSundaeToppings.ResumeLayout(false);
            this.grpSundaeToppings.PerformLayout();
            this.grpDrinkMixins.ResumeLayout(false);
            this.grpDrinkMixins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblNameOrFoodError;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkChocolateSyrup;
        private System.Windows.Forms.CheckBox chkLime;
        private System.Windows.Forms.CheckBox chkPeach;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.Label lblToppingsError;
        private System.Windows.Forms.Label lblMixinError;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox grpSundaeToppings;
        private System.Windows.Forms.GroupBox grpDrinkMixins;
    }
}

