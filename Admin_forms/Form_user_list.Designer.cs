namespace QA_System.Admin_forms
{
    partial class Form_user_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableUserList = new System.Windows.Forms.DataGridView();
            this.panelUserData = new System.Windows.Forms.Panel();
            this.ButtonAddUser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // TableUserList
            // 
            this.TableUserList.AllowUserToAddRows = false;
            this.TableUserList.AllowUserToDeleteRows = false;
            this.TableUserList.BackgroundColor = System.Drawing.Color.White;
            this.TableUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TableUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUserList.GridColor = System.Drawing.Color.White;
            this.TableUserList.Location = new System.Drawing.Point(12, 13);
            this.TableUserList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableUserList.Name = "TableUserList";
            this.TableUserList.ReadOnly = true;
            this.TableUserList.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            this.TableUserList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TableUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableUserList.Size = new System.Drawing.Size(446, 478);
            this.TableUserList.TabIndex = 0;
            this.TableUserList.Click += new System.EventHandler(this.TableUserList_Click);
            // 
            // panelUserData
            // 
            this.panelUserData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUserData.Location = new System.Drawing.Point(475, 0);
            this.panelUserData.Name = "panelUserData";
            this.panelUserData.Size = new System.Drawing.Size(475, 591);
            this.panelUserData.TabIndex = 2;
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonAddUser.FlatAppearance.BorderSize = 0;
            this.ButtonAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonAddUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.Color.Teal;
            this.ButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ButtonAddUser.IconColor = System.Drawing.Color.Teal;
            this.ButtonAddUser.IconSize = 64;
            this.ButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddUser.Location = new System.Drawing.Point(220, 515);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Rotation = 0D;
            this.ButtonAddUser.Size = new System.Drawing.Size(238, 64);
            this.ButtonAddUser.TabIndex = 8;
            this.ButtonAddUser.Text = "Добавить пользователя";
            this.ButtonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // Form_user_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 591);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.panelUserData);
            this.Controls.Add(this.TableUserList);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_user_list";
            this.Text = "Список пользователей";
            this.Load += new System.EventHandler(this.Form_user_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableUserList;
        private System.Windows.Forms.Panel panelUserData;
        private FontAwesome.Sharp.IconButton ButtonAddUser;
    }
}