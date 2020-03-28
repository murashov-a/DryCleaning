namespace DryCleaningClient.UI
{
    partial class TypesForm
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
            this.objectListView_Types = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Compensation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CleaningPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_TypeAdd = new System.Windows.Forms.Button();
            this.button_TypeDelete = new System.Windows.Forms.Button();
            this.button_TypeEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Types)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_Types
            // 
            this.objectListView_Types.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Types.AllColumns.Add(this.olvColumn_Compensation);
            this.objectListView_Types.AllColumns.Add(this.olvColumn_CleaningPrice);
            this.objectListView_Types.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Types.CellEditUseWholeCell = false;
            this.objectListView_Types.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name,
            this.olvColumn_Compensation,
            this.olvColumn_CleaningPrice});
            this.objectListView_Types.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Types.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView_Types.FullRowSelect = true;
            this.objectListView_Types.HideSelection = false;
            this.objectListView_Types.Location = new System.Drawing.Point(18, 18);
            this.objectListView_Types.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_Types.MultiSelect = false;
            this.objectListView_Types.Name = "objectListView_Types";
            this.objectListView_Types.ShowGroups = false;
            this.objectListView_Types.Size = new System.Drawing.Size(1162, 598);
            this.objectListView_Types.TabIndex = 12;
            this.objectListView_Types.UseCompatibleStateImageBehavior = false;
            this.objectListView_Types.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Название";
            this.olvColumn_Name.Width = 685;
            // 
            // olvColumn_Compensation
            // 
            this.olvColumn_Compensation.AspectName = "Compensation";
            this.olvColumn_Compensation.Text = "Цена компенсации";
            this.olvColumn_Compensation.Width = 240;
            // 
            // olvColumn_CleaningPrice
            // 
            this.olvColumn_CleaningPrice.AspectName = "CleaningPrice";
            this.olvColumn_CleaningPrice.Text = "Цена чистки";
            this.olvColumn_CleaningPrice.Width = 234;
            // 
            // button_TypeAdd
            // 
            this.button_TypeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_TypeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TypeAdd.Location = new System.Drawing.Point(18, 628);
            this.button_TypeAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TypeAdd.Name = "button_TypeAdd";
            this.button_TypeAdd.Size = new System.Drawing.Size(225, 46);
            this.button_TypeAdd.TabIndex = 13;
            this.button_TypeAdd.Text = "Добавить";
            this.button_TypeAdd.UseVisualStyleBackColor = true;
            this.button_TypeAdd.Click += new System.EventHandler(this.button_TypeAdd_Click);
            // 
            // button_TypeDelete
            // 
            this.button_TypeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TypeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TypeDelete.Location = new System.Drawing.Point(957, 628);
            this.button_TypeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TypeDelete.Name = "button_TypeDelete";
            this.button_TypeDelete.Size = new System.Drawing.Size(225, 46);
            this.button_TypeDelete.TabIndex = 14;
            this.button_TypeDelete.Text = "Удалить";
            this.button_TypeDelete.UseVisualStyleBackColor = true;
            this.button_TypeDelete.Click += new System.EventHandler(this.button_TypeDelete_Click);
            // 
            // button_TypeEdit
            // 
            this.button_TypeEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_TypeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TypeEdit.Location = new System.Drawing.Point(489, 628);
            this.button_TypeEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TypeEdit.Name = "button_TypeEdit";
            this.button_TypeEdit.Size = new System.Drawing.Size(225, 46);
            this.button_TypeEdit.TabIndex = 15;
            this.button_TypeEdit.Text = "Редактировать";
            this.button_TypeEdit.UseVisualStyleBackColor = true;
            this.button_TypeEdit.Click += new System.EventHandler(this.button_TypeEdit_Click);
            // 
            // TypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.objectListView_Types);
            this.Controls.Add(this.button_TypeAdd);
            this.Controls.Add(this.button_TypeDelete);
            this.Controls.Add(this.button_TypeEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы вещей";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Types)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_Types;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private System.Windows.Forms.Button button_TypeAdd;
        private System.Windows.Forms.Button button_TypeDelete;
        private System.Windows.Forms.Button button_TypeEdit;
        private BrightIdeasSoftware.OLVColumn olvColumn_Compensation;
        private BrightIdeasSoftware.OLVColumn olvColumn_CleaningPrice;
    }
}