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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_PasspordID = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_PassportID = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93814F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06186F));
            this.tableLayoutPanel1.Controls.Add(this.label_PasspordID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PassportID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox_Password, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_PasspordID
            // 
            this.label_PasspordID.AutoSize = true;
            this.label_PasspordID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PasspordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PasspordID.Location = new System.Drawing.Point(3, 0);
            this.label_PasspordID.Name = "label_PasspordID";
            this.label_PasspordID.Size = new System.Drawing.Size(168, 36);
            this.label_PasspordID.TabIndex = 0;
            this.label_PasspordID.Text = "Номер паспорта";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.Location = new System.Drawing.Point(3, 36);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(168, 36);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Пароль";
            // 
            // textBox_PassportID
            // 
            this.textBox_PassportID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PassportID.Location = new System.Drawing.Point(177, 3);
            this.textBox_PassportID.Name = "textBox_PassportID";
            this.textBox_PassportID.Size = new System.Drawing.Size(580, 29);
            this.textBox_PassportID.TabIndex = 2;
            // 
            // maskedTextBox_Password
            // 
            this.maskedTextBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_Password.Location = new System.Drawing.Point(177, 39);
            this.maskedTextBox_Password.Name = "maskedTextBox_Password";
            this.maskedTextBox_Password.PasswordChar = '*';
            this.maskedTextBox_Password.Size = new System.Drawing.Size(580, 29);
            this.maskedTextBox_Password.TabIndex = 3;
            // 
            // button_Login
            // 
            this.button_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.Location = new System.Drawing.Point(12, 90);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(760, 29);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 131);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 170);
            this.MinimumSize = new System.Drawing.Size(800, 170);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label_PasspordID;
        private Label label_Password;
        private TextBox textBox_PassportID;
        private MaskedTextBox maskedTextBox_Password;
        private Button button_Login;
    }
}

