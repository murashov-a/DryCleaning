namespace DryCleaningClient.UI
{
    partial class ResultSettingsForm
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
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(10, 53);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(491, 30);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            this.tableLayoutPanel_Profile.Controls.Add(this.textBox_Name, 1, 0);
            this.tableLayoutPanel_Profile.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel_Profile.Name = "tableLayoutPanel_Profile";
            this.tableLayoutPanel_Profile.RowCount = 1;
            this.tableLayoutPanel_Profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Profile.Size = new System.Drawing.Size(491, 35);
            this.tableLayoutPanel_Profile.TabIndex = 7;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(112, 35);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Название:";
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
            // ResultSettingsForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 95);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.tableLayoutPanel_Profile);
            this.Name = "ResultSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование результата";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultSettingsForm_FormClosed);
            this.tableLayoutPanel_Profile.ResumeLayout(false);
            this.tableLayoutPanel_Profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Profile;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}