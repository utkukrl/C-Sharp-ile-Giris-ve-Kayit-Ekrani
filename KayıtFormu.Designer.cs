
namespace FinanceTrackerr
{
    partial class KayıtFormu
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
            this.tbxKayitAdi = new System.Windows.Forms.TextBox();
            this.tbxKayitSifre = new System.Windows.Forms.TextBox();
            this.tbxKayitSifreTkr = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.lblKullanciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciSifresi = new System.Windows.Forms.Label();
            this.lblKullaniciSifresiTekrar = new System.Windows.Forms.Label();
            this.lblTelefonNumarası = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnKayittanGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxKayitAdi
            // 
            this.tbxKayitAdi.Location = new System.Drawing.Point(493, 184);
            this.tbxKayitAdi.Name = "tbxKayitAdi";
            this.tbxKayitAdi.Size = new System.Drawing.Size(231, 20);
            this.tbxKayitAdi.TabIndex = 0;
            // 
            // tbxKayitSifre
            // 
            this.tbxKayitSifre.Location = new System.Drawing.Point(493, 210);
            this.tbxKayitSifre.Name = "tbxKayitSifre";
            this.tbxKayitSifre.PasswordChar = '●';
            this.tbxKayitSifre.Size = new System.Drawing.Size(231, 20);
            this.tbxKayitSifre.TabIndex = 1;
            // 
            // tbxKayitSifreTkr
            // 
            this.tbxKayitSifreTkr.Location = new System.Drawing.Point(493, 236);
            this.tbxKayitSifreTkr.Name = "tbxKayitSifreTkr";
            this.tbxKayitSifreTkr.PasswordChar = '●';
            this.tbxKayitSifreTkr.Size = new System.Drawing.Size(231, 20);
            this.tbxKayitSifreTkr.TabIndex = 2;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(493, 272);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(231, 20);
            this.tbxTelefon.TabIndex = 3;
            this.tbxTelefon.Text = "+90";
            // 
            // lblKullanciAdi
            // 
            this.lblKullanciAdi.AutoSize = true;
            this.lblKullanciAdi.Location = new System.Drawing.Point(423, 187);
            this.lblKullanciAdi.Name = "lblKullanciAdi";
            this.lblKullanciAdi.Size = new System.Drawing.Size(64, 13);
            this.lblKullanciAdi.TabIndex = 4;
            this.lblKullanciAdi.Text = "Kullanıcı Adı";
            // 
            // lblKullaniciSifresi
            // 
            this.lblKullaniciSifresi.AutoSize = true;
            this.lblKullaniciSifresi.Location = new System.Drawing.Point(452, 213);
            this.lblKullaniciSifresi.Name = "lblKullaniciSifresi";
            this.lblKullaniciSifresi.Size = new System.Drawing.Size(28, 13);
            this.lblKullaniciSifresi.TabIndex = 5;
            this.lblKullaniciSifresi.Text = "Şifre";
            // 
            // lblKullaniciSifresiTekrar
            // 
            this.lblKullaniciSifresiTekrar.AutoSize = true;
            this.lblKullaniciSifresiTekrar.Location = new System.Drawing.Point(411, 239);
            this.lblKullaniciSifresiTekrar.Name = "lblKullaniciSifresiTekrar";
            this.lblKullaniciSifresiTekrar.Size = new System.Drawing.Size(76, 13);
            this.lblKullaniciSifresiTekrar.TabIndex = 6;
            this.lblKullaniciSifresiTekrar.Text = "Şifre (Yeniden)";
            // 
            // lblTelefonNumarası
            // 
            this.lblTelefonNumarası.AutoSize = true;
            this.lblTelefonNumarası.Location = new System.Drawing.Point(437, 275);
            this.lblTelefonNumarası.Name = "lblTelefonNumarası";
            this.lblTelefonNumarası.Size = new System.Drawing.Size(43, 13);
            this.lblTelefonNumarası.TabIndex = 7;
            this.lblTelefonNumarası.Text = "Telefon";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(561, 130);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(55, 13);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "KAYIT OL";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(649, 310);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.Text = "Kaydol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnKayittanGiris
            // 
            this.btnKayittanGiris.Location = new System.Drawing.Point(112, 368);
            this.btnKayittanGiris.Name = "btnKayittanGiris";
            this.btnKayittanGiris.Size = new System.Drawing.Size(75, 23);
            this.btnKayittanGiris.TabIndex = 10;
            this.btnKayittanGiris.Text = "Giriş Yap";
            this.btnKayittanGiris.UseVisualStyleBackColor = true;
            this.btnKayittanGiris.Click += new System.EventHandler(this.btnKayittanGiris_Click);
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKayittanGiris);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblTelefonNumarası);
            this.Controls.Add(this.lblKullaniciSifresiTekrar);
            this.Controls.Add(this.lblKullaniciSifresi);
            this.Controls.Add(this.lblKullanciAdi);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxKayitSifreTkr);
            this.Controls.Add(this.tbxKayitSifre);
            this.Controls.Add(this.tbxKayitAdi);
            this.Name = "KayıtFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKayitAdi;
        private System.Windows.Forms.TextBox tbxKayitSifre;
        private System.Windows.Forms.TextBox tbxKayitSifreTkr;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Label lblKullanciAdi;
        private System.Windows.Forms.Label lblKullaniciSifresi;
        private System.Windows.Forms.Label lblKullaniciSifresiTekrar;
        private System.Windows.Forms.Label lblTelefonNumarası;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnKayittanGiris;
    }
}