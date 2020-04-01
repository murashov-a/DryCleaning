namespace DryCleaningClient.UI
{
    partial class TypeSettingsForm
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
            this.tableLayoutPanel_Type = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Compensation = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Compensation = new System.Windows.Forms.TextBox();
            this.label_CleaningPrice = new System.Windows.Forms.Label();
            this.textBox_CleaningPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(15, 160);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(543, 46);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel_Type
            // 
            this.tableLayoutPanel_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Type.ColumnCount = 2;
            this.tableLayoutPanel_Type.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Type.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Type.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel_Type.Controls.Add(this.label_Compensation, 0, 1);
            this.tableLayoutPanel_Type.Controls.Add(this.textBox_Name, 1, 0);
            this.tableLayoutPanel_Type.Controls.Add(this.textBox_Compensation, 1, 1);
            this.tableLayoutPanel_Type.Controls.Add(this.label_CleaningPrice, 0, 2);
            this.tableLayoutPanel_Type.Controls.Add(this.textBox_CleaningPrice, 1, 2);
            this.tableLayoutPanel_Type.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Type.Name = "tableLayoutPanel_Type";
            this.tableLayoutPanel_Type.RowCount = 3;
            this.tableLayoutPanel_Type.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Type.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Type.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel_Type.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_Type.Size = new System.Drawing.Size(540, 132);
            this.tableLayoutPanel_Type.TabIndex = 11;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(4, 0);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(262, 44);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Название:";
            // 
            // label_Compensation
            // 
            this.label_Compensation.AutoSize = true;
            this.label_Compensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Compensation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Compensation.Location = new System.Drawing.Point(4, 44);
            this.label_Compensation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Compensation.Name = "label_Compensation";
            this.label_Compensation.Size = new System.Drawing.Size(262, 44);
            this.label_Compensation.TabIndex = 1;
            this.label_Compensation.Text = "Компенсация:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(274, 5);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(262, 26);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.Text = "{0}";
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_Compensation
            // 
            this.textBox_Compensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Compensation.Location = new System.Drawing.Point(274, 49);
            this.textBox_Compensation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Compensation.Name = "textBox_Compensation";
            this.textBox_Compensation.Size = new System.Drawing.Size(262, 26);
            this.textBox_Compensation.TabIndex = 3;
            this.textBox_Compensation.Text = "{0}";
            this.textBox_Compensation.TextChanged += new System.EventHandler(this.textBox_Compensation_TextChanged);
            // 
            // label_CleaningPrice
            // 
            this.label_CleaningPrice.AutoSize = true;
            this.label_CleaningPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CleaningPrice.Location = new System.Drawing.Point(4, 88);
            this.label_CleaningPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CleaningPrice.Name = "label_CleaningPrice";
            this.label_CleaningPrice.Size = new System.Drawing.Size(125, 24);
            this.label_CleaningPrice.TabIndex = 8;
            this.label_CleaningPrice.Text = "Цена чистки:";
            // 
            // textBox_CleaningPrice
            // 
            this.textBox_CleaningPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_CleaningPrice.Location = new System.Drawing.Point(274, 93);
            this.textBox_CleaningPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CleaningPrice.Name = "textBox_CleaningPrice";
            this.textBox_CleaningPrice.Size = new System.Drawing.Size(262, 26);
            this.textBox_CleaningPrice.TabIndex = 9;
            this.textBox_CleaningPrice.Text = "{0}";
            this.textBox_CleaningPrice.TextChanged += new System.EventHandler(this.textBox_CleaningPrice_TextChanged);
            // 
            // TypeSettingsForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 225);
            this.Controls.Add(this.tableLayoutPanel_Type);
            this.Controls.Add(this.button_Save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TypeSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование типа вещи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypeSettingsForm_FormClosed);
            this.tableLayoutPanel_Type.ResumeLayout(false);
            this.tableLayoutPanel_Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Type;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Compensation;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Compensation;
        private System.Windows.Forms.Label label_CleaningPrice;
        private System.Windows.Forms.TextBox textBox_CleaningPrice;
    }
}