namespace BirKelimeBirIslem1
{
    partial class IslemKismi
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
            this.IslemElle = new System.Windows.Forms.Button();
            this.IslemRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IslemElle
            // 
            this.IslemElle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IslemElle.Location = new System.Drawing.Point(326, 129);
            this.IslemElle.Name = "IslemElle";
            this.IslemElle.Size = new System.Drawing.Size(163, 138);
            this.IslemElle.TabIndex = 7;
            this.IslemElle.Text = "SAYI GİR";
            this.IslemElle.UseVisualStyleBackColor = true;
            // 
            // IslemRandom
            // 
            this.IslemRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IslemRandom.Location = new System.Drawing.Point(84, 129);
            this.IslemRandom.Name = "IslemRandom";
            this.IslemRandom.Size = new System.Drawing.Size(159, 138);
            this.IslemRandom.TabIndex = 6;
            this.IslemRandom.Text = "RANDOM";
            this.IslemRandom.UseVisualStyleBackColor = true;
            this.IslemRandom.Click += new System.EventHandler(this.IslemRandom_Click);
            // 
            // IslemKismi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(589, 379);
            this.Controls.Add(this.IslemElle);
            this.Controls.Add(this.IslemRandom);
            this.Name = "IslemKismi";
            this.Text = "IslemKismi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IslemElle;
        private System.Windows.Forms.Button IslemRandom;
    }
}