namespace BirKelimeBirIslem1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIslemOyunu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 216);
            this.label1.TabIndex = 8;
            this.label1.Text = "  MERHABA\r\nBİR KELİME BİR\r\nİŞLEM OYUNUNA\r\nHOŞGELDİNİZ\r\n\r\n\r\n";
            // 
            // BtnIslemOyunu
            // 
            this.BtnIslemOyunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIslemOyunu.Location = new System.Drawing.Point(329, 228);
            this.BtnIslemOyunu.Name = "BtnIslemOyunu";
            this.BtnIslemOyunu.Size = new System.Drawing.Size(151, 108);
            this.BtnIslemOyunu.TabIndex = 7;
            this.BtnIslemOyunu.Text = "Bir İşlem Oyunu";
            this.BtnIslemOyunu.UseVisualStyleBackColor = true;
            this.BtnIslemOyunu.Click += new System.EventHandler(this.BtnIslemOyunu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(32, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 108);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bir Kelime Oyunu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(527, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIslemOyunu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIslemOyunu;
        private System.Windows.Forms.Button button1;
    }
}

