﻿namespace DryCleaningClient.UI
{
    partial class UserSettingsForm
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
            this.button_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Profile = new System.Windows.Forms.TableLayoutPanel();
            this.label_PassportID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PassportID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Role = new System.Windows.Forms.Label();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Password2 = new System.Windows.Forms.Label();
            this.label_IsAdmin = new System.Windows.Forms.Label();
            this.maskedTextBox_Password2 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_IsAdmin = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(12, 208);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(660, 41);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Profile
            // 
            this.tableLayoutPanel_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Profile.ColumnCount = 2;
            this.tableLayoutPanel_Profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.Controls.Add(this.label_PassportID, 0, 0);
            this.tableLayoutPanel_Profile.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel_Profile.Controls.Add(this.textBox_PassportID, 1, 0);
            this.tableLayoutPanel_Profile.Controls.Add(this.textBox_Name, 1, 1);
            this.tableLayoutPanel_Profile.Controls.Add(this.label_Role, 0, 2);
            this.tableLayoutPanel_Profile.Controls.Add(this.comboBox_Role, 1, 2);
            this.tableLayoutPanel_Profile.Controls.Add(this.maskedTextBox_Password, 1, 3);
            this.tableLayoutPanel_Profile.Controls.Add(this.label_Password, 0, 3);
            this.tableLayoutPanel_Profile.Controls.Add(this.label_Password2, 0, 4);
            this.tableLayoutPanel_Profile.Controls.Add(this.label_IsAdmin, 0, 5);
            this.tableLayoutPanel_Profile.Controls.Add(this.maskedTextBox_Password2, 1, 4);
            this.tableLayoutPanel_Profile.Controls.Add(this.checkBox_IsAdmin, 1, 5);
            this.tableLayoutPanel_Profile.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_Profile.Name = "tableLayoutPanel_Profile";
            this.tableLayoutPanel_Profile.RowCount = 6;
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_Profile.Size = new System.Drawing.Size(660, 190);
            this.tableLayoutPanel_Profile.TabIndex = 2;
            // 
            // label_PassportID
            // 
            this.label_PassportID.AutoSize = true;
            this.label_PassportID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PassportID.Location = new System.Drawing.Point(3, 0);
            this.label_PassportID.Name = "label_PassportID";
            this.label_PassportID.Size = new System.Drawing.Size(324, 36);
            this.label_PassportID.TabIndex = 0;
            this.label_PassportID.Text = "Номер паспорта (логин):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // textBox_PassportID
            // 
            this.textBox_PassportID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PassportID.Location = new System.Drawing.Point(333, 3);
            this.textBox_PassportID.Name = "textBox_PassportID";
            this.textBox_PassportID.Size = new System.Drawing.Size(324, 20);
            this.textBox_PassportID.TabIndex = 2;
            this.textBox_PassportID.Text = "{0}";
            this.textBox_PassportID.TextChanged += new System.EventHandler(this.textBox_PassportID_TextChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(333, 39);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(324, 20);
            this.textBox_Name.TabIndex = 3;
            this.textBox_Name.Text = "{0}";
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Role.Location = new System.Drawing.Point(3, 72);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(117, 24);
            this.label_Role.TabIndex = 5;
            this.label_Role.Text = "Должность:";
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Location = new System.Drawing.Point(333, 75);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(324, 21);
            this.comboBox_Role.TabIndex = 6;
            this.comboBox_Role.TextChanged += new System.EventHandler(this.comboBox_Role_TextChanged);
            // 
            // maskedTextBox_Password
            // 
            this.maskedTextBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_Password.Location = new System.Drawing.Point(333, 103);
            this.maskedTextBox_Password.Name = "maskedTextBox_Password";
            this.maskedTextBox_Password.PasswordChar = '*';
            this.maskedTextBox_Password.Size = new System.Drawing.Size(324, 20);
            this.maskedTextBox_Password.TabIndex = 7;
            this.maskedTextBox_Password.TextChanged += new System.EventHandler(this.MaskedTextBox_PasswordOnTextChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.Location = new System.Drawing.Point(3, 100);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(81, 24);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Пароль:";
            // 
            // label_Password2
            // 
            this.label_Password2.AutoSize = true;
            this.label_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password2.Location = new System.Drawing.Point(3, 128);
            this.label_Password2.Name = "label_Password2";
            this.label_Password2.Size = new System.Drawing.Size(150, 24);
            this.label_Password2.TabIndex = 9;
            this.label_Password2.Text = "Повтор пароля:";
            // 
            // label_IsAdmin
            // 
            this.label_IsAdmin.AutoSize = true;
            this.label_IsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IsAdmin.Location = new System.Drawing.Point(3, 159);
            this.label_IsAdmin.Name = "label_IsAdmin";
            this.label_IsAdmin.Size = new System.Drawing.Size(242, 24);
            this.label_IsAdmin.TabIndex = 10;
            this.label_IsAdmin.Text = "Администратор системы:";
            // 
            // maskedTextBox_Password2
            // 
            this.maskedTextBox_Password2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_Password2.Location = new System.Drawing.Point(333, 131);
            this.maskedTextBox_Password2.Name = "maskedTextBox_Password2";
            this.maskedTextBox_Password2.PasswordChar = '*';
            this.maskedTextBox_Password2.Size = new System.Drawing.Size(324, 20);
            this.maskedTextBox_Password2.TabIndex = 11;
            this.maskedTextBox_Password2.TextChanged += new System.EventHandler(this.MaskedTextBox_PasswordOnTextChanged);
            // 
            // checkBox_IsAdmin
            // 
            this.checkBox_IsAdmin.AutoSize = true;
            this.checkBox_IsAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_IsAdmin.Location = new System.Drawing.Point(333, 162);
            this.checkBox_IsAdmin.Name = "checkBox_IsAdmin";
            this.checkBox_IsAdmin.Size = new System.Drawing.Size(324, 25);
            this.checkBox_IsAdmin.TabIndex = 12;
            this.checkBox_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // UserSettingsForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.tableLayoutPanel_Profile);
            this.Controls.Add(this.button_Save);
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "UserSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserSettingsForm_FormClosed);
            this.tableLayoutPanel_Profile.ResumeLayout(false);
            this.tableLayoutPanel_Profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Profile;
        private System.Windows.Forms.Label label_PassportID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PassportID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Password2;
        private System.Windows.Forms.Label label_IsAdmin;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Password2;
        private System.Windows.Forms.CheckBox checkBox_IsAdmin;
    }
}