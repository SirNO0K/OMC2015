namespace OMC2015.View.Tools
{
    partial class frmConfig
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
            this.btnFindServerAccount = new System.Windows.Forms.Button();
            this.txtAccuontPassword = new System.Windows.Forms.TextBox();
            this.txtAccuontUsername = new System.Windows.Forms.TextBox();
            this.txtAccuontDatabase = new System.Windows.Forms.TextBox();
            this.txtAccuontServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFindServerGeneral = new System.Windows.Forms.Button();
            this.txtSystemPassword = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSystemUsername = new System.Windows.Forms.TextBox();
            this.txtSystemDatabase = new System.Windows.Forms.TextBox();
            this.txtSystemServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnFindPicturePath = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindServerAccount
            // 
            this.btnFindServerAccount.Location = new System.Drawing.Point(501, 32);
            this.btnFindServerAccount.Name = "btnFindServerAccount";
            this.btnFindServerAccount.Size = new System.Drawing.Size(34, 23);
            this.btnFindServerAccount.TabIndex = 5;
            this.btnFindServerAccount.Tag = "Account";
            this.btnFindServerAccount.Text = "...";
            this.btnFindServerAccount.UseVisualStyleBackColor = true;
            this.btnFindServerAccount.Click += new System.EventHandler(this.SelectItem);
            // 
            // txtAccuontPassword
            // 
            this.txtAccuontPassword.Location = new System.Drawing.Point(250, 127);
            this.txtAccuontPassword.Name = "txtAccuontPassword";
            this.txtAccuontPassword.Size = new System.Drawing.Size(285, 24);
            this.txtAccuontPassword.TabIndex = 13;
            this.txtAccuontPassword.UseSystemPasswordChar = true;
            // 
            // txtAccuontUsername
            // 
            this.txtAccuontUsername.Location = new System.Drawing.Point(250, 96);
            this.txtAccuontUsername.Name = "txtAccuontUsername";
            this.txtAccuontUsername.Size = new System.Drawing.Size(285, 24);
            this.txtAccuontUsername.TabIndex = 12;
            // 
            // txtAccuontDatabase
            // 
            this.txtAccuontDatabase.Location = new System.Drawing.Point(250, 65);
            this.txtAccuontDatabase.Name = "txtAccuontDatabase";
            this.txtAccuontDatabase.Size = new System.Drawing.Size(285, 24);
            this.txtAccuontDatabase.TabIndex = 11;
            // 
            // txtAccuontServer
            // 
            this.txtAccuontServer.Location = new System.Drawing.Point(250, 34);
            this.txtAccuontServer.Name = "txtAccuontServer";
            this.txtAccuontServer.Size = new System.Drawing.Size(245, 24);
            this.txtAccuontServer.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(30, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Account Database Password :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(30, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Account Database UserID :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(30, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Account Server Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFindServerAccount);
            this.tabPage2.Controls.Add(this.txtAccuontPassword);
            this.tabPage2.Controls.Add(this.txtAccuontUsername);
            this.tabPage2.Controls.Add(this.txtAccuontDatabase);
            this.tabPage2.Controls.Add(this.txtAccuontServer);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(30, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Account Database Name :";
            // 
            // btnFindServerGeneral
            // 
            this.btnFindServerGeneral.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFindServerGeneral.Location = new System.Drawing.Point(501, 32);
            this.btnFindServerGeneral.Name = "btnFindServerGeneral";
            this.btnFindServerGeneral.Size = new System.Drawing.Size(34, 23);
            this.btnFindServerGeneral.TabIndex = 0;
            this.btnFindServerGeneral.Tag = "System";
            this.btnFindServerGeneral.Text = "...";
            this.btnFindServerGeneral.UseVisualStyleBackColor = true;
            this.btnFindServerGeneral.Click += new System.EventHandler(this.SelectItem);
            // 
            // txtSystemPassword
            // 
            this.txtSystemPassword.Location = new System.Drawing.Point(250, 127);
            this.txtSystemPassword.Name = "txtSystemPassword";
            this.txtSystemPassword.Size = new System.Drawing.Size(285, 24);
            this.txtSystemPassword.TabIndex = 4;
            this.txtSystemPassword.UseSystemPasswordChar = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFindServerGeneral);
            this.tabPage1.Controls.Add(this.txtSystemPassword);
            this.tabPage1.Controls.Add(this.txtSystemUsername);
            this.tabPage1.Controls.Add(this.txtSystemDatabase);
            this.tabPage1.Controls.Add(this.txtSystemServer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System Infomation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSystemUsername
            // 
            this.txtSystemUsername.Location = new System.Drawing.Point(250, 96);
            this.txtSystemUsername.Name = "txtSystemUsername";
            this.txtSystemUsername.Size = new System.Drawing.Size(285, 24);
            this.txtSystemUsername.TabIndex = 3;
            // 
            // txtSystemDatabase
            // 
            this.txtSystemDatabase.Location = new System.Drawing.Point(250, 65);
            this.txtSystemDatabase.Name = "txtSystemDatabase";
            this.txtSystemDatabase.Size = new System.Drawing.Size(285, 24);
            this.txtSystemDatabase.TabIndex = 2;
            // 
            // txtSystemServer
            // 
            this.txtSystemServer.Location = new System.Drawing.Point(250, 34);
            this.txtSystemServer.Name = "txtSystemServer";
            this.txtSystemServer.Size = new System.Drawing.Size(245, 24);
            this.txtSystemServer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(30, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "System Database Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(30, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "System Database UserID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(30, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "System Database Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "System Server Name :";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตั้งค่าโปรแกรม";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 284);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel2.Size = new System.Drawing.Size(591, 35);
            this.panel2.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(451, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(30, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(591, 40);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(591, 244);
            this.panel3.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 234);
            this.tabControl1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(30, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Picture Path :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(30, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Company Name :";
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Location = new System.Drawing.Point(250, 65);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(245, 24);
            this.txtPicturePath.TabIndex = 11;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(250, 34);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(285, 24);
            this.txtCompanyName.TabIndex = 12;
            // 
            // btnFindPicturePath
            // 
            this.btnFindPicturePath.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFindPicturePath.Location = new System.Drawing.Point(501, 64);
            this.btnFindPicturePath.Name = "btnFindPicturePath";
            this.btnFindPicturePath.Size = new System.Drawing.Size(34, 23);
            this.btnFindPicturePath.TabIndex = 10;
            this.btnFindPicturePath.Tag = "PicturePath";
            this.btnFindPicturePath.Text = "...";
            this.btnFindPicturePath.UseVisualStyleBackColor = true;
            this.btnFindPicturePath.Click += new System.EventHandler(this.SelectItem);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFindPicturePath);
            this.tabPage3.Controls.Add(this.txtCompanyName);
            this.tabPage3.Controls.Add(this.txtPicturePath);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(573, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "General Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 329);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Config";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindServerAccount;
        private System.Windows.Forms.TextBox txtAccuontPassword;
        private System.Windows.Forms.TextBox txtAccuontUsername;
        private System.Windows.Forms.TextBox txtAccuontDatabase;
        private System.Windows.Forms.TextBox txtAccuontServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFindServerGeneral;
        private System.Windows.Forms.TextBox txtSystemPassword;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSystemUsername;
        private System.Windows.Forms.TextBox txtSystemDatabase;
        private System.Windows.Forms.TextBox txtSystemServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFindPicturePath;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPicturePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}