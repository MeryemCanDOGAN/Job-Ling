
namespace JobLing
{
    partial class frmEmpRegister
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEmployeeBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployeeCity = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.cmbEmployeeCountry = new System.Windows.Forms.ComboBox();
            this.lblCompanySector = new System.Windows.Forms.Label();
            this.lblEmployeeCountry = new System.Windows.Forms.Label();
            this.tBoxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblEmployeeCity = new System.Windows.Forms.Label();
            this.tBoxEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.tBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.lblEmployeePassword = new System.Windows.Forms.Label();
            this.tBoxEmployeePasswordAgain = new System.Windows.Forms.TextBox();
            this.lblEmployeePasswordAgain = new System.Windows.Forms.Label();
            this.tBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(547, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEmployeeBirthday);
            this.groupBox1.Controls.Add(this.cmbEmployeeCity);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Controls.Add(this.lblEmployeeSurname);
            this.groupBox1.Controls.Add(this.cmbEmployeeCountry);
            this.groupBox1.Controls.Add(this.lblCompanySector);
            this.groupBox1.Controls.Add(this.lblEmployeeCountry);
            this.groupBox1.Controls.Add(this.tBoxEmployeeSurname);
            this.groupBox1.Controls.Add(this.lblEmployeeCity);
            this.groupBox1.Controls.Add(this.tBoxEmployeeEmail);
            this.groupBox1.Controls.Add(this.lblEmployeeEmail);
            this.groupBox1.Controls.Add(this.tBoxEmployeePassword);
            this.groupBox1.Controls.Add(this.lblEmployeePassword);
            this.groupBox1.Controls.Add(this.tBoxEmployeePasswordAgain);
            this.groupBox1.Controls.Add(this.lblEmployeePasswordAgain);
            this.groupBox1.Controls.Add(this.tBoxEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(101, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 316);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // dtpEmployeeBirthday
            // 
            this.dtpEmployeeBirthday.Location = new System.Drawing.Point(134, 89);
            this.dtpEmployeeBirthday.Name = "dtpEmployeeBirthday";
            this.dtpEmployeeBirthday.Size = new System.Drawing.Size(227, 20);
            this.dtpEmployeeBirthday.TabIndex = 23;
            // 
            // cmbEmployeeCity
            // 
            this.cmbEmployeeCity.FormattingEnabled = true;
            this.cmbEmployeeCity.Location = new System.Drawing.Point(134, 161);
            this.cmbEmployeeCity.Name = "cmbEmployeeCity";
            this.cmbEmployeeCity.Size = new System.Drawing.Size(227, 21);
            this.cmbEmployeeCity.TabIndex = 22;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(37, 33);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(28, 13);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Text = "Adı :";
            this.lblEmployeeName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(37, 64);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(43, 13);
            this.lblEmployeeSurname.TabIndex = 6;
            this.lblEmployeeSurname.Text = "Soyad :";
            // 
            // cmbEmployeeCountry
            // 
            this.cmbEmployeeCountry.FormattingEnabled = true;
            this.cmbEmployeeCountry.Location = new System.Drawing.Point(134, 123);
            this.cmbEmployeeCountry.Name = "cmbEmployeeCountry";
            this.cmbEmployeeCountry.Size = new System.Drawing.Size(227, 21);
            this.cmbEmployeeCountry.TabIndex = 21;
            // 
            // lblCompanySector
            // 
            this.lblCompanySector.AutoSize = true;
            this.lblCompanySector.Location = new System.Drawing.Point(37, 97);
            this.lblCompanySector.Name = "lblCompanySector";
            this.lblCompanySector.Size = new System.Drawing.Size(76, 13);
            this.lblCompanySector.TabIndex = 7;
            this.lblCompanySector.Text = "Doğum Tarihi :";
            // 
            // lblEmployeeCountry
            // 
            this.lblEmployeeCountry.AutoSize = true;
            this.lblEmployeeCountry.Location = new System.Drawing.Point(37, 132);
            this.lblEmployeeCountry.Name = "lblEmployeeCountry";
            this.lblEmployeeCountry.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeCountry.TabIndex = 8;
            this.lblEmployeeCountry.Text = "Ülke :";
            // 
            // tBoxEmployeeSurname
            // 
            this.tBoxEmployeeSurname.Location = new System.Drawing.Point(134, 61);
            this.tBoxEmployeeSurname.Name = "tBoxEmployeeSurname";
            this.tBoxEmployeeSurname.Size = new System.Drawing.Size(227, 20);
            this.tBoxEmployeeSurname.TabIndex = 19;
            // 
            // lblEmployeeCity
            // 
            this.lblEmployeeCity.AutoSize = true;
            this.lblEmployeeCity.Location = new System.Drawing.Point(37, 170);
            this.lblEmployeeCity.Name = "lblEmployeeCity";
            this.lblEmployeeCity.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeCity.TabIndex = 9;
            this.lblEmployeeCity.Text = "Şehir :";
            // 
            // tBoxEmployeeEmail
            // 
            this.tBoxEmployeeEmail.Location = new System.Drawing.Point(134, 199);
            this.tBoxEmployeeEmail.Name = "tBoxEmployeeEmail";
            this.tBoxEmployeeEmail.Size = new System.Drawing.Size(227, 20);
            this.tBoxEmployeeEmail.TabIndex = 17;
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(37, 206);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmployeeEmail.TabIndex = 11;
            this.lblEmployeeEmail.Text = "E-Mail :";
            // 
            // tBoxEmployeePassword
            // 
            this.tBoxEmployeePassword.Location = new System.Drawing.Point(134, 234);
            this.tBoxEmployeePassword.Name = "tBoxEmployeePassword";
            this.tBoxEmployeePassword.PasswordChar = '*';
            this.tBoxEmployeePassword.Size = new System.Drawing.Size(227, 20);
            this.tBoxEmployeePassword.TabIndex = 16;
            // 
            // lblEmployeePassword
            // 
            this.lblEmployeePassword.AutoSize = true;
            this.lblEmployeePassword.Location = new System.Drawing.Point(37, 237);
            this.lblEmployeePassword.Name = "lblEmployeePassword";
            this.lblEmployeePassword.Size = new System.Drawing.Size(34, 13);
            this.lblEmployeePassword.TabIndex = 12;
            this.lblEmployeePassword.Text = "Şifre :";
            // 
            // tBoxEmployeePasswordAgain
            // 
            this.tBoxEmployeePasswordAgain.Location = new System.Drawing.Point(134, 262);
            this.tBoxEmployeePasswordAgain.Name = "tBoxEmployeePasswordAgain";
            this.tBoxEmployeePasswordAgain.PasswordChar = '*';
            this.tBoxEmployeePasswordAgain.Size = new System.Drawing.Size(227, 20);
            this.tBoxEmployeePasswordAgain.TabIndex = 15;
            // 
            // lblEmployeePasswordAgain
            // 
            this.lblEmployeePasswordAgain.AutoSize = true;
            this.lblEmployeePasswordAgain.Location = new System.Drawing.Point(37, 269);
            this.lblEmployeePasswordAgain.Name = "lblEmployeePasswordAgain";
            this.lblEmployeePasswordAgain.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeePasswordAgain.TabIndex = 13;
            this.lblEmployeePasswordAgain.Text = "Şifre (Tekrar) :";
            // 
            // tBoxEmployeeName
            // 
            this.tBoxEmployeeName.Location = new System.Drawing.Point(134, 30);
            this.tBoxEmployeeName.Name = "tBoxEmployeeName";
            this.tBoxEmployeeName.Size = new System.Drawing.Size(227, 20);
            this.tBoxEmployeeName.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(513, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(422, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEmployeeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeRegister";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEmployeeCity;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.ComboBox cmbEmployeeCountry;
        private System.Windows.Forms.Label lblCompanySector;
        private System.Windows.Forms.Label lblEmployeeCountry;
        private System.Windows.Forms.TextBox tBoxEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeCity;
        private System.Windows.Forms.TextBox tBoxEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.TextBox tBoxEmployeePassword;
        private System.Windows.Forms.Label lblEmployeePassword;
        private System.Windows.Forms.TextBox tBoxEmployeePasswordAgain;
        private System.Windows.Forms.Label lblEmployeePasswordAgain;
        private System.Windows.Forms.TextBox tBoxEmployeeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthday;
    }
}