namespace QA_System.User_forms
{
    partial class Form_interviewing
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
            this.comboBoxUserSystems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelForChat = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mySeparator1 = new QA_System.MySeparator();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // comboBoxUserSystems
            // 
            this.comboBoxUserSystems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserSystems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserSystems.FormattingEnabled = true;
            this.comboBoxUserSystems.Location = new System.Drawing.Point(26, 47);
            this.comboBoxUserSystems.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxUserSystems.Name = "comboBoxUserSystems";
            this.comboBoxUserSystems.Size = new System.Drawing.Size(302, 29);
            this.comboBoxUserSystems.TabIndex = 0;
            this.comboBoxUserSystems.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserSystems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Система:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxDescription.Location = new System.Drawing.Point(26, 127);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(420, 382);
            this.textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // panelForChat
            // 
            this.panelForChat.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForChat.Location = new System.Drawing.Point(469, 0);
            this.panelForChat.Name = "panelForChat";
            this.panelForChat.Size = new System.Drawing.Size(470, 591);
            this.panelForChat.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(336, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySeparator1
            // 
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(26, 84);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(420, 8);
            this.mySeparator1.TabIndex = 6;
            this.mySeparator1.Text = "mySeparator1";
            this.mySeparator1.Thickness = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.IconSize = 64;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(26, 515);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(158, 64);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "Удалить";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Form_interviewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 591);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.mySeparator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelForChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUserSystems);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_interviewing";
            this.Text = "Интервьюирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserSystems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelForChat;
        private System.Windows.Forms.Button button1;
        private MySeparator mySeparator1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}