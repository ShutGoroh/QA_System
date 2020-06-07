namespace QA_System
{
    partial class Form_Main_User
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonExit = new FontAwesome.Sharp.IconButton();
            this.ButtonAccountInfo = new FontAwesome.Sharp.IconButton();
            this.ButtonStatistic = new FontAwesome.Sharp.IconButton();
            this.ButtonInterviewing = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.ButtonExit);
            this.panelMenu.Controls.Add(this.ButtonAccountInfo);
            this.panelMenu.Controls.Add(this.ButtonStatistic);
            this.panelMenu.Controls.Add(this.ButtonInterviewing);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(211, 701);
            this.panelMenu.TabIndex = 1;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ButtonExit.IconColor = System.Drawing.Color.White;
            this.ButtonExit.IconSize = 32;
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(0, 637);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonExit.Rotation = 0D;
            this.ButtonExit.Size = new System.Drawing.Size(211, 64);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonAccountInfo
            // 
            this.ButtonAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAccountInfo.FlatAppearance.BorderSize = 0;
            this.ButtonAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccountInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonAccountInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAccountInfo.ForeColor = System.Drawing.Color.White;
            this.ButtonAccountInfo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ButtonAccountInfo.IconColor = System.Drawing.Color.White;
            this.ButtonAccountInfo.IconSize = 32;
            this.ButtonAccountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAccountInfo.Location = new System.Drawing.Point(0, 228);
            this.ButtonAccountInfo.Name = "ButtonAccountInfo";
            this.ButtonAccountInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonAccountInfo.Rotation = 0D;
            this.ButtonAccountInfo.Size = new System.Drawing.Size(211, 64);
            this.ButtonAccountInfo.TabIndex = 4;
            this.ButtonAccountInfo.Text = "Учетная запись";
            this.ButtonAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAccountInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAccountInfo.UseVisualStyleBackColor = true;
            this.ButtonAccountInfo.Click += new System.EventHandler(this.ButtonAccountInfo_Click);
            // 
            // ButtonStatistic
            // 
            this.ButtonStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonStatistic.FlatAppearance.BorderSize = 0;
            this.ButtonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStatistic.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonStatistic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStatistic.ForeColor = System.Drawing.Color.White;
            this.ButtonStatistic.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ButtonStatistic.IconColor = System.Drawing.Color.White;
            this.ButtonStatistic.IconSize = 32;
            this.ButtonStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonStatistic.Location = new System.Drawing.Point(0, 164);
            this.ButtonStatistic.Name = "ButtonStatistic";
            this.ButtonStatistic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonStatistic.Rotation = 0D;
            this.ButtonStatistic.Size = new System.Drawing.Size(211, 64);
            this.ButtonStatistic.TabIndex = 3;
            this.ButtonStatistic.Text = "Результаты";
            this.ButtonStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonStatistic.UseVisualStyleBackColor = true;
            this.ButtonStatistic.Click += new System.EventHandler(this.ButtonStatistic_Click);
            // 
            // ButtonInterviewing
            // 
            this.ButtonInterviewing.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonInterviewing.FlatAppearance.BorderSize = 0;
            this.ButtonInterviewing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInterviewing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonInterviewing.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInterviewing.ForeColor = System.Drawing.Color.White;
            this.ButtonInterviewing.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ButtonInterviewing.IconColor = System.Drawing.Color.White;
            this.ButtonInterviewing.IconSize = 32;
            this.ButtonInterviewing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInterviewing.Location = new System.Drawing.Point(0, 100);
            this.ButtonInterviewing.Name = "ButtonInterviewing";
            this.ButtonInterviewing.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonInterviewing.Rotation = 0D;
            this.ButtonInterviewing.Size = new System.Drawing.Size(211, 64);
            this.ButtonInterviewing.TabIndex = 1;
            this.ButtonInterviewing.Text = "Интервьюирование";
            this.ButtonInterviewing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInterviewing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonInterviewing.UseVisualStyleBackColor = true;
            this.ButtonInterviewing.Click += new System.EventHandler(this.ButtonInterviewing_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(211, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::QA_System.Properties.Resources._4211864_96;
            this.pictureBox1.Location = new System.Drawing.Point(57, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.lblTitleChildForm);
            this.panel3.Controls.Add(this.iconTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(211, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 100);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(86, 29);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(95, 33);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.Teal;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconTitle.IconColor = System.Drawing.Color.White;
            this.iconTitle.IconSize = 48;
            this.iconTitle.Location = new System.Drawing.Point(32, 25);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(48, 48);
            this.iconTitle.TabIndex = 1;
            this.iconTitle.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.White;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(211, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(939, 10);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(211, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(939, 591);
            this.panelDesktop.TabIndex = 4;
            // 
            // Form_Main_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 701);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main_User";
            this.Text = "Form_Main_User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_User_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ButtonExit;
        private FontAwesome.Sharp.IconButton ButtonAccountInfo;
        private FontAwesome.Sharp.IconButton ButtonStatistic;
        private FontAwesome.Sharp.IconButton ButtonInterviewing;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconTitle;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}