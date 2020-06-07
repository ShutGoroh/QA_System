namespace QA_System.User_forms
{
    partial class Form_creation_new_user_system
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
            this.button_WOC1 = new QA_System.Button_WOC();
            this.button_Create = new QA_System.Button_WOC();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySeparator1 = new QA_System.MySeparator();
            this.comboBoxSystems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Location = new System.Drawing.Point(55, 589);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_WOC1.Size = new System.Drawing.Size(289, 55);
            this.button_WOC1.TabIndex = 57;
            this.button_WOC1.Text = "Отмена";
            this.button_WOC1.TextColor = System.Drawing.SystemColors.Control;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.Transparent;
            this.button_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Create.BorderColor = System.Drawing.Color.Transparent;
            this.button_Create.ButtonColor = System.Drawing.Color.Teal;
            this.button_Create.FlatAppearance.BorderSize = 0;
            this.button_Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.ForeColor = System.Drawing.Color.Transparent;
            this.button_Create.Location = new System.Drawing.Point(55, 528);
            this.button_Create.Name = "button_Create";
            this.button_Create.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.button_Create.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.button_Create.OnHoverTextColor = System.Drawing.Color.Teal;
            this.button_Create.Size = new System.Drawing.Size(289, 55);
            this.button_Create.TabIndex = 56;
            this.button_Create.Text = "Выбрать";
            this.button_Create.TextColor = System.Drawing.SystemColors.Control;
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxDescription.Location = new System.Drawing.Point(12, 112);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(376, 410);
            this.textBoxDescription.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 42);
            this.label1.TabIndex = 59;
            this.label1.Text = "Выбор системы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mySeparator1
            // 
            this.mySeparator1.ForeColor = System.Drawing.Color.Teal;
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(13, 44);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(375, 10);
            this.mySeparator1.TabIndex = 60;
            this.mySeparator1.Text = "mySeparator1";
            this.mySeparator1.Thickness = 1;
            // 
            // comboBoxSystems
            // 
            this.comboBoxSystems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSystems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSystems.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxSystems.FormattingEnabled = true;
            this.comboBoxSystems.Location = new System.Drawing.Point(55, 60);
            this.comboBoxSystems.Name = "comboBoxSystems";
            this.comboBoxSystems.Size = new System.Drawing.Size(276, 30);
            this.comboBoxSystems.TabIndex = 61;
            this.comboBoxSystems.SelectedIndexChanged += new System.EventHandler(this.comboBoxSystems_SelectedIndexChanged);
            // 
            // Form_creation_new_user_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 660);
            this.Controls.Add(this.comboBoxSystems);
            this.Controls.Add(this.mySeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_creation_new_user_system";
            this.Text = "Form_creation_new_user_form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_creation_new_user_form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button_WOC button_WOC1;
        private Button_WOC button_Create;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private MySeparator mySeparator1;
        private System.Windows.Forms.ComboBox comboBoxSystems;
    }
}