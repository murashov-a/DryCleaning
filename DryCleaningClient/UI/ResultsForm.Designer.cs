namespace DryCleaningClient.UI
{
    partial class ResultsForm
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
            this.objectListView_Results = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_ResultAdd = new System.Windows.Forms.Button();
            this.button_ResultDelete = new System.Windows.Forms.Button();
            this.button_ResultEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_Results
            // 
            this.objectListView_Results.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Results.CellEditUseWholeCell = false;
            this.objectListView_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name});
            this.objectListView_Results.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Results.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView_Results.FullRowSelect = true;
            this.objectListView_Results.HideSelection = false;
            this.objectListView_Results.Location = new System.Drawing.Point(12, 12);
            this.objectListView_Results.MultiSelect = false;
            this.objectListView_Results.Name = "objectListView_Results";
            this.objectListView_Results.ShowGroups = false;
            this.objectListView_Results.Size = new System.Drawing.Size(776, 390);
            this.objectListView_Results.TabIndex = 12;
            this.objectListView_Results.UseCompatibleStateImageBehavior = false;
            this.objectListView_Results.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Название";
            this.olvColumn_Name.Width = 771;
            // 
            // button_ResultAdd
            // 
            this.button_ResultAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ResultAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ResultAdd.Location = new System.Drawing.Point(12, 408);
            this.button_ResultAdd.Name = "button_ResultAdd";
            this.button_ResultAdd.Size = new System.Drawing.Size(150, 30);
            this.button_ResultAdd.TabIndex = 13;
            this.button_ResultAdd.Text = "Добавить";
            this.button_ResultAdd.UseVisualStyleBackColor = true;
            this.button_ResultAdd.Click += new System.EventHandler(this.button_ResultAdd_Click);
            // 
            // button_ResultDelete
            // 
            this.button_ResultDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ResultDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ResultDelete.Location = new System.Drawing.Point(638, 408);
            this.button_ResultDelete.Name = "button_ResultDelete";
            this.button_ResultDelete.Size = new System.Drawing.Size(150, 30);
            this.button_ResultDelete.TabIndex = 14;
            this.button_ResultDelete.Text = "Удалить";
            this.button_ResultDelete.UseVisualStyleBackColor = true;
            this.button_ResultDelete.Click += new System.EventHandler(this.button_ResultDelete_Click);
            // 
            // button_ResultEdit
            // 
            this.button_ResultEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ResultEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ResultEdit.Location = new System.Drawing.Point(326, 408);
            this.button_ResultEdit.Name = "button_ResultEdit";
            this.button_ResultEdit.Size = new System.Drawing.Size(150, 30);
            this.button_ResultEdit.TabIndex = 15;
            this.button_ResultEdit.Text = "Редактировать";
            this.button_ResultEdit.UseVisualStyleBackColor = true;
            this.button_ResultEdit.Click += new System.EventHandler(this.button_ResultEdit_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.objectListView_Results);
            this.Controls.Add(this.button_ResultAdd);
            this.Controls.Add(this.button_ResultDelete);
            this.Controls.Add(this.button_ResultEdit);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты чистки";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_Results;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private System.Windows.Forms.Button button_ResultAdd;
        private System.Windows.Forms.Button button_ResultDelete;
        private System.Windows.Forms.Button button_ResultEdit;
    }
}