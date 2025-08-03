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
            this.cboHeroes = new System.Windows.Forms.ComboBox();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.lblSuperPower = new System.Windows.Forms.Label();
            this.lblBiography = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbHero = new System.Windows.Forms.PictureBox();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHeroes
            // 
            this.cboHeroes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeroes.FormattingEnabled = true;
            this.cboHeroes.Location = new System.Drawing.Point(36, 27);
            this.cboHeroes.Name = "cboHeroes";
            this.cboHeroes.Size = new System.Drawing.Size(288, 24);
            this.cboHeroes.TabIndex = 0;
            this.cboHeroes.SelectedIndexChanged += new System.EventHandler(this.cboHeroes_SelectedIndexChanged);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.Location = new System.Drawing.Point(140, 128);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(0, 18);
            this.lblLikes.TabIndex = 1;
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDislikes.Location = new System.Drawing.Point(140, 216);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(0, 18);
            this.lblDislikes.TabIndex = 2;
            // 
            // lblSuperPower
            // 
            this.lblSuperPower.AutoSize = true;
            this.lblSuperPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperPower.Location = new System.Drawing.Point(140, 289);
            this.lblSuperPower.Name = "lblSuperPower";
            this.lblSuperPower.Size = new System.Drawing.Size(0, 18);
            this.lblSuperPower.TabIndex = 3;
            // 
            // lblBiography
            // 
            this.lblBiography.AutoSize = true;
            this.lblBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiography.Location = new System.Drawing.Point(35, 425);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(0, 22);
            this.lblBiography.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 32);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // pbHero
            // 
            this.pbHero.Location = new System.Drawing.Point(523, 27);
            this.pbHero.Name = "pbHero";
            this.pbHero.Size = new System.Drawing.Size(353, 520);
            this.pbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHero.TabIndex = 6;
            this.pbHero.TabStop = false;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(34, 683);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(0, 20);
            this.lblLink.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Likes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dislikes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Super Power:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Biography:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 727);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.pbHero);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBiography);
            this.Controls.Add(this.lblSuperPower);
            this.Controls.Add(this.lblDislikes);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.cboHeroes);
            this.Name = "Form1";
            this.Text = "Super Hero Database";
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHeroes;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblSuperPower;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbHero;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

