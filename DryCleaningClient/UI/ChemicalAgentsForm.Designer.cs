namespace DryCleaningClient.UI
{
    partial class ChemicalAgentsForm
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
            this.objectListView_ChemicalAgents = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_ChemicalAgentAdd = new System.Windows.Forms.Button();
            this.button_ChemicalAgentDelete = new System.Windows.Forms.Button();
            this.button_ChemicalAgentEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_ChemicalAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_ChemicalAgents
            // 
            this.objectListView_ChemicalAgents.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_ChemicalAgents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_ChemicalAgents.CellEditUseWholeCell = false;
            this.objectListView_ChemicalAgents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name});
            this.objectListView_ChemicalAgents.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_ChemicalAgents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView_ChemicalAgents.FullRowSelect = true;
            this.objectListView_ChemicalAgents.GridLines = true;
            this.objectListView_ChemicalAgents.HideSelection = false;
            this.objectListView_ChemicalAgents.Location = new System.Drawing.Point(18, 18);
            this.objectListView_ChemicalAgents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_ChemicalAgents.MultiSelect = false;
            this.objectListView_ChemicalAgents.Name = "objectListView_ChemicalAgents";
            this.objectListView_ChemicalAgents.ShowGroups = false;
            this.objectListView_ChemicalAgents.Size = new System.Drawing.Size(1162, 598);
            this.objectListView_ChemicalAgents.TabIndex = 16;
            this.objectListView_ChemicalAgents.UseCompatibleStateImageBehavior = false;
            this.objectListView_ChemicalAgents.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Название";
            this.olvColumn_Name.Width = 1155;
            // 
            // button_ChemicalAgentAdd
            // 
            this.button_ChemicalAgentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ChemicalAgentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChemicalAgentAdd.Location = new System.Drawing.Point(18, 628);
            this.button_ChemicalAgentAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ChemicalAgentAdd.Name = "button_ChemicalAgentAdd";
            this.button_ChemicalAgentAdd.Size = new System.Drawing.Size(225, 46);
            this.button_ChemicalAgentAdd.TabIndex = 17;
            this.button_ChemicalAgentAdd.Text = "Добавить";
            this.button_ChemicalAgentAdd.UseVisualStyleBackColor = true;
            this.button_ChemicalAgentAdd.Click += new System.EventHandler(this.button_ChemicalAgentAdd_Click);
            // 
            // button_ChemicalAgentDelete
            // 
            this.button_ChemicalAgentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChemicalAgentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChemicalAgentDelete.Location = new System.Drawing.Point(957, 628);
            this.button_ChemicalAgentDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ChemicalAgentDelete.Name = "button_ChemicalAgentDelete";
            this.button_ChemicalAgentDelete.Size = new System.Drawing.Size(225, 46);
            this.button_ChemicalAgentDelete.TabIndex = 18;
            this.button_ChemicalAgentDelete.Text = "Удалить";
            this.button_ChemicalAgentDelete.UseVisualStyleBackColor = true;
            this.button_ChemicalAgentDelete.Click += new System.EventHandler(this.button_ChemicalAgentDelete_Click);
            // 
            // button_ChemicalAgentEdit
            // 
            this.button_ChemicalAgentEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ChemicalAgentEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChemicalAgentEdit.Location = new System.Drawing.Point(489, 628);
            this.button_ChemicalAgentEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ChemicalAgentEdit.Name = "button_ChemicalAgentEdit";
            this.button_ChemicalAgentEdit.Size = new System.Drawing.Size(225, 46);
            this.button_ChemicalAgentEdit.TabIndex = 19;
            this.button_ChemicalAgentEdit.Text = "Редактировать";
            this.button_ChemicalAgentEdit.UseVisualStyleBackColor = true;
            this.button_ChemicalAgentEdit.Click += new System.EventHandler(this.button_ChemicalAgentEdit_Click);
            // 
            // ChemicalAgentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.objectListView_ChemicalAgents);
            this.Controls.Add(this.button_ChemicalAgentAdd);
            this.Controls.Add(this.button_ChemicalAgentDelete);
            this.Controls.Add(this.button_ChemicalAgentEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChemicalAgentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Химические средства";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_ChemicalAgents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_ChemicalAgents;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private System.Windows.Forms.Button button_ChemicalAgentAdd;
        private System.Windows.Forms.Button button_ChemicalAgentDelete;
        private System.Windows.Forms.Button button_ChemicalAgentEdit;
    }
}