namespace DryCleaningClient.UI.Settings
{
    partial class CleaningThingsSettings
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
            this.objectListView_Things = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Material = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Type = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CleaningOrder = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Things)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_Things
            // 
            this.objectListView_Things.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Things.AllColumns.Add(this.olvColumn_Material);
            this.objectListView_Things.AllColumns.Add(this.olvColumn_Type);
            this.objectListView_Things.AllColumns.Add(this.olvColumn_CleaningOrder);
            this.objectListView_Things.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Things.CellEditUseWholeCell = false;
            this.objectListView_Things.CheckBoxes = true;
            this.objectListView_Things.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name,
            this.olvColumn_Material,
            this.olvColumn_Type});
            this.objectListView_Things.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Things.FullRowSelect = true;
            this.objectListView_Things.HideSelection = false;
            this.objectListView_Things.Location = new System.Drawing.Point(13, 14);
            this.objectListView_Things.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_Things.MultiSelect = false;
            this.objectListView_Things.Name = "objectListView_Things";
            this.objectListView_Things.Size = new System.Drawing.Size(1174, 687);
            this.objectListView_Things.TabIndex = 5;
            this.objectListView_Things.UseCompatibleStateImageBehavior = false;
            this.objectListView_Things.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Название";
            this.olvColumn_Name.Width = 229;
            // 
            // olvColumn_Material
            // 
            this.olvColumn_Material.AspectName = "Material";
            this.olvColumn_Material.Text = "Материал";
            this.olvColumn_Material.Width = 246;
            // 
            // olvColumn_Type
            // 
            this.olvColumn_Type.AspectName = "Type";
            this.olvColumn_Type.Text = "Тип";
            this.olvColumn_Type.Width = 208;
            // 
            // olvColumn_CleaningOrder
            // 
            this.olvColumn_CleaningOrder.AspectName = "CleaningOrder";
            this.olvColumn_CleaningOrder.DisplayIndex = 3;
            this.olvColumn_CleaningOrder.IsVisible = false;
            this.olvColumn_CleaningOrder.Text = "Номер заказа";
            this.olvColumn_CleaningOrder.Width = 88;
            // 
            // button_Ok
            // 
            this.button_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Ok.Location = new System.Drawing.Point(13, 709);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(1174, 30);
            this.button_Ok.TabIndex = 7;
            this.button_Ok.Text = "Выбрать";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // CleaningThingsSettings
            // 
            this.AcceptButton = this.button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 751);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.objectListView_Things);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CleaningThingsSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор вещей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CleaningThingsSettings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Things)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_Things;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumn_Material;
        private BrightIdeasSoftware.OLVColumn olvColumn_Type;
        private BrightIdeasSoftware.OLVColumn olvColumn_CleaningOrder;
        private System.Windows.Forms.Button button_Ok;
    }
}