namespace DryCleaningClient.UI
{
    partial class ClientSettingsForm
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
            this.tableLayoutPanel_Profile = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Telephone = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Telephone = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Profile
            // 
            this.tableLayoutPanel_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Profile.ColumnCount = 2;
            this.tableLayoutPanel_Profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.03259F));
            this.tableLayoutPanel_Profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.96741F));
            this.tableLayoutPanel_Profile.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel_Profile.Controls.Add(this.label_Telephone, 0, 1);
            this.tableLayoutPanel_Profile.Controls.Add(this.textBox_Name, 1, 0);
            this.tableLayoutPanel_Profile.Controls.Add(this.textBox_Telephone, 1, 1);
            this.tableLayoutPanel_Profile.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_Profile.Name = "tableLayoutPanel_Profile";
            this.tableLayoutPanel_Profile.RowCount = 2;
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.Size = new System.Drawing.Size(491, 73);
            this.tableLayoutPanel_Profile.TabIndex = 4;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(112, 36);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "ФИО:";
            // 
            // label_Telephone
            // 
            this.label_Telephone.AutoSize = true;
            this.label_Telephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Telephone.Location = new System.Drawing.Point(3, 36);
            this.label_Telephone.Name = "label_Telephone";
            this.label_Telephone.Size = new System.Drawing.Size(112, 37);
            this.label_Telephone.TabIndex = 1;
            this.label_Telephone.Text = "Телефон:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(121, 3);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(367, 20);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.Text = "{0}";
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_Telephone
            // 
            this.textBox_Telephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Telephone.Location = new System.Drawing.Point(121, 39);
            this.textBox_Telephone.Name = "textBox_Telephone";
            this.textBox_Telephone.Size = new System.Drawing.Size(367, 20);
            this.textBox_Telephone.TabIndex = 3;
            this.textBox_Telephone.Text = "{0}";
            this.textBox_Telephone.TextChanged += new System.EventHandler(this.textBox_Telephone_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(9, 91);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(491, 30);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // ClientSettingsForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 133);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.tableLayoutPanel_Profile);
            this.Name = "ClientSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientSettingsForm_FormClosed);
            this.tableLayoutPanel_Profile.ResumeLayout(false);
            this.tableLayoutPanel_Profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Profile;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Telephone;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Telephone;
        private System.Windows.Forms.Button button_Save;
    }
}