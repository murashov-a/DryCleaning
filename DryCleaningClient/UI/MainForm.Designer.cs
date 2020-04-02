namespace DryCleaningClient.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Panel = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыВещейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.химСредстваcommingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Orders = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Orders = new System.Windows.Forms.GroupBox();
            this.button_OrderEdit = new System.Windows.Forms.Button();
            this.button_OrderDelete = new System.Windows.Forms.Button();
            this.button_OrderAdd = new System.Windows.Forms.Button();
            this.objectListView_Orders = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_DateOfReceipt = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_DateOfReturn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_TargetTerm = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ActualTerm = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_OrderEmployee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Client = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox_Things = new System.Windows.Forms.GroupBox();
            this.button_ThingEdit = new System.Windows.Forms.Button();
            this.button_ThingDelete = new System.Windows.Forms.Button();
            this.button_ThingAdd = new System.Windows.Forms.Button();
            this.objectListView_Things = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Material = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Type = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox_Cleanings = new System.Windows.Forms.GroupBox();
            this.treeListView_Cleanings = new BrightIdeasSoftware.TreeListView();
            this.olvColumn_DateOrThing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Result = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CleaningEmployee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ChemicalAgent = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_DeleteCleaning = new System.Windows.Forms.Button();
            this.button_EditCleaning = new System.Windows.Forms.Button();
            this.button_AddCleaning = new System.Windows.Forms.Button();
            this.toolTip_DragDropThingHelp = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip_Panel.SuspendLayout();
            this.tableLayoutPanel_Orders.SuspendLayout();
            this.groupBox_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Orders)).BeginInit();
            this.groupBox_Things.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Things)).BeginInit();
            this.groupBox_Cleanings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView_Cleanings)).BeginInit();
            this.SuspendLayout();
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERNAMEToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem});
            this.nameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.nameToolStripMenuItem.Text = "Профиль";
            this.nameToolStripMenuItem.DropDownOpening += new System.EventHandler(this.nameToolStripMenuItem_DropDownOpening);
            // 
            // uSERNAMEToolStripMenuItem
            // 
            this.uSERNAMEToolStripMenuItem.Enabled = false;
            this.uSERNAMEToolStripMenuItem.Name = "uSERNAMEToolStripMenuItem";
            this.uSERNAMEToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.uSERNAMEToolStripMenuItem.Text = "USER_NAME";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.logoutToolStripMenuItem.Text = "Выход";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // menuStrip_Panel
            // 
            this.menuStrip_Panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.материалыToolStripMenuItem,
            this.типыВещейToolStripMenuItem,
            this.результатыToolStripMenuItem,
            this.химСредстваcommingSoonToolStripMenuItem});
            this.menuStrip_Panel.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Panel.Name = "menuStrip_Panel";
            this.menuStrip_Panel.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip_Panel.Size = new System.Drawing.Size(1458, 31);
            this.menuStrip_Panel.TabIndex = 0;
            this.menuStrip_Panel.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.материалыToolStripMenuItem.Text = "Материалы";
            this.материалыToolStripMenuItem.Click += new System.EventHandler(this.материалыToolStripMenuItem_Click);
            // 
            // типыВещейToolStripMenuItem
            // 
            this.типыВещейToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.типыВещейToolStripMenuItem.Name = "типыВещейToolStripMenuItem";
            this.типыВещейToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.типыВещейToolStripMenuItem.Text = "Типы вещей";
            this.типыВещейToolStripMenuItem.Click += new System.EventHandler(this.типыВещейToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // химСредстваcommingSoonToolStripMenuItem
            // 
            this.химСредстваcommingSoonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.химСредстваcommingSoonToolStripMenuItem.Name = "химСредстваcommingSoonToolStripMenuItem";
            this.химСредстваcommingSoonToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.химСредстваcommingSoonToolStripMenuItem.Text = "Хим средства";
            this.химСредстваcommingSoonToolStripMenuItem.Click += new System.EventHandler(this.химСредстваcommingSoonToolStripMenuItem_Click);
            // 
            // tableLayoutPanel_Orders
            // 
            this.tableLayoutPanel_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Orders.ColumnCount = 1;
            this.tableLayoutPanel_Orders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.77657F));
            this.tableLayoutPanel_Orders.Controls.Add(this.groupBox_Orders, 0, 0);
            this.tableLayoutPanel_Orders.Controls.Add(this.groupBox_Things, 0, 1);
            this.tableLayoutPanel_Orders.Controls.Add(this.groupBox_Cleanings, 0, 2);
            this.tableLayoutPanel_Orders.Location = new System.Drawing.Point(12, 34);
            this.tableLayoutPanel_Orders.Name = "tableLayoutPanel_Orders";
            this.tableLayoutPanel_Orders.RowCount = 3;
            this.tableLayoutPanel_Orders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Orders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel_Orders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel_Orders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Orders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Orders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Orders.Size = new System.Drawing.Size(1434, 857);
            this.tableLayoutPanel_Orders.TabIndex = 1;
            // 
            // groupBox_Orders
            // 
            this.groupBox_Orders.Controls.Add(this.button_OrderEdit);
            this.groupBox_Orders.Controls.Add(this.button_OrderDelete);
            this.groupBox_Orders.Controls.Add(this.button_OrderAdd);
            this.groupBox_Orders.Controls.Add(this.objectListView_Orders);
            this.groupBox_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Orders.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Orders.Name = "groupBox_Orders";
            this.groupBox_Orders.Size = new System.Drawing.Size(1428, 352);
            this.groupBox_Orders.TabIndex = 0;
            this.groupBox_Orders.TabStop = false;
            this.groupBox_Orders.Text = "Заказы";
            // 
            // button_OrderEdit
            // 
            this.button_OrderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OrderEdit.Location = new System.Drawing.Point(112, 316);
            this.button_OrderEdit.Name = "button_OrderEdit";
            this.button_OrderEdit.Size = new System.Drawing.Size(1204, 30);
            this.button_OrderEdit.TabIndex = 3;
            this.button_OrderEdit.Text = "Редактировать";
            this.button_OrderEdit.UseVisualStyleBackColor = true;
            this.button_OrderEdit.Click += new System.EventHandler(this.button_OrderEdit_Click);
            // 
            // button_OrderDelete
            // 
            this.button_OrderDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OrderDelete.Location = new System.Drawing.Point(1322, 316);
            this.button_OrderDelete.Name = "button_OrderDelete";
            this.button_OrderDelete.Size = new System.Drawing.Size(100, 30);
            this.button_OrderDelete.TabIndex = 2;
            this.button_OrderDelete.Text = "Удалить";
            this.button_OrderDelete.UseVisualStyleBackColor = true;
            this.button_OrderDelete.Click += new System.EventHandler(this.button_OrderDelete_Click);
            // 
            // button_OrderAdd
            // 
            this.button_OrderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_OrderAdd.Location = new System.Drawing.Point(6, 316);
            this.button_OrderAdd.Name = "button_OrderAdd";
            this.button_OrderAdd.Size = new System.Drawing.Size(100, 30);
            this.button_OrderAdd.TabIndex = 1;
            this.button_OrderAdd.Text = "Добавить";
            this.button_OrderAdd.UseVisualStyleBackColor = true;
            this.button_OrderAdd.Click += new System.EventHandler(this.button_OrderAdd_Click);
            // 
            // objectListView_Orders
            // 
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_ID);
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_DateOfReceipt);
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_DateOfReturn);
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_TargetTerm);
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_ActualTerm);
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_OrderEmployee);
            this.objectListView_Orders.AllColumns.Add(this.olvColumn_Client);
            this.objectListView_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Orders.CellEditUseWholeCell = false;
            this.objectListView_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_ID,
            this.olvColumn_DateOfReceipt,
            this.olvColumn_DateOfReturn,
            this.olvColumn_TargetTerm,
            this.olvColumn_ActualTerm,
            this.olvColumn_OrderEmployee,
            this.olvColumn_Client});
            this.objectListView_Orders.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Orders.FullRowSelect = true;
            this.objectListView_Orders.GridLines = true;
            this.objectListView_Orders.HideSelection = false;
            this.objectListView_Orders.Location = new System.Drawing.Point(6, 25);
            this.objectListView_Orders.MultiSelect = false;
            this.objectListView_Orders.Name = "objectListView_Orders";
            this.objectListView_Orders.ShowGroups = false;
            this.objectListView_Orders.Size = new System.Drawing.Size(1419, 285);
            this.objectListView_Orders.TabIndex = 0;
            this.objectListView_Orders.UseCompatibleStateImageBehavior = false;
            this.objectListView_Orders.View = System.Windows.Forms.View.Details;
            this.objectListView_Orders.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListView_Orders_ItemsChanged);
            this.objectListView_Orders.SelectedIndexChanged += new System.EventHandler(this.objectListView_Orders_SelectedIndexChanged);
            // 
            // olvColumn_ID
            // 
            this.olvColumn_ID.AspectName = "ID";
            this.olvColumn_ID.Text = "Номер";
            this.olvColumn_ID.Width = 74;
            // 
            // olvColumn_DateOfReceipt
            // 
            this.olvColumn_DateOfReceipt.AspectName = "DateOfReceipt";
            this.olvColumn_DateOfReceipt.Text = "Дата получения";
            this.olvColumn_DateOfReceipt.Width = 177;
            // 
            // olvColumn_DateOfReturn
            // 
            this.olvColumn_DateOfReturn.AspectName = "DateOfReturn";
            this.olvColumn_DateOfReturn.Text = "Дата возврата";
            this.olvColumn_DateOfReturn.Width = 166;
            // 
            // olvColumn_TargetTerm
            // 
            this.olvColumn_TargetTerm.AspectName = "TargetTerm";
            this.olvColumn_TargetTerm.Text = "Плановый срок";
            this.olvColumn_TargetTerm.Width = 184;
            // 
            // olvColumn_ActualTerm
            // 
            this.olvColumn_ActualTerm.AspectName = "ActualTerm";
            this.olvColumn_ActualTerm.Text = "Фактический срок";
            this.olvColumn_ActualTerm.Width = 202;
            // 
            // olvColumn_OrderEmployee
            // 
            this.olvColumn_OrderEmployee.AspectName = "";
            this.olvColumn_OrderEmployee.Text = "Сотрудник";
            this.olvColumn_OrderEmployee.Width = 312;
            // 
            // olvColumn_Client
            // 
            this.olvColumn_Client.AspectName = "";
            this.olvColumn_Client.Text = "Клиент";
            this.olvColumn_Client.Width = 298;
            // 
            // groupBox_Things
            // 
            this.groupBox_Things.Controls.Add(this.button_ThingEdit);
            this.groupBox_Things.Controls.Add(this.button_ThingDelete);
            this.groupBox_Things.Controls.Add(this.button_ThingAdd);
            this.groupBox_Things.Controls.Add(this.objectListView_Things);
            this.groupBox_Things.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Things.Location = new System.Drawing.Point(3, 361);
            this.groupBox_Things.Name = "groupBox_Things";
            this.groupBox_Things.Size = new System.Drawing.Size(1428, 248);
            this.groupBox_Things.TabIndex = 1;
            this.groupBox_Things.TabStop = false;
            this.groupBox_Things.Text = "Вещи заказа";
            // 
            // button_ThingEdit
            // 
            this.button_ThingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ThingEdit.Enabled = false;
            this.button_ThingEdit.Location = new System.Drawing.Point(112, 212);
            this.button_ThingEdit.Name = "button_ThingEdit";
            this.button_ThingEdit.Size = new System.Drawing.Size(1204, 30);
            this.button_ThingEdit.TabIndex = 7;
            this.button_ThingEdit.Text = "Редактировать";
            this.button_ThingEdit.UseVisualStyleBackColor = true;
            this.button_ThingEdit.Click += new System.EventHandler(this.button_ThingEdit_Click);
            // 
            // button_ThingDelete
            // 
            this.button_ThingDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ThingDelete.Enabled = false;
            this.button_ThingDelete.Location = new System.Drawing.Point(1322, 212);
            this.button_ThingDelete.Name = "button_ThingDelete";
            this.button_ThingDelete.Size = new System.Drawing.Size(100, 30);
            this.button_ThingDelete.TabIndex = 6;
            this.button_ThingDelete.Text = "Удалить";
            this.button_ThingDelete.UseVisualStyleBackColor = true;
            this.button_ThingDelete.Click += new System.EventHandler(this.button_ThingDelete_Click);
            // 
            // button_ThingAdd
            // 
            this.button_ThingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ThingAdd.Location = new System.Drawing.Point(6, 212);
            this.button_ThingAdd.Name = "button_ThingAdd";
            this.button_ThingAdd.Size = new System.Drawing.Size(100, 30);
            this.button_ThingAdd.TabIndex = 5;
            this.button_ThingAdd.Text = "Добавить";
            this.button_ThingAdd.UseVisualStyleBackColor = true;
            this.button_ThingAdd.Click += new System.EventHandler(this.button_ThingAdd_Click);
            // 
            // objectListView_Things
            // 
            this.objectListView_Things.AllColumns.Add(this.olvColumn_Name);
            this.objectListView_Things.AllColumns.Add(this.olvColumn_Material);
            this.objectListView_Things.AllColumns.Add(this.olvColumn_Type);
            this.objectListView_Things.AllowDrop = true;
            this.objectListView_Things.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Things.CellEditUseWholeCell = false;
            this.objectListView_Things.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Name,
            this.olvColumn_Material,
            this.olvColumn_Type});
            this.objectListView_Things.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Things.FullRowSelect = true;
            this.objectListView_Things.GridLines = true;
            this.objectListView_Things.HideSelection = false;
            this.objectListView_Things.Location = new System.Drawing.Point(6, 25);
            this.objectListView_Things.MultiSelect = false;
            this.objectListView_Things.Name = "objectListView_Things";
            this.objectListView_Things.ShowGroups = false;
            this.objectListView_Things.Size = new System.Drawing.Size(1419, 181);
            this.objectListView_Things.TabIndex = 4;
            this.objectListView_Things.UseCompatibleStateImageBehavior = false;
            this.objectListView_Things.View = System.Windows.Forms.View.Details;
            this.objectListView_Things.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListView_Things_ItemsChanged);
            this.objectListView_Things.SelectedIndexChanged += new System.EventHandler(this.objectListView_Things_SelectedIndexChanged);
            this.objectListView_Things.MouseDown += new System.Windows.Forms.MouseEventHandler(this.objectListView_Things_MouseDown);
            // 
            // olvColumn_Name
            // 
            this.olvColumn_Name.AspectName = "Name";
            this.olvColumn_Name.Text = "Название";
            this.olvColumn_Name.Width = 865;
            // 
            // olvColumn_Material
            // 
            this.olvColumn_Material.AspectName = "Material";
            this.olvColumn_Material.Text = "Материал";
            this.olvColumn_Material.Width = 241;
            // 
            // olvColumn_Type
            // 
            this.olvColumn_Type.AspectName = "Type";
            this.olvColumn_Type.Text = "Тип";
            this.olvColumn_Type.Width = 233;
            // 
            // groupBox_Cleanings
            // 
            this.groupBox_Cleanings.Controls.Add(this.treeListView_Cleanings);
            this.groupBox_Cleanings.Controls.Add(this.button_DeleteCleaning);
            this.groupBox_Cleanings.Controls.Add(this.button_EditCleaning);
            this.groupBox_Cleanings.Controls.Add(this.button_AddCleaning);
            this.groupBox_Cleanings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Cleanings.Location = new System.Drawing.Point(3, 615);
            this.groupBox_Cleanings.Name = "groupBox_Cleanings";
            this.groupBox_Cleanings.Size = new System.Drawing.Size(1428, 239);
            this.groupBox_Cleanings.TabIndex = 2;
            this.groupBox_Cleanings.TabStop = false;
            this.groupBox_Cleanings.Text = "Чистки";
            // 
            // treeListView_Cleanings
            // 
            this.treeListView_Cleanings.AllColumns.Add(this.olvColumn_DateOrThing);
            this.treeListView_Cleanings.AllColumns.Add(this.olvColumn_Result);
            this.treeListView_Cleanings.AllColumns.Add(this.olvColumn_CleaningEmployee);
            this.treeListView_Cleanings.AllColumns.Add(this.olvColumn_ChemicalAgent);
            this.treeListView_Cleanings.AllowDrop = true;
            this.treeListView_Cleanings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView_Cleanings.CellEditUseWholeCell = false;
            this.treeListView_Cleanings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_DateOrThing,
            this.olvColumn_Result,
            this.olvColumn_CleaningEmployee,
            this.olvColumn_ChemicalAgent});
            this.treeListView_Cleanings.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView_Cleanings.FullRowSelect = true;
            this.treeListView_Cleanings.GridLines = true;
            this.treeListView_Cleanings.HideSelection = false;
            this.treeListView_Cleanings.Location = new System.Drawing.Point(6, 25);
            this.treeListView_Cleanings.MultiSelect = false;
            this.treeListView_Cleanings.Name = "treeListView_Cleanings";
            this.treeListView_Cleanings.ShowGroups = false;
            this.treeListView_Cleanings.Size = new System.Drawing.Size(1416, 172);
            this.treeListView_Cleanings.TabIndex = 13;
            this.treeListView_Cleanings.UseCompatibleStateImageBehavior = false;
            this.treeListView_Cleanings.View = System.Windows.Forms.View.Details;
            this.treeListView_Cleanings.VirtualMode = true;
            this.treeListView_Cleanings.SelectedIndexChanged += new System.EventHandler(this.treeListView_Cleanings_SelectedIndexChanged);
            this.treeListView_Cleanings.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeListView_Cleanings_DragDrop);
            this.treeListView_Cleanings.DragOver += new System.Windows.Forms.DragEventHandler(this.treeListView_Cleanings_DragOver);
            // 
            // olvColumn_DateOrThing
            // 
            this.olvColumn_DateOrThing.Text = "Дата";
            this.olvColumn_DateOrThing.Width = 365;
            // 
            // olvColumn_Result
            // 
            this.olvColumn_Result.AspectName = "Result";
            this.olvColumn_Result.Text = "Результат";
            this.olvColumn_Result.Width = 314;
            // 
            // olvColumn_CleaningEmployee
            // 
            this.olvColumn_CleaningEmployee.Text = "Сотрудник";
            this.olvColumn_CleaningEmployee.Width = 461;
            // 
            // olvColumn_ChemicalAgent
            // 
            this.olvColumn_ChemicalAgent.AspectName = "ChemicalAgent";
            this.olvColumn_ChemicalAgent.Text = "Химическое средство";
            this.olvColumn_ChemicalAgent.Width = 270;
            // 
            // button_DeleteCleaning
            // 
            this.button_DeleteCleaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteCleaning.Enabled = false;
            this.button_DeleteCleaning.Location = new System.Drawing.Point(1322, 203);
            this.button_DeleteCleaning.Name = "button_DeleteCleaning";
            this.button_DeleteCleaning.Size = new System.Drawing.Size(100, 30);
            this.button_DeleteCleaning.TabIndex = 12;
            this.button_DeleteCleaning.Text = "Удалить";
            this.button_DeleteCleaning.UseVisualStyleBackColor = true;
            this.button_DeleteCleaning.Click += new System.EventHandler(this.button_DeleteCleaning_Click);
            // 
            // button_EditCleaning
            // 
            this.button_EditCleaning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_EditCleaning.Enabled = false;
            this.button_EditCleaning.Location = new System.Drawing.Point(170, 203);
            this.button_EditCleaning.Name = "button_EditCleaning";
            this.button_EditCleaning.Size = new System.Drawing.Size(1146, 30);
            this.button_EditCleaning.TabIndex = 11;
            this.button_EditCleaning.Text = "Редактировать";
            this.button_EditCleaning.UseVisualStyleBackColor = true;
            this.button_EditCleaning.Click += new System.EventHandler(this.button_EditCleaning_Click);
            // 
            // button_AddCleaning
            // 
            this.button_AddCleaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddCleaning.Location = new System.Drawing.Point(6, 203);
            this.button_AddCleaning.Name = "button_AddCleaning";
            this.button_AddCleaning.Size = new System.Drawing.Size(158, 30);
            this.button_AddCleaning.TabIndex = 10;
            this.button_AddCleaning.Text = "Добавить чистку";
            this.button_AddCleaning.UseVisualStyleBackColor = true;
            this.button_AddCleaning.Click += new System.EventHandler(this.button_AddCleaning_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 903);
            this.Controls.Add(this.tableLayoutPanel_Orders);
            this.Controls.Add(this.menuStrip_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip_Panel;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хим чистка";
            this.menuStrip_Panel.ResumeLayout(false);
            this.menuStrip_Panel.PerformLayout();
            this.tableLayoutPanel_Orders.ResumeLayout(false);
            this.groupBox_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Orders)).EndInit();
            this.groupBox_Things.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Things)).EndInit();
            this.groupBox_Cleanings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView_Cleanings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_Panel;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыВещейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem химСредстваcommingSoonToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Orders;
        private System.Windows.Forms.GroupBox groupBox_Orders;
        private System.Windows.Forms.Button button_OrderEdit;
        private System.Windows.Forms.Button button_OrderDelete;
        private System.Windows.Forms.Button button_OrderAdd;
        private BrightIdeasSoftware.ObjectListView objectListView_Orders;
        private BrightIdeasSoftware.OLVColumn olvColumn_DateOfReceipt;
        private BrightIdeasSoftware.OLVColumn olvColumn_DateOfReturn;
        private BrightIdeasSoftware.OLVColumn olvColumn_TargetTerm;
        private BrightIdeasSoftware.OLVColumn olvColumn_ActualTerm;
        private BrightIdeasSoftware.OLVColumn olvColumn_OrderEmployee;
        private BrightIdeasSoftware.OLVColumn olvColumn_Client;
        private System.Windows.Forms.GroupBox groupBox_Things;
        private System.Windows.Forms.Button button_ThingEdit;
        private System.Windows.Forms.Button button_ThingDelete;
        private System.Windows.Forms.Button button_ThingAdd;
        private BrightIdeasSoftware.ObjectListView objectListView_Things;
        private BrightIdeasSoftware.OLVColumn olvColumn_Name;
        private BrightIdeasSoftware.OLVColumn olvColumn_Material;
        private BrightIdeasSoftware.OLVColumn olvColumn_Type;
        private BrightIdeasSoftware.OLVColumn olvColumn_ID;
        private System.Windows.Forms.GroupBox groupBox_Cleanings;
        private BrightIdeasSoftware.TreeListView treeListView_Cleanings;
        private BrightIdeasSoftware.OLVColumn olvColumn_DateOrThing;
        private BrightIdeasSoftware.OLVColumn olvColumn_Result;
        private BrightIdeasSoftware.OLVColumn olvColumn_CleaningEmployee;
        private BrightIdeasSoftware.OLVColumn olvColumn_ChemicalAgent;
        private System.Windows.Forms.Button button_DeleteCleaning;
        private System.Windows.Forms.Button button_EditCleaning;
        private System.Windows.Forms.Button button_AddCleaning;
        private System.Windows.Forms.ToolTip toolTip_DragDropThingHelp;
    }
}