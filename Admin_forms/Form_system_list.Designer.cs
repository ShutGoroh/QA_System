namespace QA_System.Admin_forms
{
    partial class Form_system_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_system_list));
            this.TableSystemList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySeparator1 = new QA_System.MySeparator();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ButtonAddUser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableSystemList)).BeginInit();
            this.SuspendLayout();
            // 
            // TableSystemList
            // 
            this.TableSystemList.AllowUserToAddRows = false;
            this.TableSystemList.AllowUserToDeleteRows = false;
            this.TableSystemList.BackgroundColor = System.Drawing.Color.White;
            this.TableSystemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableSystemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TableSystemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableSystemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableSystemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSystemList.GridColor = System.Drawing.Color.White;
            this.TableSystemList.Location = new System.Drawing.Point(12, 13);
            this.TableSystemList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableSystemList.Name = "TableSystemList";
            this.TableSystemList.ReadOnly = true;
            this.TableSystemList.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            this.TableSystemList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TableSystemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSystemList.Size = new System.Drawing.Size(291, 482);
            this.TableSystemList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Teal;
            this.textBox1.Location = new System.Drawing.Point(365, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(573, 504);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(559, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Описание";
            // 
            // mySeparator1
            // 
            this.mySeparator1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(365, 46);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(573, 23);
            this.mySeparator1.TabIndex = 12;
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
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.IconSize = 64;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(176, 515);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(158, 64);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Удалить";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonAddUser.FlatAppearance.BorderSize = 0;
            this.ButtonAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.Color.Teal;
            this.ButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ButtonAddUser.IconColor = System.Drawing.Color.Teal;
            this.ButtonAddUser.IconSize = 64;
            this.ButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddUser.Location = new System.Drawing.Point(12, 515);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Rotation = 0D;
            this.ButtonAddUser.Size = new System.Drawing.Size(158, 64);
            this.ButtonAddUser.TabIndex = 9;
            this.ButtonAddUser.Text = "Добавить";
            this.ButtonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // Form_system_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 591);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.mySeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.TableSystemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_system_list";
            this.Text = "Список систем";
            this.Load += new System.EventHandler(this.Form_system_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableSystemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableSystemList;
        private FontAwesome.Sharp.IconButton ButtonAddUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private MySeparator mySeparator1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}