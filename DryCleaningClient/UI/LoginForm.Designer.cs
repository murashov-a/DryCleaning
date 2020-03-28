using System.Windows.Forms;

namespace DryCleaningClient
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_AuthInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label_Server = new System.Windows.Forms.Label();
            this.label_PasspordID = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_PassportID = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.tableLayoutPanel_AuthInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_AuthInfo
            // 
            this.tableLayoutPanel_AuthInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_AuthInfo.ColumnCount = 2;
            this.tableLayoutPanel_AuthInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93814F));
            this.tableLayoutPanel_AuthInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06186F));
            this.tableLayoutPanel_AuthInfo.Controls.Add(this.label_Server, 0, 2);
            this.tableLayoutPanel_AuthInfo.Controls.Add(this.label_PasspordID, 0, 0);
            this.tableLayoutPanel_AuthInfo.Controls.Add(this.label_Password, 0, 1);
            this.tableLayoutPanel_AuthInfo.Controls.Add(this.textBox_PassportID, 1, 0);
            this.tableLayoutPanel_AuthInfo.Controls.Add(this.maskedTextBox_Password, 1, 1);
            this.tableLayoutPanel_AuthInfo.Controls.Add(this.textBox_Server, 1, 2);
            this.tableLayoutPanel_AuthInfo.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel_AuthInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_AuthInfo.Name = "tableLayoutPanel_AuthInfo";
            this.tableLayoutPanel_AuthInfo.RowCount = 3;
            this.tableLayoutPanel_AuthInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel_AuthInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel_AuthInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel_AuthInfo.Size = new System.Drawing.Size(1140, 120);
            this.tableLayoutPanel_AuthInfo.TabIndex = 0;
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Server.Location = new System.Drawing.Point(4, 71);
            this.label_Server.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(253, 49);
            this.label_Server.TabIndex = 4;
            this.label_Server.Text = "Сервер:";
            // 
            // label_PasspordID
            // 
            this.label_PasspordID.AutoSize = true;
            this.label_PasspordID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PasspordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PasspordID.Location = new System.Drawing.Point(4, 0);
            this.label_PasspordID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PasspordID.Name = "label_PasspordID";
            this.label_PasspordID.Size = new System.Drawing.Size(253, 35);
            this.label_PasspordID.TabIndex = 0;
            this.label_PasspordID.Text = "Номер паспорта:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.Location = new System.Drawing.Point(4, 35);
            this.label_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(253, 36);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Пароль:";
            // 
            // textBox_PassportID
            // 
            this.textBox_PassportID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PassportID.Location = new System.Drawing.Point(265, 5);
            this.textBox_PassportID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_PassportID.Name = "textBox_PassportID";
            this.textBox_PassportID.Size = new System.Drawing.Size(871, 29);
            this.textBox_PassportID.TabIndex = 2;
            // 
            // maskedTextBox_Password
            // 
            this.maskedTextBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_Password.Location = new System.Drawing.Point(265, 40);
            this.maskedTextBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox_Password.Name = "maskedTextBox_Password";
            this.maskedTextBox_Password.PasswordChar = '*';
            this.maskedTextBox_Password.Size = new System.Drawing.Size(871, 29);
            this.maskedTextBox_Password.TabIndex = 3;
            // 
            // textBox_Server
            // 
            this.textBox_Server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Server.Location = new System.Drawing.Point(264, 74);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(873, 26);
            this.textBox_Server.TabIndex = 5;
            this.textBox_Server.Text = "http://murashov-a.ru:1994";
            // 
            // button_Login
            // 
            this.button_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.Location = new System.Drawing.Point(18, 148);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(1140, 62);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 229);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.tableLayoutPanel_AuthInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1192, 241);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.tableLayoutPanel_AuthInfo.ResumeLayout(false);
            this.tableLayoutPanel_AuthInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_AuthInfo;
        private Label label_PasspordID;
        private TextBox textBox_PassportID;
        private Button button_Login;
        private Label label_Server;
        private Label label_Password;
        private MaskedTextBox maskedTextBox_Password;
        private TextBox textBox_Server;
    }
}

