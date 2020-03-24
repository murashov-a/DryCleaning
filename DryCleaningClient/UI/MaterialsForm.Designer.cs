namespace DryCleaningClient.UI
{
    partial class MaterialsForm
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
            this.objectListView_Materials = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_MaterialAdd = new System.Windows.Forms.Button();
            this.button_MaterialDelete = new System.Windows.Forms.Button();
            this.button_MaterialEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Materials)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_Materials
            // 
            this.objectListView_Materials.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Materials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Materials.CellEditUseWholeCell = false;
            this.objectListView_Materials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name});
            this.objectListView_Materials.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Materials.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView_Materials.FullRowSelect = true;
            this.objectListView_Materials.HideSelection = false;
            this.objectListView_Materials.Location = new System.Drawing.Point(12, 12);
            this.objectListView_Materials.MultiSelect = false;
            this.objectListView_Materials.Name = "objectListView_Materials";
            this.objectListView_Materials.ShowGroups = false;
            this.objectListView_Materials.Size = new System.Drawing.Size(776, 390);
            this.objectListView_Materials.TabIndex = 8;
            this.objectListView_Materials.UseCompatibleStateImageBehavior = false;
            this.objectListView_Materials.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Название";
            this.olvColumn_Name.Width = 504;
            // 
            // button_MaterialAdd
            // 
            this.button_MaterialAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_MaterialAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MaterialAdd.Location = new System.Drawing.Point(12, 408);
            this.button_MaterialAdd.Name = "button_MaterialAdd";
            this.button_MaterialAdd.Size = new System.Drawing.Size(150, 30);
            this.button_MaterialAdd.TabIndex = 9;
            this.button_MaterialAdd.Text = "Добавить";
            this.button_MaterialAdd.UseVisualStyleBackColor = true;
            this.button_MaterialAdd.Click += new System.EventHandler(this.button_MaterialAdd_Click);
            // 
            // button_MaterialDelete
            // 
            this.button_MaterialDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MaterialDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MaterialDelete.Location = new System.Drawing.Point(638, 408);
            this.button_MaterialDelete.Name = "button_MaterialDelete";
            this.button_MaterialDelete.Size = new System.Drawing.Size(150, 30);
            this.button_MaterialDelete.TabIndex = 10;
            this.button_MaterialDelete.Text = "Удалить";
            this.button_MaterialDelete.UseVisualStyleBackColor = true;
            this.button_MaterialDelete.Click += new System.EventHandler(this.button_MaterialDelete_Click);
            // 
            // button_MaterialEdit
            // 
            this.button_MaterialEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_MaterialEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MaterialEdit.Location = new System.Drawing.Point(326, 408);
            this.button_MaterialEdit.Name = "button_MaterialEdit";
            this.button_MaterialEdit.Size = new System.Drawing.Size(150, 30);
            this.button_MaterialEdit.TabIndex = 11;
            this.button_MaterialEdit.Text = "Редактировать";
            this.button_MaterialEdit.UseVisualStyleBackColor = true;
            this.button_MaterialEdit.Click += new System.EventHandler(this.button_MaterialEdit_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.objectListView_Materials);
            this.Controls.Add(this.button_MaterialAdd);
            this.Controls.Add(this.button_MaterialDelete);
            this.Controls.Add(this.button_MaterialEdit);
            this.Name = "MaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Materials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_Materials;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private System.Windows.Forms.Button button_MaterialAdd;
        private System.Windows.Forms.Button button_MaterialDelete;
        private System.Windows.Forms.Button button_MaterialEdit;
    }
}