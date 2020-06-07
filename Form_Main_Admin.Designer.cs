namespace QA_System
{
    partial class Form_Main_Admin
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
            this.ButtonResultList = new FontAwesome.Sharp.IconButton();
            this.ButtonUserList = new FontAwesome.Sharp.IconButton();
            this.ButtonSystemList = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mySeparator1 = new QA_System.MySeparator();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.ButtonExit);
            this.panelMenu.Controls.Add(this.ButtonAccountInfo);
            this.panelMenu.Controls.Add(this.ButtonResultList);
            this.panelMenu.Controls.Add(this.ButtonUserList);
            this.panelMenu.Controls.Add(this.ButtonSystemList);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 701);
            this.panelMenu.TabIndex = 0;
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
            this.ButtonExit.Size = new System.Drawing.Size(200, 64);
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
            this.ButtonAccountInfo.Location = new System.Drawing.Point(0, 292);
            this.ButtonAccountInfo.Name = "ButtonAccountInfo";
            this.ButtonAccountInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonAccountInfo.Rotation = 0D;
            this.ButtonAccountInfo.Size = new System.Drawing.Size(200, 64);
            this.ButtonAccountInfo.TabIndex = 4;
            this.ButtonAccountInfo.Text = "Учетная запись";
            this.ButtonAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAccountInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAccountInfo.UseVisualStyleBackColor = true;
            this.ButtonAccountInfo.Click += new System.EventHandler(this.ButtonAccountInfo_Click);
            // 
            // ButtonResultList
            // 
            this.ButtonResultList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonResultList.FlatAppearance.BorderSize = 0;
            this.ButtonResultList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResultList.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonResultList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResultList.ForeColor = System.Drawing.Color.White;
            this.ButtonResultList.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ButtonResultList.IconColor = System.Drawing.Color.White;
            this.ButtonResultList.IconSize = 32;
            this.ButtonResultList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonResultList.Location = new System.Drawing.Point(0, 228);
            this.ButtonResultList.Name = "ButtonResultList";
            this.ButtonResultList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonResultList.Rotation = 0D;
            this.ButtonResultList.Size = new System.Drawing.Size(200, 64);
            this.ButtonResultList.TabIndex = 3;
            this.ButtonResultList.Text = "Рейтинги";
            this.ButtonResultList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonResultList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonResultList.UseVisualStyleBackColor = true;
            this.ButtonResultList.Click += new System.EventHandler(this.ButtonResultList_Click);
            // 
            // ButtonUserList
            // 
            this.ButtonUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonUserList.FlatAppearance.BorderSize = 0;
            this.ButtonUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUserList.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonUserList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUserList.ForeColor = System.Drawing.Color.White;
            this.ButtonUserList.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.ButtonUserList.IconColor = System.Drawing.Color.White;
            this.ButtonUserList.IconSize = 32;
            this.ButtonUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUserList.Location = new System.Drawing.Point(0, 164);
            this.ButtonUserList.Name = "ButtonUserList";
            this.ButtonUserList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonUserList.Rotation = 0D;
            this.ButtonUserList.Size = new System.Drawing.Size(200, 64);
            this.ButtonUserList.TabIndex = 2;
            this.ButtonUserList.Text = "Список пользователей";
            this.ButtonUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUserList.UseVisualStyleBackColor = true;
            this.ButtonUserList.Click += new System.EventHandler(this.ButtonUserList_Click);
            // 
            // ButtonSystemList
            // 
            this.ButtonSystemList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSystemList.FlatAppearance.BorderSize = 0;
            this.ButtonSystemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSystemList.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonSystemList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSystemList.ForeColor = System.Drawing.Color.White;
            this.ButtonSystemList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ButtonSystemList.IconColor = System.Drawing.Color.White;
            this.ButtonSystemList.IconSize = 32;
            this.ButtonSystemList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSystemList.Location = new System.Drawing.Point(0, 100);
            this.ButtonSystemList.Name = "ButtonSystemList";
            this.ButtonSystemList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonSystemList.Rotation = 0D;
            this.ButtonSystemList.Size = new System.Drawing.Size(200, 64);
            this.ButtonSystemList.TabIndex = 1;
            this.ButtonSystemList.Text = "Список систем";
            this.ButtonSystemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSystemList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSystemList.UseVisualStyleBackColor = true;
            this.ButtonSystemList.Click += new System.EventHandler(this.ButtonSystemList_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::QA_System.Properties.Resources._4211864_96;
            this.pictureBox1.Location = new System.Drawing.Point(52, 2);
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
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 100);
            this.panel3.TabIndex = 1;
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
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(200, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(950, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.mySeparator1);
            this.panelDesktop.Controls.Add(this.textBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(950, 591);
            this.panelDesktop.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Teal;
            this.textBox1.Location = new System.Drawing.Point(198, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 221);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Данная система предназначена для созданий ситуаций инервьюирования заказчика";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mySeparator1
            // 
            this.mySeparator1.ForeColor = System.Drawing.Color.Teal;
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(269, 326);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(357, 23);
            this.mySeparator1.TabIndex = 1;
            this.mySeparator1.Text = "mySeparator1";
            this.mySeparator1.Thickness = 1;
            // 
            // Form_Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 701);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main_Admin";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_Admin_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ButtonAccountInfo;
        private FontAwesome.Sharp.IconButton ButtonResultList;
        private FontAwesome.Sharp.IconButton ButtonUserList;
        private FontAwesome.Sharp.IconButton ButtonSystemList;
        private FontAwesome.Sharp.IconButton ButtonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconTitle;
        private MySeparator mySeparator1;
        private System.Windows.Forms.TextBox textBox1;
    }
}