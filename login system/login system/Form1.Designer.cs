namespace login_system
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
            this.txtuserlog = new System.Windows.Forms.TextBox();
            this.txtpasslog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogi = new System.Windows.Forms.Button();
            this.btnsoul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtuserlog
            // 
            this.txtuserlog.Location = new System.Drawing.Point(131, 135);
            this.txtuserlog.MaxLength = 20;
            this.txtuserlog.Name = "txtuserlog";
            this.txtuserlog.Size = new System.Drawing.Size(100, 20);
            this.txtuserlog.TabIndex = 0;
            // 
            // txtpasslog
            // 
            this.txtpasslog.Location = new System.Drawing.Point(131, 161);
            this.txtpasslog.MaxLength = 20;
            this.txtpasslog.Name = "txtpasslog";
            this.txtpasslog.PasswordChar = '•';
            this.txtpasslog.Size = new System.Drawing.Size(100, 20);
            this.txtpasslog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // btnlogi
            // 
            this.btnlogi.Location = new System.Drawing.Point(143, 187);
            this.btnlogi.Name = "btnlogi";
            this.btnlogi.Size = new System.Drawing.Size(75, 23);
            this.btnlogi.TabIndex = 21;
            this.btnlogi.Text = "Login";
            this.btnlogi.Click += new System.EventHandler(this.btnlogi_Click);
            // 
            // btnsoul
            // 
            this.btnsoul.Location = new System.Drawing.Point(12, 290);
            this.btnsoul.Name = "btnsoul";
            this.btnsoul.Size = new System.Drawing.Size(88, 28);
            this.btnsoul.TabIndex = 18;
            this.btnsoul.Text = "Exit";
            this.btnsoul.UseVisualStyleBackColor = true;
            this.btnsoul.Click += new System.EventHandler(this.btnsoul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Welcome, Admin.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Farwell, Admin.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsoul);
            this.Controls.Add(this.btnlogi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpasslog);
            this.Controls.Add(this.txtuserlog);
            this.Name = "Form1";
            this.Text = "There is no cow level";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuserlog;
        private System.Windows.Forms.TextBox txtpasslog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogi;
        private System.Windows.Forms.Button btnsoul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

