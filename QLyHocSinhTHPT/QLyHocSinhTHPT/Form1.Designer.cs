namespace QLyHocSinhTHPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txt_Err = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Eye_0 = new System.Windows.Forms.Button();
            this.btn_Eye = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Adobe Hebrew", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(97, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Login Here";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Black;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.LightGray;
            this.txt_Username.Location = new System.Drawing.Point(35, 223);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(282, 30);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.Text = "Enter Username";
            this.txt_Username.Enter += new System.EventHandler(this.txt_Username_Enter);
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Black;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.LightGray;
            this.txt_Password.Location = new System.Drawing.Point(35, 320);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(270, 30);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "Enter Password";
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Adobe Hebrew", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(35, 184);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 32);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Username";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Adobe Hebrew", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(35, 281);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 32);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(36, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 1);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(36, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 1);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Red;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Adobe Hebrew", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(40, 375);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(305, 49);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(37, 438);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 26);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Lost your password?";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(37, 464);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(211, 26);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "Don\'t have an account?";
            // 
            // txt_Err
            // 
            this.txt_Err.BackColor = System.Drawing.Color.Black;
            this.txt_Err.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Err.Font = new System.Drawing.Font("Adobe Hebrew", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Err.ForeColor = System.Drawing.Color.Red;
            this.txt_Err.Location = new System.Drawing.Point(35, 496);
            this.txt_Err.Multiline = true;
            this.txt_Err.Name = "txt_Err";
            this.txt_Err.Size = new System.Drawing.Size(311, 59);
            this.txt_Err.TabIndex = 10;
            this.txt_Err.Text = "Incorrect account information or password";
            this.txt_Err.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Err.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(351, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 35);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Eye_0
            // 
            this.btn_Eye_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eye_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Eye_0.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eye_0.Image")));
            this.btn_Eye_0.Location = new System.Drawing.Point(305, 310);
            this.btn_Eye_0.Name = "btn_Eye_0";
            this.btn_Eye_0.Size = new System.Drawing.Size(49, 40);
            this.btn_Eye_0.TabIndex = 14;
            this.btn_Eye_0.UseVisualStyleBackColor = true;
            this.btn_Eye_0.Click += new System.EventHandler(this.btn_Eye_0_Click);
            // 
            // btn_Eye
            // 
            this.btn_Eye.FlatAppearance.BorderSize = 0;
            this.btn_Eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eye.ForeColor = System.Drawing.Color.Red;
            this.btn_Eye.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eye.Image")));
            this.btn_Eye.Location = new System.Drawing.Point(305, 310);
            this.btn_Eye.Name = "btn_Eye";
            this.btn_Eye.Size = new System.Drawing.Size(49, 40);
            this.btn_Eye.TabIndex = 13;
            this.btn_Eye.UseVisualStyleBackColor = true;
            this.btn_Eye.Visible = false;
            this.btn_Eye.Click += new System.EventHandler(this.btn_Eye_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(132, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 125);
            this.label3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 559);
            this.Controls.Add(this.btn_Eye_0);
            this.Controls.Add(this.btn_Eye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Err);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txt_Err;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Eye;
        private System.Windows.Forms.Button btn_Eye_0;
    }
}

