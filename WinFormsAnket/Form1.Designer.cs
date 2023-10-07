namespace WinFormsAnket
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.birthdateDtp = new System.Windows.Forms.DateTimePicker();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.adressTxtb = new System.Windows.Forms.TextBox();
            this.phoneMtbx = new System.Windows.Forms.MaskedTextBox();
            this.specCmb = new System.Windows.Forms.ComboBox();
            this.azeRdb = new System.Windows.Forms.RadioButton();
            this.engRdb = new System.Windows.Forms.RadioButton();
            this.anketTxtb = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblName.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(29, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblSurname.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(28, 142);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(162, 37);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname :";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblBirthDate.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(28, 193);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(195, 37);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Birth Date :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblEmail.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(29, 245);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 37);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblPhoneNumber.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(28, 296);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(125, 37);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone :";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblAdress.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(28, 349);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(133, 37);
            this.lblAdress.TabIndex = 6;
            this.lblAdress.Text = "Adress :";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblLanguage.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(29, 469);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(167, 37);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Language :";
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.lblSpeciality.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeciality.Location = new System.Drawing.Point(27, 403);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(177, 37);
            this.lblSpeciality.TabIndex = 8;
            this.lblSpeciality.Text = "Speciality :";
            // 
            // nameTxtb
            // 
            this.nameTxtb.BackColor = System.Drawing.Color.AliceBlue;
            this.nameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtb.Location = new System.Drawing.Point(169, 93);
            this.nameTxtb.Multiline = true;
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(145, 37);
            this.nameTxtb.TabIndex = 9;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.BackColor = System.Drawing.Color.AliceBlue;
            this.surnameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxtb.Location = new System.Drawing.Point(209, 142);
            this.surnameTxtb.Multiline = true;
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(157, 37);
            this.surnameTxtb.TabIndex = 10;
            // 
            // birthdateDtp
            // 
            this.birthdateDtp.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.birthdateDtp.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.birthdateDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDtp.Location = new System.Drawing.Point(238, 193);
            this.birthdateDtp.Name = "birthdateDtp";
            this.birthdateDtp.Size = new System.Drawing.Size(235, 38);
            this.birthdateDtp.TabIndex = 11;
            // 
            // emailTxtb
            // 
            this.emailTxtb.BackColor = System.Drawing.Color.AliceBlue;
            this.emailTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtb.Location = new System.Drawing.Point(167, 245);
            this.emailTxtb.Multiline = true;
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(239, 37);
            this.emailTxtb.TabIndex = 12;
            // 
            // adressTxtb
            // 
            this.adressTxtb.BackColor = System.Drawing.Color.AliceBlue;
            this.adressTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTxtb.Location = new System.Drawing.Point(186, 350);
            this.adressTxtb.Multiline = true;
            this.adressTxtb.Name = "adressTxtb";
            this.adressTxtb.Size = new System.Drawing.Size(188, 37);
            this.adressTxtb.TabIndex = 13;
            // 
            // phoneMtbx
            // 
            this.phoneMtbx.BackColor = System.Drawing.Color.AliceBlue;
            this.phoneMtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneMtbx.Location = new System.Drawing.Point(171, 296);
            this.phoneMtbx.Mask = "(000)-(00)-000-00-00";
            this.phoneMtbx.Name = "phoneMtbx";
            this.phoneMtbx.Size = new System.Drawing.Size(269, 38);
            this.phoneMtbx.TabIndex = 14;
            // 
            // specCmb
            // 
            this.specCmb.BackColor = System.Drawing.Color.AliceBlue;
            this.specCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specCmb.FormattingEnabled = true;
            this.specCmb.Items.AddRange(new object[] {
            ".Net Dev",
            "IT enginere",
            "C# Dev",
            "Python Junior"});
            this.specCmb.Location = new System.Drawing.Point(231, 403);
            this.specCmb.Name = "specCmb";
            this.specCmb.Size = new System.Drawing.Size(209, 37);
            this.specCmb.TabIndex = 15;
            // 
            // azeRdb
            // 
            this.azeRdb.AutoSize = true;
            this.azeRdb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.azeRdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azeRdb.Location = new System.Drawing.Point(209, 459);
            this.azeRdb.Name = "azeRdb";
            this.azeRdb.Size = new System.Drawing.Size(130, 29);
            this.azeRdb.TabIndex = 16;
            this.azeRdb.TabStop = true;
            this.azeRdb.Text = "Azeribaijan";
            this.azeRdb.UseVisualStyleBackColor = false;
            // 
            // engRdb
            // 
            this.engRdb.AutoSize = true;
            this.engRdb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.engRdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engRdb.Location = new System.Drawing.Point(209, 494);
            this.engRdb.Name = "engRdb";
            this.engRdb.Size = new System.Drawing.Size(101, 29);
            this.engRdb.TabIndex = 17;
            this.engRdb.TabStop = true;
            this.engRdb.Text = "Engilish";
            this.engRdb.UseVisualStyleBackColor = false;
            // 
            // anketTxtb
            // 
            this.anketTxtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.anketTxtb.Font = new System.Drawing.Font("Mongolian Baiti", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anketTxtb.Location = new System.Drawing.Point(-1, 12);
            this.anketTxtb.Multiline = true;
            this.anketTxtb.Name = "anketTxtb";
            this.anketTxtb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.anketTxtb.Size = new System.Drawing.Size(519, 71);
            this.anketTxtb.TabIndex = 18;
            this.anketTxtb.Text = "      A-N-K-E-T";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(148, 547);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 52);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(513, 611);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.anketTxtb);
            this.Controls.Add(this.engRdb);
            this.Controls.Add(this.azeRdb);
            this.Controls.Add(this.specCmb);
            this.Controls.Add(this.phoneMtbx);
            this.Controls.Add(this.adressTxtb);
            this.Controls.Add(this.emailTxtb);
            this.Controls.Add(this.birthdateDtp);
            this.Controls.Add(this.surnameTxtb);
            this.Controls.Add(this.nameTxtb);
            this.Controls.Add(this.lblSpeciality);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.MaximumSize = new System.Drawing.Size(531, 658);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.DateTimePicker birthdateDtp;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.TextBox adressTxtb;
        private System.Windows.Forms.MaskedTextBox phoneMtbx;
        private System.Windows.Forms.ComboBox specCmb;
        private System.Windows.Forms.RadioButton azeRdb;
        private System.Windows.Forms.RadioButton engRdb;
        private System.Windows.Forms.TextBox anketTxtb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button saveBtn;
    }
}

