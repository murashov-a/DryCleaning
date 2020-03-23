namespace DryCleaningClient.UI
{
    partial class UsersForm
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
            this.objectListView_Users = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Passport = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Role = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_IsAdmin = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_UserAdd = new System.Windows.Forms.Button();
            this.button_UserDelete = new System.Windows.Forms.Button();
            this.button_UserEdit = new System.Windows.Forms.Button();
            this.tabControl_Users = new System.Windows.Forms.TabControl();
            this.tabPage_Users = new System.Windows.Forms.TabPage();
            this.tabPage_Roles = new System.Windows.Forms.TabPage();
            this.button_RoleAdd = new System.Windows.Forms.Button();
            this.button_RoleDelete = new System.Windows.Forms.Button();
            this.button_RoleEdit = new System.Windows.Forms.Button();
            this.objectListView_Roles = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_RoleName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_RoleSalary = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Users)).BeginInit();
            this.tabControl_Users.SuspendLayout();
            this.tabPage_Users.SuspendLayout();
            this.tabPage_Roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView_Users
            // 
            this.objectListView_Users.AllColumns.Add(this.olvColumn_Passport);
            this.objectListView_Users.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Users.AllColumns.Add(this.olvColumn_Role);
            this.objectListView_Users.AllColumns.Add(this.olvColumn_IsAdmin);
            this.objectListView_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Users.CellEditUseWholeCell = false;
            this.objectListView_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Passport,
            this.olvColumn_Name,
            this.olvColumn_Role,
            this.olvColumn_IsAdmin});
            this.objectListView_Users.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Users.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView_Users.FullRowSelect = true;
            this.objectListView_Users.HideSelection = false;
            this.objectListView_Users.Location = new System.Drawing.Point(0, 0);
            this.objectListView_Users.MultiSelect = false;
            this.objectListView_Users.Name = "objectListView_Users";
            this.objectListView_Users.ShowGroups = false;
            this.objectListView_Users.Size = new System.Drawing.Size(792, 375);
            this.objectListView_Users.TabIndex = 0;
            this.objectListView_Users.UseCompatibleStateImageBehavior = false;
            this.objectListView_Users.View = System.Windows.Forms.View.Details;
            this.objectListView_Users.SelectedIndexChanged += new System.EventHandler(this.objectListView_Users_SelectedIndexChanged);
            // 
            // olvColumn_Passport
            // 
            this.olvColumn_Passport.AspectName = "PassportID";
            this.olvColumn_Passport.Text = "Номер паспорта";
            this.olvColumn_Passport.Width = 124;
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "ФИО";
            this.olvColumn_Name.Width = 300;
            // 
            // olvColumn_Role
            // 
            this.olvColumn_Role.AspectName = "Role";
            this.olvColumn_Role.Text = "Должность";
            this.olvColumn_Role.Width = 159;
            // 
            // olvColumn_IsAdmin
            // 
            this.olvColumn_IsAdmin.AspectName = "IsAdmin";
            this.olvColumn_IsAdmin.Text = "Администратор системы";
            this.olvColumn_IsAdmin.Width = 200;
            // 
            // button_UserAdd
            // 
            this.button_UserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_UserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UserAdd.Location = new System.Drawing.Point(6, 381);
            this.button_UserAdd.Name = "button_UserAdd";
            this.button_UserAdd.Size = new System.Drawing.Size(150, 30);
            this.button_UserAdd.TabIndex = 1;
            this.button_UserAdd.Text = "Добавить";
            this.button_UserAdd.UseVisualStyleBackColor = true;
            this.button_UserAdd.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_UserDelete
            // 
            this.button_UserDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UserDelete.Enabled = false;
            this.button_UserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UserDelete.Location = new System.Drawing.Point(634, 381);
            this.button_UserDelete.Name = "button_UserDelete";
            this.button_UserDelete.Size = new System.Drawing.Size(150, 30);
            this.button_UserDelete.TabIndex = 2;
            this.button_UserDelete.Text = "Удалить";
            this.button_UserDelete.UseVisualStyleBackColor = true;
            this.button_UserDelete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_UserEdit
            // 
            this.button_UserEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_UserEdit.Enabled = false;
            this.button_UserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UserEdit.Location = new System.Drawing.Point(330, 381);
            this.button_UserEdit.Name = "button_UserEdit";
            this.button_UserEdit.Size = new System.Drawing.Size(150, 30);
            this.button_UserEdit.TabIndex = 3;
            this.button_UserEdit.Text = "Редактировать";
            this.button_UserEdit.UseVisualStyleBackColor = true;
            this.button_UserEdit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // tabControl_Users
            // 
            this.tabControl_Users.Controls.Add(this.tabPage_Users);
            this.tabControl_Users.Controls.Add(this.tabPage_Roles);
            this.tabControl_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_Users.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Users.Name = "tabControl_Users";
            this.tabControl_Users.SelectedIndex = 0;
            this.tabControl_Users.Size = new System.Drawing.Size(800, 450);
            this.tabControl_Users.TabIndex = 5;
            // 
            // tabPage_Users
            // 
            this.tabPage_Users.Controls.Add(this.objectListView_Users);
            this.tabPage_Users.Controls.Add(this.button_UserAdd);
            this.tabPage_Users.Controls.Add(this.button_UserDelete);
            this.tabPage_Users.Controls.Add(this.button_UserEdit);
            this.tabPage_Users.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Users.Name = "tabPage_Users";
            this.tabPage_Users.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Users.Size = new System.Drawing.Size(792, 417);
            this.tabPage_Users.TabIndex = 0;
            this.tabPage_Users.Text = "Сотрудники";
            this.tabPage_Users.UseVisualStyleBackColor = true;
            // 
            // tabPage_Roles
            // 
            this.tabPage_Roles.Controls.Add(this.button_RoleAdd);
            this.tabPage_Roles.Controls.Add(this.button_RoleDelete);
            this.tabPage_Roles.Controls.Add(this.button_RoleEdit);
            this.tabPage_Roles.Controls.Add(this.objectListView_Roles);
            this.tabPage_Roles.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Roles.Name = "tabPage_Roles";
            this.tabPage_Roles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Roles.Size = new System.Drawing.Size(792, 417);
            this.tabPage_Roles.TabIndex = 1;
            this.tabPage_Roles.Text = "Должности";
            this.tabPage_Roles.UseVisualStyleBackColor = true;
            // 
            // button_RoleAdd
            // 
            this.button_RoleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_RoleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RoleAdd.Location = new System.Drawing.Point(6, 379);
            this.button_RoleAdd.Name = "button_RoleAdd";
            this.button_RoleAdd.Size = new System.Drawing.Size(150, 30);
            this.button_RoleAdd.TabIndex = 4;
            this.button_RoleAdd.Text = "Добавить";
            this.button_RoleAdd.UseVisualStyleBackColor = true;
            this.button_RoleAdd.Click += new System.EventHandler(this.button_RoleAdd_Click);
            // 
            // button_RoleDelete
            // 
            this.button_RoleDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RoleDelete.Enabled = false;
            this.button_RoleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RoleDelete.Location = new System.Drawing.Point(634, 379);
            this.button_RoleDelete.Name = "button_RoleDelete";
            this.button_RoleDelete.Size = new System.Drawing.Size(150, 30);
            this.button_RoleDelete.TabIndex = 5;
            this.button_RoleDelete.Text = "Удалить";
            this.button_RoleDelete.UseVisualStyleBackColor = true;
            this.button_RoleDelete.Click += new System.EventHandler(this.button_RoleDelete_Click);
            // 
            // button_RoleEdit
            // 
            this.button_RoleEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_RoleEdit.Enabled = false;
            this.button_RoleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RoleEdit.Location = new System.Drawing.Point(330, 379);
            this.button_RoleEdit.Name = "button_RoleEdit";
            this.button_RoleEdit.Size = new System.Drawing.Size(150, 30);
            this.button_RoleEdit.TabIndex = 6;
            this.button_RoleEdit.Text = "Редактировать";
            this.button_RoleEdit.UseVisualStyleBackColor = true;
            this.button_RoleEdit.Click += new System.EventHandler(this.button_RoleEdit_Click);
            // 
            // objectListView_Roles
            // 
            this.objectListView_Roles.AllColumns.Add(this.olvColumn_RoleName);
            this.objectListView_Roles.AllColumns.Add(this.olvColumn_RoleSalary);
            this.objectListView_Roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Roles.CellEditUseWholeCell = false;
            this.objectListView_Roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_RoleName,
            this.olvColumn_RoleSalary});
            this.objectListView_Roles.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Roles.FullRowSelect = true;
            this.objectListView_Roles.HideSelection = false;
            this.objectListView_Roles.Location = new System.Drawing.Point(-4, 0);
            this.objectListView_Roles.MultiSelect = false;
            this.objectListView_Roles.Name = "objectListView_Roles";
            this.objectListView_Roles.ShowGroups = false;
            this.objectListView_Roles.Size = new System.Drawing.Size(796, 373);
            this.objectListView_Roles.TabIndex = 0;
            this.objectListView_Roles.UseCompatibleStateImageBehavior = false;
            this.objectListView_Roles.View = System.Windows.Forms.View.Details;
            this.objectListView_Roles.SelectedIndexChanged += new System.EventHandler(this.objectListView_Roles_SelectedIndexChanged);
            // 
            // olvColumn_RoleName
            // 
            this.olvColumn_RoleName.AspectName = "Name";
            this.olvColumn_RoleName.Text = "Название";
            this.olvColumn_RoleName.Width = 564;
            // 
            // olvColumn_RoleSalary
            // 
            this.olvColumn_RoleSalary.AspectName = "Salary";
            this.olvColumn_RoleSalary.Text = "Зарплата";
            this.olvColumn_RoleSalary.Width = 213;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_Users);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Users)).EndInit();
            this.tabControl_Users.ResumeLayout(false);
            this.tabPage_Users.ResumeLayout(false);
            this.tabPage_Roles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView_Users;
        private BrightIdeasSoftware.OLVColumn olvColumn_Passport;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumn_Role;
        private BrightIdeasSoftware.OLVColumn olvColumn_IsAdmin;
        private System.Windows.Forms.Button button_UserAdd;
        private System.Windows.Forms.Button button_UserDelete;
        private System.Windows.Forms.Button button_UserEdit;
        private System.Windows.Forms.TabControl tabControl_Users;
        private System.Windows.Forms.TabPage tabPage_Users;
        private System.Windows.Forms.TabPage tabPage_Roles;
        private BrightIdeasSoftware.ObjectListView objectListView_Roles;
        private BrightIdeasSoftware.OLVColumn olvColumn_RoleName;
        private BrightIdeasSoftware.OLVColumn olvColumn_RoleSalary;
        private System.Windows.Forms.Button button_RoleAdd;
        private System.Windows.Forms.Button button_RoleDelete;
        private System.Windows.Forms.Button button_RoleEdit;
    }
}