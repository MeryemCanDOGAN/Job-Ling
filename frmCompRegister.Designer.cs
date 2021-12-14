
namespace JobLing
{
    partial class frmCompRegister
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanySector = new System.Windows.Forms.Label();
            this.lblCompanyCountry = new System.Windows.Forms.Label();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.lblCompanyEmployee = new System.Windows.Forms.Label();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.lblCompanyPassword = new System.Windows.Forms.Label();
            this.lblCompanyPasswordAgain = new System.Windows.Forms.Label();
            this.tBoxCompanyName = new System.Windows.Forms.TextBox();
            this.tBoxCompanyPasswordAgain = new System.Windows.Forms.TextBox();
            this.tBoxCompanyPassword = new System.Windows.Forms.TextBox();
            this.tBoxCompanyEmail = new System.Windows.Forms.TextBox();
            this.tBoxCompanyEmpCount = new System.Windows.Forms.TextBox();
            this.tBoxCompanyAdress = new System.Windows.Forms.TextBox();
            this.cmbCompanySector = new System.Windows.Forms.ComboBox();
            this.cmbCompanyCountry = new System.Windows.Forms.ComboBox();
            this.cmbCompanyCity = new System.Windows.Forms.ComboBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(747, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(37, 33);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(58, 13);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Şirket Adı :";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(37, 64);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(72, 13);
            this.lblCompanyAddress.TabIndex = 6;
            this.lblCompanyAddress.Text = "Şirket Adresi :";
            // 
            // lblCompanySector
            // 
            this.lblCompanySector.AutoSize = true;
            this.lblCompanySector.Location = new System.Drawing.Point(37, 97);
            this.lblCompanySector.Name = "lblCompanySector";
            this.lblCompanySector.Size = new System.Drawing.Size(44, 13);
            this.lblCompanySector.TabIndex = 7;
            this.lblCompanySector.Text = "Sektör :";
            // 
            // lblCompanyCountry
            // 
            this.lblCompanyCountry.AutoSize = true;
            this.lblCompanyCountry.Location = new System.Drawing.Point(37, 132);
            this.lblCompanyCountry.Name = "lblCompanyCountry";
            this.lblCompanyCountry.Size = new System.Drawing.Size(35, 13);
            this.lblCompanyCountry.TabIndex = 8;
            this.lblCompanyCountry.Text = "Ülke :";
            // 
            // lblCompanyCity
            // 
            this.lblCompanyCity.AutoSize = true;
            this.lblCompanyCity.Location = new System.Drawing.Point(37, 170);
            this.lblCompanyCity.Name = "lblCompanyCity";
            this.lblCompanyCity.Size = new System.Drawing.Size(37, 13);
            this.lblCompanyCity.TabIndex = 9;
            this.lblCompanyCity.Text = "Şehir :";
            // 
            // lblCompanyEmployee
            // 
            this.lblCompanyEmployee.AutoSize = true;
            this.lblCompanyEmployee.Location = new System.Drawing.Point(37, 205);
            this.lblCompanyEmployee.Name = "lblCompanyEmployee";
            this.lblCompanyEmployee.Size = new System.Drawing.Size(77, 13);
            this.lblCompanyEmployee.TabIndex = 10;
            this.lblCompanyEmployee.Text = "Çalışan Sayısı :";
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.AutoSize = true;
            this.lblCompanyEmail.Location = new System.Drawing.Point(37, 241);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(42, 13);
            this.lblCompanyEmail.TabIndex = 11;
            this.lblCompanyEmail.Text = "E-Mail :";
            // 
            // lblCompanyPassword
            // 
            this.lblCompanyPassword.AutoSize = true;
            this.lblCompanyPassword.Location = new System.Drawing.Point(37, 272);
            this.lblCompanyPassword.Name = "lblCompanyPassword";
            this.lblCompanyPassword.Size = new System.Drawing.Size(34, 13);
            this.lblCompanyPassword.TabIndex = 12;
            this.lblCompanyPassword.Text = "Şifre :";
            // 
            // lblCompanyPasswordAgain
            // 
            this.lblCompanyPasswordAgain.AutoSize = true;
            this.lblCompanyPasswordAgain.Location = new System.Drawing.Point(37, 304);
            this.lblCompanyPasswordAgain.Name = "lblCompanyPasswordAgain";
            this.lblCompanyPasswordAgain.Size = new System.Drawing.Size(74, 13);
            this.lblCompanyPasswordAgain.TabIndex = 13;
            this.lblCompanyPasswordAgain.Text = "Şifre (Tekrar) :";
            // 
            // tBoxCompanyName
            // 
            this.tBoxCompanyName.Location = new System.Drawing.Point(134, 30);
            this.tBoxCompanyName.Name = "tBoxCompanyName";
            this.tBoxCompanyName.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyName.TabIndex = 14;
            // 
            // tBoxCompanyPasswordAgain
            // 
            this.tBoxCompanyPasswordAgain.Location = new System.Drawing.Point(134, 297);
            this.tBoxCompanyPasswordAgain.Name = "tBoxCompanyPasswordAgain";
            this.tBoxCompanyPasswordAgain.PasswordChar = '*';
            this.tBoxCompanyPasswordAgain.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyPasswordAgain.TabIndex = 15;
            // 
            // tBoxCompanyPassword
            // 
            this.tBoxCompanyPassword.Location = new System.Drawing.Point(134, 269);
            this.tBoxCompanyPassword.Name = "tBoxCompanyPassword";
            this.tBoxCompanyPassword.PasswordChar = '*';
            this.tBoxCompanyPassword.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyPassword.TabIndex = 16;
            // 
            // tBoxCompanyEmail
            // 
            this.tBoxCompanyEmail.Location = new System.Drawing.Point(134, 234);
            this.tBoxCompanyEmail.Name = "tBoxCompanyEmail";
            this.tBoxCompanyEmail.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyEmail.TabIndex = 17;
            // 
            // tBoxCompanyEmpCount
            // 
            this.tBoxCompanyEmpCount.Location = new System.Drawing.Point(134, 198);
            this.tBoxCompanyEmpCount.Name = "tBoxCompanyEmpCount";
            this.tBoxCompanyEmpCount.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyEmpCount.TabIndex = 18;
            // 
            // tBoxCompanyAdress
            // 
            this.tBoxCompanyAdress.Location = new System.Drawing.Point(134, 61);
            this.tBoxCompanyAdress.Name = "tBoxCompanyAdress";
            this.tBoxCompanyAdress.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyAdress.TabIndex = 19;
            // 
            // cmbCompanySector
            // 
            this.cmbCompanySector.FormattingEnabled = true;
            this.cmbCompanySector.Location = new System.Drawing.Point(134, 88);
            this.cmbCompanySector.Name = "cmbCompanySector";
            this.cmbCompanySector.Size = new System.Drawing.Size(227, 21);
            this.cmbCompanySector.TabIndex = 20;
            // 
            // cmbCompanyCountry
            // 
            this.cmbCompanyCountry.FormattingEnabled = true;
            this.cmbCompanyCountry.Location = new System.Drawing.Point(134, 123);
            this.cmbCompanyCountry.Name = "cmbCompanyCountry";
            this.cmbCompanyCountry.Size = new System.Drawing.Size(227, 21);
            this.cmbCompanyCountry.TabIndex = 21;
            // 
            // cmbCompanyCity
            // 
            this.cmbCompanyCity.FormattingEnabled = true;
            this.cmbCompanyCity.Location = new System.Drawing.Point(134, 161);
            this.cmbCompanyCity.Name = "cmbCompanyCity";
            this.cmbCompanyCity.Size = new System.Drawing.Size(227, 21);
            this.cmbCompanyCity.TabIndex = 22;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(60, 45);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 24;
            this.lblLogo.Text = "Logo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCompanyCity);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.lblCompanyAddress);
            this.groupBox1.Controls.Add(this.cmbCompanyCountry);
            this.groupBox1.Controls.Add(this.lblCompanySector);
            this.groupBox1.Controls.Add(this.cmbCompanySector);
            this.groupBox1.Controls.Add(this.lblCompanyCountry);
            this.groupBox1.Controls.Add(this.tBoxCompanyAdress);
            this.groupBox1.Controls.Add(this.lblCompanyCity);
            this.groupBox1.Controls.Add(this.tBoxCompanyEmpCount);
            this.groupBox1.Controls.Add(this.lblCompanyEmployee);
            this.groupBox1.Controls.Add(this.tBoxCompanyEmail);
            this.groupBox1.Controls.Add(this.lblCompanyEmail);
            this.groupBox1.Controls.Add(this.tBoxCompanyPassword);
            this.groupBox1.Controls.Add(this.lblCompanyPassword);
            this.groupBox1.Controls.Add(this.tBoxCompanyPasswordAgain);
            this.groupBox1.Controls.Add(this.lblCompanyPasswordAgain);
            this.groupBox1.Controls.Add(this.tBoxCompanyName);
            this.groupBox1.Location = new System.Drawing.Point(344, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 335);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Location = new System.Drawing.Point(63, 69);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(220, 230);
            this.pictureBoxLogo.TabIndex = 26;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(208, 317);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPicture.TabIndex = 27;
            this.btnPicture.Text = "Resimi Seç";
            this.btnPicture.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(63, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(575, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(666, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmCompanyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanyRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompanyRegister";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanySector;
        private System.Windows.Forms.Label lblCompanyCountry;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.Label lblCompanyEmployee;
        private System.Windows.Forms.Label lblCompanyEmail;
        private System.Windows.Forms.Label lblCompanyPassword;
        private System.Windows.Forms.Label lblCompanyPasswordAgain;
        private System.Windows.Forms.TextBox tBoxCompanyName;
        private System.Windows.Forms.TextBox tBoxCompanyPasswordAgain;
        private System.Windows.Forms.TextBox tBoxCompanyPassword;
        private System.Windows.Forms.TextBox tBoxCompanyEmail;
        private System.Windows.Forms.TextBox tBoxCompanyEmpCount;
        private System.Windows.Forms.TextBox tBoxCompanyAdress;
        private System.Windows.Forms.ComboBox cmbCompanySector;
        private System.Windows.Forms.ComboBox cmbCompanyCountry;
        private System.Windows.Forms.ComboBox cmbCompanyCity;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}