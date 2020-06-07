namespace QA_System
{
    partial class FormSign
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.mySeparator2 = new QA_System.MySeparator();
            this.mySeparator1 = new QA_System.MySeparator();
            this.button_WOC1 = new QA_System.Button_WOC();
            this.gradientPanel1 = new QA_System.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.White;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.textBoxLogin.Location = new System.Drawing.Point(366, 98);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(289, 19);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Пользователь";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            this.textBoxLogin.MouseEnter += new System.EventHandler(this.textBoxLogin_MouseEnter);
            this.textBoxLogin.MouseLeave += new System.EventHandler(this.textBoxLogin_MouseLeave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(366, 148);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(289, 19);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.textBoxPassword_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.Teal;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonClose.IconColor = System.Drawing.Color.Teal;
            this.iconButtonClose.IconSize = 32;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonClose.Location = new System.Drawing.Point(672, 12);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Rotation = 0D;
            this.iconButtonClose.Size = new System.Drawing.Size(96, 32);
            this.iconButtonClose.TabIndex = 7;
            this.iconButtonClose.Text = "Close";
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            this.iconButtonClose.MouseEnter += new System.EventHandler(this.iconButtonClose_MouseEnter);
            this.iconButtonClose.MouseLeave += new System.EventHandler(this.iconButtonClose_MouseLeave);
            // 
            // mySeparator2
            // 
            this.mySeparator2.BackColor = System.Drawing.Color.White;
            this.mySeparator2.isVertical = false;
            this.mySeparator2.Location = new System.Drawing.Point(366, 121);
            this.mySeparator2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.mySeparator2.Name = "mySeparator2";
            this.mySeparator2.Size = new System.Drawing.Size(289, 10);
            this.mySeparator2.TabIndex = 6;
            this.mySeparator2.Text = "mySeparator2";
            this.mySeparator2.Thickness = 1;
            // 
            // mySeparator1
            // 
            this.mySeparator1.BackColor = System.Drawing.Color.White;
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(366, 171);
            this.mySeparator1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(289, 10);
            this.mySeparator1.TabIndex = 5;
            this.mySeparator1.Text = "mySeparator1";
            this.mySeparator1.Thickness = 1;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Teal;
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Location = new System.Drawing.Point(366, 187);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Teal;
            this.button_WOC1.Size = new System.Drawing.Size(289, 55);
            this.button_WOC1.TabIndex = 0;
            this.button_WOC1.Text = "Войти";
            this.button_WOC1.TextColor = System.Drawing.SystemColors.Control;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Teal;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(250, 330);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::QA_System.Properties.Resources._4211864_128;
            this.pictureBox1.Location = new System.Drawing.Point(63, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "interviewing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // FormSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.iconButtonClose);
            this.Controls.Add(this.mySeparator2);
            this.Controls.Add(this.mySeparator1);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSign_MouseDown);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private Button_WOC button_WOC1;
        private MySeparator mySeparator1;
        private MySeparator mySeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonClose;
    }
}

