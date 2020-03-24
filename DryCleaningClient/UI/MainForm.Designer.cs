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
            this.menuStrip_Panel.SuspendLayout();
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
            this.menuStrip_Panel.Size = new System.Drawing.Size(1200, 31);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip_Panel;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хим чистка";
            this.menuStrip_Panel.ResumeLayout(false);
            this.menuStrip_Panel.PerformLayout();
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
    }
}