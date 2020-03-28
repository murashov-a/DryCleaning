namespace DryCleaningClient.UI
{
    partial class ThingSettingsForm
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
            this.tableLayoutPanel_Thing = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Material = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_CleaningOrder = new System.Windows.Forms.Label();
            this.comboBox_Material = new System.Windows.Forms.ComboBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.comboBox_CleaningOrder = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_Thing.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(13, 169);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(553, 46);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel_Thing
            // 
            this.tableLayoutPanel_Thing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Thing.ColumnCount = 2;
            this.tableLayoutPanel_Thing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Thing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Thing.Controls.Add(this.label_CleaningOrder, 0, 3);
            this.tableLayoutPanel_Thing.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel_Thing.Controls.Add(this.label_Material, 0, 1);
            this.tableLayoutPanel_Thing.Controls.Add(this.textBox_Name, 1, 0);
            this.tableLayoutPanel_Thing.Controls.Add(this.label_Type, 0, 2);
            this.tableLayoutPanel_Thing.Controls.Add(this.comboBox_Material, 1, 1);
            this.tableLayoutPanel_Thing.Controls.Add(this.comboBox_Type, 1, 2);
            this.tableLayoutPanel_Thing.Controls.Add(this.comboBox_CleaningOrder, 1, 3);
            this.tableLayoutPanel_Thing.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel_Thing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Thing.Name = "tableLayoutPanel_Thing";
            this.tableLayoutPanel_Thing.RowCount = 4;
            this.tableLayoutPanel_Thing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.31461F));
            this.tableLayoutPanel_Thing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.68539F));
            this.tableLayoutPanel_Thing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_Thing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_Thing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_Thing.Size = new System.Drawing.Size(553, 145);
            this.tableLayoutPanel_Thing.TabIndex = 12;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(4, 0);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(268, 34);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Название:";
            // 
            // label_Material
            // 
            this.label_Material.AutoSize = true;
            this.label_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Material.Location = new System.Drawing.Point(4, 34);
            this.label_Material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Material.Name = "label_Material";
            this.label_Material.Size = new System.Drawing.Size(268, 36);
            this.label_Material.TabIndex = 1;
            this.label_Material.Text = "Материал:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(280, 5);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(269, 26);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Type.Location = new System.Drawing.Point(4, 70);
            this.label_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(49, 24);
            this.label_Type.TabIndex = 8;
            this.label_Type.Text = "Тип:";
            // 
            // label_CleaningOrder
            // 
            this.label_CleaningOrder.AutoSize = true;
            this.label_CleaningOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CleaningOrder.Location = new System.Drawing.Point(4, 108);
            this.label_CleaningOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CleaningOrder.Name = "label_CleaningOrder";
            this.label_CleaningOrder.Size = new System.Drawing.Size(67, 24);
            this.label_CleaningOrder.TabIndex = 10;
            this.label_CleaningOrder.Text = "Заказ:";
            // 
            // comboBox_Material
            // 
            this.comboBox_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Material.FormattingEnabled = true;
            this.comboBox_Material.Location = new System.Drawing.Point(279, 37);
            this.comboBox_Material.Name = "comboBox_Material";
            this.comboBox_Material.Size = new System.Drawing.Size(271, 28);
            this.comboBox_Material.TabIndex = 11;
            this.comboBox_Material.SelectedIndexChanged += new System.EventHandler(this.comboBox_Material_SelectedIndexChanged);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(279, 73);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(271, 28);
            this.comboBox_Type.TabIndex = 12;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // comboBox_CleaningOrder
            // 
            this.comboBox_CleaningOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_CleaningOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CleaningOrder.FormattingEnabled = true;
            this.comboBox_CleaningOrder.Location = new System.Drawing.Point(279, 111);
            this.comboBox_CleaningOrder.Name = "comboBox_CleaningOrder";
            this.comboBox_CleaningOrder.Size = new System.Drawing.Size(271, 28);
            this.comboBox_CleaningOrder.TabIndex = 13;
            this.comboBox_CleaningOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox_CleaningOrder_SelectedIndexChanged);
            // 
            // ThingSettingsForm
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 229);
            this.Controls.Add(this.tableLayoutPanel_Thing);
            this.Controls.Add(this.button_Save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThingSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование вещи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThingSettingsForm_FormClosed);
            this.tableLayoutPanel_Thing.ResumeLayout(false);
            this.tableLayoutPanel_Thing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Thing;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Material;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_CleaningOrder;
        private System.Windows.Forms.ComboBox comboBox_Material;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.ComboBox comboBox_CleaningOrder;
    }
}