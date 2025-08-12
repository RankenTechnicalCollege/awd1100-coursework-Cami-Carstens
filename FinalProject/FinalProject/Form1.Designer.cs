namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbBook = new PictureBox();
            cboGenre = new ComboBox();
            cboBookSelection = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
           // txtSearch = new TextBox();
           // btnSearch = new Button();
            btnSelect = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            label8 = new Label();
            rtbAddBook = new RichTextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            txtBookName = new TextBox();
            label11 = new Label();
            btnCalculate = new Button();
            label10 = new Label();
            label12 = new Label();
            lblBookCart = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBook).BeginInit();
            SuspendLayout();
            // 
            // pbBook
            // 
            pbBook.Location = new Point(29, 84);
            pbBook.Name = "pbBook";
            pbBook.Size = new Size(320, 347);
            pbBook.SizeMode = PictureBoxSizeMode.Zoom;
            pbBook.TabIndex = 0;
            pbBook.TabStop = false;
            // 
            // cboGenre
            // 
            cboGenre.FormattingEnabled = true;
            cboGenre.Location = new Point(29, 498);
            cboGenre.Name = "cboGenre";
            cboGenre.Size = new Size(252, 28);
            cboGenre.TabIndex = 1;
            cboGenre.SelectedIndexChanged += cboGenre_SelectedIndexChanged;
            // 
            // cboBookSelection
            // 
            cboBookSelection.FormattingEnabled = true;
            cboBookSelection.Location = new Point(29, 587);
            cboBookSelection.Name = "cboBookSelection";
            cboBookSelection.Size = new Size(250, 28);
            cboBookSelection.TabIndex = 2;
            cboBookSelection.SelectedIndexChanged += cboBookSelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 453);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 3;
            label1.Text = "Genre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 547);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 4;
            label2.Text = "Book Selection:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 31);
            label3.Name = "label3";
            label3.Size = new Size(373, 38);
            label3.TabIndex = 5;
            label3.Text = "Find Your Next Favorite Read";

            // 
            //txtSearch


            //txtSearch.Location = new Point(474, 31);
            //txtSearch.Name = "txtSearch";
            //txtSearch.Size = new Size(283, 27);
            //txtSearch.TabIndex = 6;
            //// 
            //btnSearch
            
            //btnSearch.Location = new Point(777, 20);
            //btnSearch.Name = "btnSearch";
            //btnSearch.Size = new Size(161, 44);
            //btnSearch.TabIndex = 7;
            //btnSearch.Text = "Search";
            //btnSearch.UseVisualStyleBackColor = true;
            // btnSearch.Click += btnSearch_Click;

            //btnSelect;
            //
            btnSelect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(32, 642);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(144, 51);
            btnSelect.TabIndex = 8;
            btnSelect.Text = "Add to Cart";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(490, 132);
            label4.Name = "label4";
            label4.Size = new Size(373, 31);
            label4.TabIndex = 10;
            label4.Text = "Ready to give your book a new life?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 221);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 11;
            label5.Text = "Book Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 266);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 12;
            label6.Text = "Author:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 318);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 13;
            label7.Text = "Genre";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(559, 259);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 14;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(564, 311);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(610, 169);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 16;
            // 
            // rtbAddBook
            // 
            rtbAddBook.Location = new Point(389, 84);
            rtbAddBook.Name = "rtbAddBook";
            rtbAddBook.Size = new Size(549, 397);
            rtbAddBook.TabIndex = 9;
            rtbAddBook.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(435, 373);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 17;
            label9.Text = "Store Credit:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(564, 366);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 18;
            txtPrice.Text = "2.00";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(726, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 19;
            btnAdd.Text = " Add New Book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(559, 214);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(125, 27);
            txtBookName.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(500, 169);
            label11.Name = "label11";
            label11.Size = new Size(281, 20);
            label11.TabIndex = 29;
            label11.Text = "*earn store credit towards book purchase";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(474, 632);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(323, 46);
            btnCalculate.TabIndex = 30;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(382, 484);
            label10.Name = "label10";
            label10.Size = new Size(144, 20);
            label10.TabIndex = 40;
            label10.Text = "Books To Purchase:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(717, 487);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 41;
            label12.Text = "Credit:";
            // 
            // lblBookCart
            // 
            lblBookCart.AutoSize = true;
            lblBookCart.Location = new Point(406, 506);
            lblBookCart.Name = "lblBookCart";
            lblBookCart.Size = new Size(0, 20);
            lblBookCart.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 705);
            Controls.Add(lblBookCart);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(btnCalculate);
            Controls.Add(label11);
            Controls.Add(txtBookName);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rtbAddBook);
            Controls.Add(btnSelect);
           // Controls.Add(btnSearch);
            //Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboBookSelection);
            Controls.Add(cboGenre);
            Controls.Add(pbBook);
            Name = "Form1";
            Text = "Boundless Escape Bookstore";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBook;
        private ComboBox cboGenre;
        private ComboBox cboBookSelection;
        private Label label1;
        private Label label2;
        private Label label3;
        //private TextBox txtSearch;
        //private Button btnSearch;
        private Button btnSelect;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private Label label8;
        private RichTextBox rtbAddBook;
        private Label label9;
        private TextBox txtPrice;
        private Button btnAdd;
        private TextBox txtBookName;
        private Label label11;
        private Button btnCalculate;
        private Label label10;
        private Label label12;
        private Label lblBookCart;
    }
}
