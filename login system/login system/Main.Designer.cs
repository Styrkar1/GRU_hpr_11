namespace login_system
{
    partial class Main
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
            this.btnexit = new System.Windows.Forms.Button();
            this.txtchngnewpass = new System.Windows.Forms.TextBox();
            this.txtchngcurpass = new System.Windows.Forms.TextBox();
            this.txtchnguser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabusermng = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnchngpass = new System.Windows.Forms.Button();
            this.tabbndmng = new System.Windows.Forms.TabPage();
            this.btnbandsbmit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbandphone = new System.Windows.Forms.TextBox();
            this.txtbndemail = new System.Windows.Forms.TextBox();
            this.txtbndname = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.teamgridview = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.playergridview = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstnamecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnamecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtndel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabusermng.SuspendLayout();
            this.tabbndmng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamgridview)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(91, 180);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtchngnewpass
            // 
            this.txtchngnewpass.Location = new System.Drawing.Point(91, 83);
            this.txtchngnewpass.Name = "txtchngnewpass";
            this.txtchngnewpass.PasswordChar = '•';
            this.txtchngnewpass.Size = new System.Drawing.Size(100, 20);
            this.txtchngnewpass.TabIndex = 1;
            // 
            // txtchngcurpass
            // 
            this.txtchngcurpass.Location = new System.Drawing.Point(91, 57);
            this.txtchngcurpass.Name = "txtchngcurpass";
            this.txtchngcurpass.PasswordChar = '•';
            this.txtchngcurpass.Size = new System.Drawing.Size(100, 20);
            this.txtchngcurpass.TabIndex = 2;
            // 
            // txtchnguser
            // 
            this.txtchnguser.Location = new System.Drawing.Point(91, 31);
            this.txtchnguser.Name = "txtchnguser";
            this.txtchnguser.Size = new System.Drawing.Size(100, 20);
            this.txtchnguser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cur password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabusermng);
            this.tabControl1.Controls.Add(this.tabbndmng);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 555);
            this.tabControl1.TabIndex = 7;
            // 
            // tabusermng
            // 
            this.tabusermng.Controls.Add(this.label12);
            this.tabusermng.Controls.Add(this.btnchngpass);
            this.tabusermng.Controls.Add(this.txtchnguser);
            this.tabusermng.Controls.Add(this.label3);
            this.tabusermng.Controls.Add(this.btnexit);
            this.tabusermng.Controls.Add(this.label2);
            this.tabusermng.Controls.Add(this.txtchngnewpass);
            this.tabusermng.Controls.Add(this.label1);
            this.tabusermng.Controls.Add(this.txtchngcurpass);
            this.tabusermng.Location = new System.Drawing.Point(4, 22);
            this.tabusermng.Name = "tabusermng";
            this.tabusermng.Padding = new System.Windows.Forms.Padding(3);
            this.tabusermng.Size = new System.Drawing.Size(552, 529);
            this.tabusermng.TabIndex = 0;
            this.tabusermng.Text = "User management";
            this.tabusermng.UseVisualStyleBackColor = true;
            this.tabusermng.Click += new System.EventHandler(this.tabusermng_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "There are no easter eggs here";
            // 
            // btnchngpass
            // 
            this.btnchngpass.Location = new System.Drawing.Point(91, 109);
            this.btnchngpass.Name = "btnchngpass";
            this.btnchngpass.Size = new System.Drawing.Size(100, 23);
            this.btnchngpass.TabIndex = 8;
            this.btnchngpass.Text = "Change pass";
            this.btnchngpass.UseVisualStyleBackColor = true;
            this.btnchngpass.Click += new System.EventHandler(this.btnchngpass_Click);
            // 
            // tabbndmng
            // 
            this.tabbndmng.Controls.Add(this.btnbandsbmit);
            this.tabbndmng.Controls.Add(this.label10);
            this.tabbndmng.Controls.Add(this.label9);
            this.tabbndmng.Controls.Add(this.txtbandphone);
            this.tabbndmng.Controls.Add(this.txtbndemail);
            this.tabbndmng.Controls.Add(this.txtbndname);
            this.tabbndmng.Controls.Add(this.Label8);
            this.tabbndmng.Controls.Add(this.teamgridview);
            this.tabbndmng.Location = new System.Drawing.Point(4, 22);
            this.tabbndmng.Name = "tabbndmng";
            this.tabbndmng.Padding = new System.Windows.Forms.Padding(3);
            this.tabbndmng.Size = new System.Drawing.Size(552, 529);
            this.tabbndmng.TabIndex = 1;
            this.tabbndmng.Text = "Team management";
            this.tabbndmng.UseVisualStyleBackColor = true;
            // 
            // btnbandsbmit
            // 
            this.btnbandsbmit.Location = new System.Drawing.Point(122, 458);
            this.btnbandsbmit.Name = "btnbandsbmit";
            this.btnbandsbmit.Size = new System.Drawing.Size(75, 23);
            this.btnbandsbmit.TabIndex = 16;
            this.btnbandsbmit.Text = "Submit";
            this.btnbandsbmit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Starts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Versus";
            // 
            // txtbandphone
            // 
            this.txtbandphone.Location = new System.Drawing.Point(112, 432);
            this.txtbandphone.Name = "txtbandphone";
            this.txtbandphone.Size = new System.Drawing.Size(100, 20);
            this.txtbandphone.TabIndex = 11;
            // 
            // txtbndemail
            // 
            this.txtbndemail.Location = new System.Drawing.Point(112, 405);
            this.txtbndemail.Name = "txtbndemail";
            this.txtbndemail.Size = new System.Drawing.Size(100, 20);
            this.txtbndemail.TabIndex = 10;
            // 
            // txtbndname
            // 
            this.txtbndname.Location = new System.Drawing.Point(112, 378);
            this.txtbndname.Name = "txtbndname";
            this.txtbndname.Size = new System.Drawing.Size(100, 20);
            this.txtbndname.TabIndex = 9;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(70, 381);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(34, 13);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Team";
            // 
            // teamgridview
            // 
            this.teamgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmid,
            this.clmteam,
            this.clmvsv,
            this.clmtime,
            this.clmbtndel});
            this.teamgridview.Location = new System.Drawing.Point(6, 3);
            this.teamgridview.Name = "teamgridview";
            this.teamgridview.Size = new System.Drawing.Size(475, 334);
            this.teamgridview.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.playergridview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 529);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Player Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "First name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 383);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nickname";
            // 
            // playergridview
            // 
            this.playergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nickcolumn,
            this.Firstnamecolumn,
            this.lastnamecolumn,
            this.teamcolumn,
            this.countrycolumn});
            this.playergridview.Location = new System.Drawing.Point(7, 6);
            this.playergridview.Name = "playergridview";
            this.playergridview.Size = new System.Drawing.Size(475, 334);
            this.playergridview.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Country";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 463);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // nickcolumn
            // 
            this.nickcolumn.HeaderText = "Nickname";
            this.nickcolumn.Name = "nickcolumn";
            // 
            // Firstnamecolumn
            // 
            this.Firstnamecolumn.HeaderText = "First Name";
            this.Firstnamecolumn.Name = "Firstnamecolumn";
            // 
            // lastnamecolumn
            // 
            this.lastnamecolumn.HeaderText = "Last Name";
            this.lastnamecolumn.Name = "lastnamecolumn";
            // 
            // teamcolumn
            // 
            this.teamcolumn.HeaderText = "Team";
            this.teamcolumn.Name = "teamcolumn";
            // 
            // countrycolumn
            // 
            this.countrycolumn.HeaderText = "Country";
            this.countrycolumn.Name = "countrycolumn";
            // 
            // clmid
            // 
            this.clmid.HeaderText = "ID";
            this.clmid.Name = "clmid";
            this.clmid.Width = 30;
            // 
            // clmteam
            // 
            this.clmteam.HeaderText = "Team";
            this.clmteam.Name = "clmteam";
            // 
            // clmvsv
            // 
            this.clmvsv.HeaderText = "Versus";
            this.clmvsv.Name = "clmvsv";
            // 
            // clmtime
            // 
            this.clmtime.HeaderText = "Starts";
            this.clmtime.Name = "clmtime";
            // 
            // clmbtndel
            // 
            this.clmbtndel.HeaderText = "Delete";
            this.clmbtndel.Name = "clmbtndel";
            this.clmbtndel.Text = "Del";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabusermng.ResumeLayout(false);
            this.tabusermng.PerformLayout();
            this.tabbndmng.ResumeLayout(false);
            this.tabbndmng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamgridview)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playergridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtchngnewpass;
        private System.Windows.Forms.TextBox txtchngcurpass;
        private System.Windows.Forms.TextBox txtchnguser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabusermng;
        private System.Windows.Forms.Button btnchngpass;
        private System.Windows.Forms.TabPage tabbndmng;
        private System.Windows.Forms.DataGridView teamgridview;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbandphone;
        private System.Windows.Forms.TextBox txtbndemail;
        private System.Windows.Forms.TextBox txtbndname;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Button btnbandsbmit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView playergridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstnamecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnamecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtime;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtndel;

    }
}