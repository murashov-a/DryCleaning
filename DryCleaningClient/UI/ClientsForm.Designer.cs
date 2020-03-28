namespace DryCleaningClient.UI
{
    partial class ClientsForm
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
            this.objectListView_Clients = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Telephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_ClientAdd = new System.Windows.Forms.Button();
            this.button_ClientDelete = new System.Windows.Forms.Button();
            this.button_ClientEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_Clients
            // 
            this.objectListView_Clients.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Clients.AllColumns.Add(this.olvColumn_Telephone);
            this.objectListView_Clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Clients.CellEditUseWholeCell = false;
            this.objectListView_Clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name,
            this.olvColumn_Telephone});
            this.objectListView_Clients.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Clients.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView_Clients.FullRowSelect = true;
            this.objectListView_Clients.HideSelection = false;
            this.objectListView_Clients.Location = new System.Drawing.Point(18, 18);
            this.objectListView_Clients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_Clients.MultiSelect = false;
            this.objectListView_Clients.Name = "objectListView_Clients";
            this.objectListView_Clients.ShowGroups = false;
            this.objectListView_Clients.Size = new System.Drawing.Size(1162, 598);
            this.objectListView_Clients.TabIndex = 4;
            this.objectListView_Clients.UseCompatibleStateImageBehavior = false;
            this.objectListView_Clients.View = System.Windows.Forms.View.Details;
            this.objectListView_Clients.SelectedIndexChanged += new System.EventHandler(this.objectListView_Clients_SelectedIndexChanged);
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "ФИО";
            this.olvColumn_Name.Width = 757;
            // 
            // olvColumn_Telephone
            // 
            this.olvColumn_Telephone.AspectName = "Telephone";
            this.olvColumn_Telephone.Text = "Телефон";
            this.olvColumn_Telephone.Width = 399;
            // 
            // button_ClientAdd
            // 
            this.button_ClientAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ClientAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ClientAdd.Location = new System.Drawing.Point(18, 628);
            this.button_ClientAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ClientAdd.Name = "button_ClientAdd";
            this.button_ClientAdd.Size = new System.Drawing.Size(225, 46);
            this.button_ClientAdd.TabIndex = 5;
            this.button_ClientAdd.Text = "Добавить";
            this.button_ClientAdd.UseVisualStyleBackColor = true;
            this.button_ClientAdd.Click += new System.EventHandler(this.button_ClientAdd_Click);
            // 
            // button_ClientDelete
            // 
            this.button_ClientDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClientDelete.Enabled = false;
            this.button_ClientDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ClientDelete.Location = new System.Drawing.Point(957, 628);
            this.button_ClientDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ClientDelete.Name = "button_ClientDelete";
            this.button_ClientDelete.Size = new System.Drawing.Size(225, 46);
            this.button_ClientDelete.TabIndex = 6;
            this.button_ClientDelete.Text = "Удалить";
            this.button_ClientDelete.UseVisualStyleBackColor = true;
            this.button_ClientDelete.Click += new System.EventHandler(this.button_ClientDelete_Click);
            // 
            // button_ClientEdit
            // 
            this.button_ClientEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ClientEdit.Enabled = false;
            this.button_ClientEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ClientEdit.Location = new System.Drawing.Point(489, 628);
            this.button_ClientEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ClientEdit.Name = "button_ClientEdit";
            this.button_ClientEdit.Size = new System.Drawing.Size(225, 46);
            this.button_ClientEdit.TabIndex = 7;
            this.button_ClientEdit.Text = "Редактировать";
            this.button_ClientEdit.UseVisualStyleBackColor = true;
            this.button_ClientEdit.Click += new System.EventHandler(this.button_ClientEdit_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.objectListView_Clients);
            this.Controls.Add(this.button_ClientAdd);
            this.Controls.Add(this.button_ClientDelete);
            this.Controls.Add(this.button_ClientEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_Clients;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumn_Telephone;
        private System.Windows.Forms.Button button_ClientAdd;
        private System.Windows.Forms.Button button_ClientDelete;
        private System.Windows.Forms.Button button_ClientEdit;
    }
}