namespace Toplanti_Takip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormGetir = new System.Windows.Forms.Panel();
            this.btn_Toplanti_Olustur = new System.Windows.Forms.Button();
            this.btn_Toplantilari_Listele = new System.Windows.Forms.Button();
            this.btn_Salonlar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_Toplanti_Olustur);
            this.panel1.Controls.Add(this.btn_Toplantilari_Listele);
            this.panel1.Controls.Add(this.btn_Salonlar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 630);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFormGetir
            // 
            this.pnlFormGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormGetir.Location = new System.Drawing.Point(221, 0);
            this.pnlFormGetir.Name = "pnlFormGetir";
            this.pnlFormGetir.Size = new System.Drawing.Size(1036, 630);
            this.pnlFormGetir.TabIndex = 1;
            // 
            // btn_Toplanti_Olustur
            // 
            this.btn_Toplanti_Olustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Toplanti_Olustur.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Toplanti_Olustur.Image = ((System.Drawing.Image)(resources.GetObject("btn_Toplanti_Olustur.Image")));
            this.btn_Toplanti_Olustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Toplanti_Olustur.Location = new System.Drawing.Point(4, 266);
            this.btn_Toplanti_Olustur.Name = "btn_Toplanti_Olustur";
            this.btn_Toplanti_Olustur.Size = new System.Drawing.Size(212, 92);
            this.btn_Toplanti_Olustur.TabIndex = 6;
            this.btn_Toplanti_Olustur.Text = "     Toplantı  \r\n     Oluştur   ";
            this.btn_Toplanti_Olustur.UseVisualStyleBackColor = false;
            this.btn_Toplanti_Olustur.Click += new System.EventHandler(this.btn_Toplanti_Olustur_Click);
            // 
            // btn_Toplantilari_Listele
            // 
            this.btn_Toplantilari_Listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Toplantilari_Listele.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Toplantilari_Listele.Image = ((System.Drawing.Image)(resources.GetObject("btn_Toplantilari_Listele.Image")));
            this.btn_Toplantilari_Listele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Toplantilari_Listele.Location = new System.Drawing.Point(6, 168);
            this.btn_Toplantilari_Listele.Name = "btn_Toplantilari_Listele";
            this.btn_Toplantilari_Listele.Size = new System.Drawing.Size(212, 92);
            this.btn_Toplantilari_Listele.TabIndex = 5;
            this.btn_Toplantilari_Listele.Text = "     Toplantı  \r\n     Listele  \r\n";
            this.btn_Toplantilari_Listele.UseVisualStyleBackColor = false;
            this.btn_Toplantilari_Listele.Click += new System.EventHandler(this.btn_Toplantilari_Listele_Click);
            // 
            // btn_Salonlar
            // 
            this.btn_Salonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Salonlar.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salonlar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salonlar.Image")));
            this.btn_Salonlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salonlar.Location = new System.Drawing.Point(6, 70);
            this.btn_Salonlar.Name = "btn_Salonlar";
            this.btn_Salonlar.Size = new System.Drawing.Size(212, 92);
            this.btn_Salonlar.TabIndex = 4;
            this.btn_Salonlar.Text = "   Salonlar";
            this.btn_Salonlar.UseVisualStyleBackColor = false;
            this.btn_Salonlar.Click += new System.EventHandler(this.btn_Salonlar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 630);
            this.Controls.Add(this.pnlFormGetir);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Toplanti_Olustur;
        private System.Windows.Forms.Button btn_Toplantilari_Listele;
        private System.Windows.Forms.Button btn_Salonlar;
        private System.Windows.Forms.Panel pnlFormGetir;
    }
}