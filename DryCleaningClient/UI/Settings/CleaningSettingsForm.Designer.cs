namespace DryCleaningClient.UI
{
    partial class CleaningSettingsForm
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
            this.tableLayoutPanel_Order = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_ChemicalAgent = new System.Windows.Forms.ComboBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.comboBox_Result = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Order
            // 
            this.tableLayoutPanel_Order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Order.ColumnCount = 2;
            this.tableLayoutPanel_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.27346F));
            this.tableLayoutPanel_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.72654F));
            this.tableLayoutPanel_Order.Controls.Add(this.comboBox_ChemicalAgent, 1, 3);
            this.tableLayoutPanel_Order.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel_Order.Controls.Add(this.label_Result, 0, 1);
            this.tableLayoutPanel_Order.Controls.Add(this.label_User, 0, 2);
            this.tableLayoutPanel_Order.Controls.Add(this.label_Client, 0, 3);
            this.tableLayoutPanel_Order.Controls.Add(this.dateTimePicker_Date, 1, 0);
            this.tableLayoutPanel_Order.Controls.Add(this.comboBox_User, 1, 2);
            this.tableLayoutPanel_Order.Controls.Add(this.comboBox_Result, 1, 1);
            this.tableLayoutPanel_Order.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel_Order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Order.Name = "tableLayoutPanel_Order";
            this.tableLayoutPanel_Order.RowCount = 4;
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Order.Size = new System.Drawing.Size(739, 128);
            this.tableLayoutPanel_Order.TabIndex = 11;
            // 
            // comboBox_ChemicalAgent
            // 
            this.comboBox_ChemicalAgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_ChemicalAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChemicalAgent.FormattingEnabled = true;
            this.comboBox_ChemicalAgent.Location = new System.Drawing.Point(197, 98);
            this.comboBox_ChemicalAgent.Name = "comboBox_ChemicalAgent";
            this.comboBox_ChemicalAgent.Size = new System.Drawing.Size(539, 21);
            this.comboBox_ChemicalAgent.TabIndex = 13;
            this.comboBox_ChemicalAgent.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChemicalAgent_SelectedIndexChanged);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Date.Location = new System.Drawing.Point(4, 0);
            this.label_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(186, 32);
            this.label_Date.TabIndex = 0;
            this.label_Date.Text = "Дата:";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Result.Location = new System.Drawing.Point(3, 32);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(108, 24);
            this.label_Result.TabIndex = 3;
            this.label_Result.Text = "Результат:";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User.Location = new System.Drawing.Point(3, 64);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(112, 24);
            this.label_User.TabIndex = 6;
            this.label_User.Text = "Сотрудник:";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Client.Location = new System.Drawing.Point(3, 95);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(142, 24);
            this.label_Client.TabIndex = 7;
            this.label_Client.Text = "Хим средство:";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(197, 3);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(539, 20);
            this.dateTimePicker_Date.TabIndex = 8;
            this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
            // 
            // comboBox_User
            // 
            this.comboBox_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(197, 67);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(539, 21);
            this.comboBox_User.TabIndex = 12;
            this.comboBox_User.SelectedIndexChanged += new System.EventHandler(this.comboBox_User_SelectedIndexChanged);
            // 
            // comboBox_Result
            // 
            this.comboBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Result.FormattingEnabled = true;
            this.comboBox_Result.Location = new System.Drawing.Point(197, 35);
            this.comboBox_Result.Name = "comboBox_Result";
            this.comboBox_Result.Size = new System.Drawing.Size(539, 21);
            this.comboBox_Result.TabIndex = 14;
            this.comboBox_Result.SelectedIndexChanged += new System.EventHandler(this.comboBox_Result_SelectedIndexChanged);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(13, 152);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(739, 51);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // CleaningSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 217);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.tableLayoutPanel_Order);
            this.Name = "CleaningSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование чистки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CleaningSettings_FormClosed);
            this.tableLayoutPanel_Order.ResumeLayout(false);
            this.tableLayoutPanel_Order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Order;
        private System.Windows.Forms.ComboBox comboBox_ChemicalAgent;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.ComboBox comboBox_Result;
        private System.Windows.Forms.Button button_Save;
    }
}