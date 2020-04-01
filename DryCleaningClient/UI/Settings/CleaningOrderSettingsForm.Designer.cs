namespace DryCleaningClient.UI
{
    partial class CleaningOrderSettingsForm
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
            this.tableLayoutPanel_Order = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ActualTerm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_TargetTerm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.label_DateOfReceipt = new System.Windows.Forms.Label();
            this.label_DateOfReturn = new System.Windows.Forms.Label();
            this.label_TargetTerm = new System.Windows.Forms.Label();
            this.label_ActualTerm = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.dateTimePicker_DateOfReceipt = new System.Windows.Forms.DateTimePicker();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(13, 214);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(746, 51);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel_Order
            // 
            this.tableLayoutPanel_Order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Order.ColumnCount = 2;
            this.tableLayoutPanel_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.27346F));
            this.tableLayoutPanel_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.72654F));
            this.tableLayoutPanel_Order.Controls.Add(this.comboBox_Client, 1, 5);
            this.tableLayoutPanel_Order.Controls.Add(this.dateTimePicker_ActualTerm, 1, 3);
            this.tableLayoutPanel_Order.Controls.Add(this.dateTimePicker_TargetTerm, 1, 2);
            this.tableLayoutPanel_Order.Controls.Add(this.dateTimePicker_DateOfReturn, 1, 1);
            this.tableLayoutPanel_Order.Controls.Add(this.label_DateOfReceipt, 0, 0);
            this.tableLayoutPanel_Order.Controls.Add(this.label_DateOfReturn, 0, 1);
            this.tableLayoutPanel_Order.Controls.Add(this.label_TargetTerm, 0, 2);
            this.tableLayoutPanel_Order.Controls.Add(this.label_ActualTerm, 0, 3);
            this.tableLayoutPanel_Order.Controls.Add(this.label_User, 0, 4);
            this.tableLayoutPanel_Order.Controls.Add(this.label_Client, 0, 5);
            this.tableLayoutPanel_Order.Controls.Add(this.dateTimePicker_DateOfReceipt, 1, 0);
            this.tableLayoutPanel_Order.Controls.Add(this.comboBox_User, 1, 4);
            this.tableLayoutPanel_Order.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel_Order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Order.Name = "tableLayoutPanel_Order";
            this.tableLayoutPanel_Order.RowCount = 6;
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel_Order.Size = new System.Drawing.Size(746, 190);
            this.tableLayoutPanel_Order.TabIndex = 10;
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(199, 160);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(544, 28);
            this.comboBox_Client.TabIndex = 13;
            this.comboBox_Client.SelectedIndexChanged += new System.EventHandler(this.comboBox_Client_SelectedIndexChanged);
            // 
            // dateTimePicker_ActualTerm
            // 
            this.dateTimePicker_ActualTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ActualTerm.Location = new System.Drawing.Point(199, 97);
            this.dateTimePicker_ActualTerm.Name = "dateTimePicker_ActualTerm";
            this.dateTimePicker_ActualTerm.ShowCheckBox = true;
            this.dateTimePicker_ActualTerm.Size = new System.Drawing.Size(544, 26);
            this.dateTimePicker_ActualTerm.TabIndex = 11;
            this.dateTimePicker_ActualTerm.ValueChanged += new System.EventHandler(this.dateTimePicker_ActualTerm_ValueChanged);
            // 
            // dateTimePicker_TargetTerm
            // 
            this.dateTimePicker_TargetTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_TargetTerm.Location = new System.Drawing.Point(199, 67);
            this.dateTimePicker_TargetTerm.Name = "dateTimePicker_TargetTerm";
            this.dateTimePicker_TargetTerm.Size = new System.Drawing.Size(544, 26);
            this.dateTimePicker_TargetTerm.TabIndex = 10;
            this.dateTimePicker_TargetTerm.ValueChanged += new System.EventHandler(this.dateTimePicker_TargetTerm_ValueChanged);
            // 
            // dateTimePicker_DateOfReturn
            // 
            this.dateTimePicker_DateOfReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_DateOfReturn.Location = new System.Drawing.Point(199, 35);
            this.dateTimePicker_DateOfReturn.Name = "dateTimePicker_DateOfReturn";
            this.dateTimePicker_DateOfReturn.ShowCheckBox = true;
            this.dateTimePicker_DateOfReturn.Size = new System.Drawing.Size(544, 26);
            this.dateTimePicker_DateOfReturn.TabIndex = 9;
            this.dateTimePicker_DateOfReturn.ValueChanged += new System.EventHandler(this.dateTimePicker_DateOfReturn_ValueChanged);
            // 
            // label_DateOfReceipt
            // 
            this.label_DateOfReceipt.AutoSize = true;
            this.label_DateOfReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DateOfReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateOfReceipt.Location = new System.Drawing.Point(4, 0);
            this.label_DateOfReceipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DateOfReceipt.Name = "label_DateOfReceipt";
            this.label_DateOfReceipt.Size = new System.Drawing.Size(188, 32);
            this.label_DateOfReceipt.TabIndex = 0;
            this.label_DateOfReceipt.Text = "Дата получения:";
            // 
            // label_DateOfReturn
            // 
            this.label_DateOfReturn.AutoSize = true;
            this.label_DateOfReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateOfReturn.Location = new System.Drawing.Point(3, 32);
            this.label_DateOfReturn.Name = "label_DateOfReturn";
            this.label_DateOfReturn.Size = new System.Drawing.Size(148, 24);
            this.label_DateOfReturn.TabIndex = 3;
            this.label_DateOfReturn.Text = "Дата возврата:";
            // 
            // label_TargetTerm
            // 
            this.label_TargetTerm.AutoSize = true;
            this.label_TargetTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TargetTerm.Location = new System.Drawing.Point(3, 64);
            this.label_TargetTerm.Name = "label_TargetTerm";
            this.label_TargetTerm.Size = new System.Drawing.Size(151, 24);
            this.label_TargetTerm.TabIndex = 4;
            this.label_TargetTerm.Text = "Плановый срок:";
            // 
            // label_ActualTerm
            // 
            this.label_ActualTerm.AutoSize = true;
            this.label_ActualTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ActualTerm.Location = new System.Drawing.Point(3, 94);
            this.label_ActualTerm.Name = "label_ActualTerm";
            this.label_ActualTerm.Size = new System.Drawing.Size(179, 24);
            this.label_ActualTerm.TabIndex = 5;
            this.label_ActualTerm.Text = "Фактический срок:";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User.Location = new System.Drawing.Point(3, 126);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(112, 24);
            this.label_User.TabIndex = 6;
            this.label_User.Text = "Сотрудник:";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Client.Location = new System.Drawing.Point(3, 157);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(80, 24);
            this.label_Client.TabIndex = 7;
            this.label_Client.Text = "Клиент:";
            // 
            // dateTimePicker_DateOfReceipt
            // 
            this.dateTimePicker_DateOfReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_DateOfReceipt.Location = new System.Drawing.Point(199, 3);
            this.dateTimePicker_DateOfReceipt.Name = "dateTimePicker_DateOfReceipt";
            this.dateTimePicker_DateOfReceipt.Size = new System.Drawing.Size(544, 26);
            this.dateTimePicker_DateOfReceipt.TabIndex = 8;
            this.dateTimePicker_DateOfReceipt.ValueChanged += new System.EventHandler(this.dateTimePicker_DateOfReceipt_ValueChanged);
            // 
            // comboBox_User
            // 
            this.comboBox_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(199, 129);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(544, 28);
            this.comboBox_User.TabIndex = 12;
            this.comboBox_User.SelectedIndexChanged += new System.EventHandler(this.comboBox_Users_SelectedIndexChanged);
            // 
            // CleaningOrderSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 279);
            this.Controls.Add(this.tableLayoutPanel_Order);
            this.Controls.Add(this.button_Save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CleaningOrderSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CleaningOrderSettingsForm_FormClosed);
            this.tableLayoutPanel_Order.ResumeLayout(false);
            this.tableLayoutPanel_Order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Order;
        private System.Windows.Forms.Label label_DateOfReceipt;
        private System.Windows.Forms.Label label_DateOfReturn;
        private System.Windows.Forms.Label label_TargetTerm;
        private System.Windows.Forms.Label label_ActualTerm;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfReceipt;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ActualTerm;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TargetTerm;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfReturn;
        private System.Windows.Forms.ComboBox comboBox_User;
    }
}