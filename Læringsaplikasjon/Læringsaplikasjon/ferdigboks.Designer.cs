namespace Læringsaplikasjon
{
    partial class ferdigboks
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
            this.btnIgjen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFerdig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIgjen
            // 
            this.btnIgjen.Location = new System.Drawing.Point(297, 714);
            this.btnIgjen.Name = "btnIgjen";
            this.btnIgjen.Size = new System.Drawing.Size(312, 92);
            this.btnIgjen.TabIndex = 1;
            this.btnIgjen.Text = "Prøv igjen";
            this.btnIgjen.UseVisualStyleBackColor = true;
            this.btnIgjen.Click += new System.EventHandler(this.btnIgjen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnFerdig
            // 
            this.btnFerdig.Location = new System.Drawing.Point(615, 714);
            this.btnFerdig.Name = "btnFerdig";
            this.btnFerdig.Size = new System.Drawing.Size(312, 92);
            this.btnFerdig.TabIndex = 3;
            this.btnFerdig.Text = "Ferdig";
            this.btnFerdig.UseVisualStyleBackColor = true;
            this.btnFerdig.Click += new System.EventHandler(this.btnFerdig_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(297, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ferdigboks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 860);
            this.Controls.Add(this.btnFerdig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIgjen);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ferdigboks";
            this.Text = "ferdigboks";
            this.Load += new System.EventHandler(this.ferdigboks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIgjen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFerdig;
    }
}