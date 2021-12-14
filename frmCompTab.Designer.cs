
namespace JobLing
{
    partial class frmCompTab
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
            this.tabCtlCompany = new System.Windows.Forms.TabControl();
            this.tabCompProfile = new System.Windows.Forms.TabPage();
            this.tabCompAdv = new System.Windows.Forms.TabPage();
            this.tabCompApp = new System.Windows.Forms.TabPage();
            this.tabCompNAdv = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCompanyCity = new System.Windows.Forms.ComboBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.cmbCompanyCountry = new System.Windows.Forms.ComboBox();
            this.lblCompanySector = new System.Windows.Forms.Label();
            this.cmbCompanySector = new System.Windows.Forms.ComboBox();
            this.lblCompanyCountry = new System.Windows.Forms.Label();
            this.tBoxCompanyAdress = new System.Windows.Forms.TextBox();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.tBoxCompanyEmpCount = new System.Windows.Forms.TextBox();
            this.lblCompanyEmployee = new System.Windows.Forms.Label();
            this.tBoxCompanyEmail = new System.Windows.Forms.TextBox();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.tBoxCompanyName = new System.Windows.Forms.TextBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.linkNPassword = new System.Windows.Forms.LinkLabel();
            this.linkCreateField = new System.Windows.Forms.LinkLabel();
            this.btnCompUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxCompAdvCountry = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvCity = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvPosNum = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvPos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxCompAdvWork = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvLang = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvEdu = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvDep = new System.Windows.Forms.ComboBox();
            this.cBoxCompAdvCont = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tBoxAdvDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabCtlCompany.SuspendLayout();
            this.tabCompProfile.SuspendLayout();
            this.tabCompAdv.SuspendLayout();
            this.tabCompApp.SuspendLayout();
            this.tabCompNAdv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(831, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabCtlCompany
            // 
            this.tabCtlCompany.Controls.Add(this.tabCompProfile);
            this.tabCtlCompany.Controls.Add(this.tabCompAdv);
            this.tabCtlCompany.Controls.Add(this.tabCompApp);
            this.tabCtlCompany.Controls.Add(this.tabCompNAdv);
            this.tabCtlCompany.Location = new System.Drawing.Point(12, 48);
            this.tabCtlCompany.Name = "tabCtlCompany";
            this.tabCtlCompany.SelectedIndex = 0;
            this.tabCtlCompany.Size = new System.Drawing.Size(860, 392);
            this.tabCtlCompany.TabIndex = 6;
            // 
            // tabCompProfile
            // 
            this.tabCompProfile.Controls.Add(this.btnCompUpdate);
            this.tabCompProfile.Controls.Add(this.btnPicture);
            this.tabCompProfile.Controls.Add(this.pictureBoxLogo);
            this.tabCompProfile.Controls.Add(this.groupBox1);
            this.tabCompProfile.Controls.Add(this.lblLogo);
            this.tabCompProfile.Location = new System.Drawing.Point(4, 22);
            this.tabCompProfile.Name = "tabCompProfile";
            this.tabCompProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompProfile.Size = new System.Drawing.Size(852, 366);
            this.tabCompProfile.TabIndex = 0;
            this.tabCompProfile.Text = "Profil";
            this.tabCompProfile.UseVisualStyleBackColor = true;
            // 
            // tabCompAdv
            // 
            this.tabCompAdv.Controls.Add(this.checkBox2);
            this.tabCompAdv.Controls.Add(this.cBox);
            this.tabCompAdv.Controls.Add(this.dataGridView1);
            this.tabCompAdv.Location = new System.Drawing.Point(4, 22);
            this.tabCompAdv.Name = "tabCompAdv";
            this.tabCompAdv.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompAdv.Size = new System.Drawing.Size(852, 366);
            this.tabCompAdv.TabIndex = 1;
            this.tabCompAdv.Text = "İş İlanları";
            this.tabCompAdv.UseVisualStyleBackColor = true;
            // 
            // tabCompApp
            // 
            this.tabCompApp.Controls.Add(this.checkBox1);
            this.tabCompApp.Controls.Add(this.dataGridView2);
            this.tabCompApp.Location = new System.Drawing.Point(4, 22);
            this.tabCompApp.Name = "tabCompApp";
            this.tabCompApp.Size = new System.Drawing.Size(852, 366);
            this.tabCompApp.TabIndex = 2;
            this.tabCompApp.Text = "Başvuranlar";
            this.tabCompApp.UseVisualStyleBackColor = true;
            // 
            // tabCompNAdv
            // 
            this.tabCompNAdv.AutoScroll = true;
            this.tabCompNAdv.Controls.Add(this.groupBox2);
            this.tabCompNAdv.Controls.Add(this.btnSave);
            this.tabCompNAdv.Controls.Add(this.btnBack);
            this.tabCompNAdv.Controls.Add(this.btnClear);
            this.tabCompNAdv.Controls.Add(this.tBoxAdvDesc);
            this.tabCompNAdv.Controls.Add(this.label10);
            this.tabCompNAdv.Location = new System.Drawing.Point(4, 22);
            this.tabCompNAdv.Name = "tabCompNAdv";
            this.tabCompNAdv.Size = new System.Drawing.Size(852, 366);
            this.tabCompNAdv.TabIndex = 3;
            this.tabCompNAdv.Text = "İlan Oluştur";
            this.tabCompNAdv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkCreateField);
            this.groupBox1.Controls.Add(this.cmbCompanyCity);
            this.groupBox1.Controls.Add(this.linkNPassword);
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
            this.groupBox1.Controls.Add(this.tBoxCompanyName);
            this.groupBox1.Location = new System.Drawing.Point(32, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 335);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // cmbCompanyCity
            // 
            this.cmbCompanyCity.FormattingEnabled = true;
            this.cmbCompanyCity.Location = new System.Drawing.Point(134, 161);
            this.cmbCompanyCity.Name = "cmbCompanyCity";
            this.cmbCompanyCity.Size = new System.Drawing.Size(227, 21);
            this.cmbCompanyCity.TabIndex = 22;
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
            // cmbCompanyCountry
            // 
            this.cmbCompanyCountry.FormattingEnabled = true;
            this.cmbCompanyCountry.Location = new System.Drawing.Point(134, 123);
            this.cmbCompanyCountry.Name = "cmbCompanyCountry";
            this.cmbCompanyCountry.Size = new System.Drawing.Size(227, 21);
            this.cmbCompanyCountry.TabIndex = 21;
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
            // cmbCompanySector
            // 
            this.cmbCompanySector.FormattingEnabled = true;
            this.cmbCompanySector.Location = new System.Drawing.Point(134, 88);
            this.cmbCompanySector.Name = "cmbCompanySector";
            this.cmbCompanySector.Size = new System.Drawing.Size(227, 21);
            this.cmbCompanySector.TabIndex = 20;
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
            // tBoxCompanyAdress
            // 
            this.tBoxCompanyAdress.Location = new System.Drawing.Point(134, 61);
            this.tBoxCompanyAdress.Name = "tBoxCompanyAdress";
            this.tBoxCompanyAdress.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyAdress.TabIndex = 19;
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
            // tBoxCompanyEmpCount
            // 
            this.tBoxCompanyEmpCount.Location = new System.Drawing.Point(134, 198);
            this.tBoxCompanyEmpCount.Name = "tBoxCompanyEmpCount";
            this.tBoxCompanyEmpCount.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyEmpCount.TabIndex = 18;
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
            // tBoxCompanyEmail
            // 
            this.tBoxCompanyEmail.Location = new System.Drawing.Point(134, 234);
            this.tBoxCompanyEmail.Name = "tBoxCompanyEmail";
            this.tBoxCompanyEmail.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyEmail.TabIndex = 17;
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
            // tBoxCompanyName
            // 
            this.tBoxCompanyName.Location = new System.Drawing.Point(134, 30);
            this.tBoxCompanyName.Name = "tBoxCompanyName";
            this.tBoxCompanyName.Size = new System.Drawing.Size(227, 20);
            this.tBoxCompanyName.TabIndex = 14;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(723, 181);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(78, 23);
            this.btnPicture.TabIndex = 30;
            this.btnPicture.Text = "Resimi Seç";
            this.btnPicture.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Location = new System.Drawing.Point(665, 32);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(136, 143);
            this.pictureBoxLogo.TabIndex = 29;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(662, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 28;
            this.lblLogo.Text = "Logo";
            // 
            // linkNPassword
            // 
            this.linkNPassword.AutoSize = true;
            this.linkNPassword.Location = new System.Drawing.Point(37, 299);
            this.linkNPassword.Name = "linkNPassword";
            this.linkNPassword.Size = new System.Drawing.Size(60, 13);
            this.linkNPassword.TabIndex = 31;
            this.linkNPassword.TabStop = true;
            this.linkNPassword.Text = "Şifre Yenile";
            this.linkNPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNPassword_LinkClicked);
            // 
            // linkCreateField
            // 
            this.linkCreateField.AutoSize = true;
            this.linkCreateField.Location = new System.Drawing.Point(306, 299);
            this.linkCreateField.Name = "linkCreateField";
            this.linkCreateField.Size = new System.Drawing.Size(64, 13);
            this.linkCreateField.TabIndex = 32;
            this.linkCreateField.TabStop = true;
            this.linkCreateField.Text = "Alan Oluştur";
            // 
            // btnCompUpdate
            // 
            this.btnCompUpdate.Location = new System.Drawing.Point(695, 307);
            this.btnCompUpdate.Name = "btnCompUpdate";
            this.btnCompUpdate.Size = new System.Drawing.Size(106, 36);
            this.btnCompUpdate.TabIndex = 31;
            this.btnCompUpdate.Text = "Güncelle";
            this.btnCompUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // cBox
            // 
            this.cBox.AutoSize = true;
            this.cBox.Location = new System.Drawing.Point(652, 6);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(168, 17);
            this.cBox.TabIndex = 1;
            this.cBox.Text = "Başlangıç Tarihine Göre Sırala";
            this.cBox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(652, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Bitiş Tarihine Göre Sırala";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(840, 296);
            this.dataGridView2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(680, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Başvuru tarihine göre sırala";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxCompAdvCountry);
            this.groupBox2.Controls.Add(this.cBoxCompAdvCity);
            this.groupBox2.Controls.Add(this.cBoxCompAdvPosNum);
            this.groupBox2.Controls.Add(this.cBoxCompAdvPos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cBoxCompAdvWork);
            this.groupBox2.Controls.Add(this.cBoxCompAdvLang);
            this.groupBox2.Controls.Add(this.cBoxCompAdvEdu);
            this.groupBox2.Controls.Add(this.cBoxCompAdvDep);
            this.groupBox2.Controls.Add(this.cBoxCompAdvCont);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 234);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // cBoxCompAdvCountry
            // 
            this.cBoxCompAdvCountry.FormattingEnabled = true;
            this.cBoxCompAdvCountry.Location = new System.Drawing.Point(593, 202);
            this.cBoxCompAdvCountry.Name = "cBoxCompAdvCountry";
            this.cBoxCompAdvCountry.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvCountry.TabIndex = 35;
            // 
            // cBoxCompAdvCity
            // 
            this.cBoxCompAdvCity.FormattingEnabled = true;
            this.cBoxCompAdvCity.Location = new System.Drawing.Point(593, 143);
            this.cBoxCompAdvCity.Name = "cBoxCompAdvCity";
            this.cBoxCompAdvCity.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvCity.TabIndex = 34;
            // 
            // cBoxCompAdvPosNum
            // 
            this.cBoxCompAdvPosNum.FormattingEnabled = true;
            this.cBoxCompAdvPosNum.Location = new System.Drawing.Point(593, 85);
            this.cBoxCompAdvPosNum.Name = "cBoxCompAdvPosNum";
            this.cBoxCompAdvPosNum.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvPosNum.TabIndex = 33;
            // 
            // cBoxCompAdvPos
            // 
            this.cBoxCompAdvPos.FormattingEnabled = true;
            this.cBoxCompAdvPos.Location = new System.Drawing.Point(593, 41);
            this.cBoxCompAdvPos.Name = "cBoxCompAdvPos";
            this.cBoxCompAdvPos.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvPos.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ülke";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Şehir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Personel Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Pozisyon Seviyesi";
            // 
            // cBoxCompAdvWork
            // 
            this.cBoxCompAdvWork.FormattingEnabled = true;
            this.cBoxCompAdvWork.Location = new System.Drawing.Point(102, 211);
            this.cBoxCompAdvWork.Name = "cBoxCompAdvWork";
            this.cBoxCompAdvWork.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvWork.TabIndex = 27;
            // 
            // cBoxCompAdvLang
            // 
            this.cBoxCompAdvLang.FormattingEnabled = true;
            this.cBoxCompAdvLang.Location = new System.Drawing.Point(102, 166);
            this.cBoxCompAdvLang.Name = "cBoxCompAdvLang";
            this.cBoxCompAdvLang.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvLang.TabIndex = 26;
            // 
            // cBoxCompAdvEdu
            // 
            this.cBoxCompAdvEdu.FormattingEnabled = true;
            this.cBoxCompAdvEdu.Location = new System.Drawing.Point(102, 125);
            this.cBoxCompAdvEdu.Name = "cBoxCompAdvEdu";
            this.cBoxCompAdvEdu.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvEdu.TabIndex = 25;
            // 
            // cBoxCompAdvDep
            // 
            this.cBoxCompAdvDep.FormattingEnabled = true;
            this.cBoxCompAdvDep.Location = new System.Drawing.Point(102, 82);
            this.cBoxCompAdvDep.Name = "cBoxCompAdvDep";
            this.cBoxCompAdvDep.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvDep.TabIndex = 24;
            // 
            // cBoxCompAdvCont
            // 
            this.cBoxCompAdvCont.FormattingEnabled = true;
            this.cBoxCompAdvCont.Location = new System.Drawing.Point(102, 41);
            this.cBoxCompAdvCont.Name = "cBoxCompAdvCont";
            this.cBoxCompAdvCont.Size = new System.Drawing.Size(121, 21);
            this.cBoxCompAdvCont.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Çalışma Şekli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Yabancı Dil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Eğitim Seviyesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Departman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tecrübe";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(642, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(549, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tBoxAdvDesc
            // 
            this.tBoxAdvDesc.Location = new System.Drawing.Point(6, 271);
            this.tBoxAdvDesc.Multiline = true;
            this.tBoxAdvDesc.Name = "tBoxAdvDesc";
            this.tBoxAdvDesc.Size = new System.Drawing.Size(822, 167);
            this.tBoxAdvDesc.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "İlan Detayı";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmCompanyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabCtlCompany);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanyTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompanyTab";
            this.tabCtlCompany.ResumeLayout(false);
            this.tabCompProfile.ResumeLayout(false);
            this.tabCompProfile.PerformLayout();
            this.tabCompAdv.ResumeLayout(false);
            this.tabCompAdv.PerformLayout();
            this.tabCompApp.ResumeLayout(false);
            this.tabCompApp.PerformLayout();
            this.tabCompNAdv.ResumeLayout(false);
            this.tabCompNAdv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabCtlCompany;
        private System.Windows.Forms.TabPage tabCompProfile;
        private System.Windows.Forms.TabPage tabCompAdv;
        private System.Windows.Forms.TabPage tabCompApp;
        private System.Windows.Forms.TabPage tabCompNAdv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCompanyCity;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.ComboBox cmbCompanyCountry;
        private System.Windows.Forms.Label lblCompanySector;
        private System.Windows.Forms.ComboBox cmbCompanySector;
        private System.Windows.Forms.Label lblCompanyCountry;
        private System.Windows.Forms.TextBox tBoxCompanyAdress;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.TextBox tBoxCompanyEmpCount;
        private System.Windows.Forms.Label lblCompanyEmployee;
        private System.Windows.Forms.TextBox tBoxCompanyEmail;
        private System.Windows.Forms.Label lblCompanyEmail;
        private System.Windows.Forms.TextBox tBoxCompanyName;
        private System.Windows.Forms.Button btnCompUpdate;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkCreateField;
        private System.Windows.Forms.LinkLabel linkNPassword;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBoxCompAdvCountry;
        private System.Windows.Forms.ComboBox cBoxCompAdvCity;
        private System.Windows.Forms.ComboBox cBoxCompAdvPosNum;
        private System.Windows.Forms.ComboBox cBoxCompAdvPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxCompAdvWork;
        private System.Windows.Forms.ComboBox cBoxCompAdvLang;
        private System.Windows.Forms.ComboBox cBoxCompAdvEdu;
        private System.Windows.Forms.ComboBox cBoxCompAdvDep;
        private System.Windows.Forms.ComboBox cBoxCompAdvCont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tBoxAdvDesc;
        private System.Windows.Forms.Label label10;
    }
}