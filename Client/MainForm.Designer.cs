namespace Client
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCompanyIDs = new System.Windows.Forms.ListBox();
            this.textBoxCompanyID = new System.Windows.Forms.TextBox();
            this.buttonSearchCompany = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAvailableLocations = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPalletIDs = new System.Windows.Forms.TextBox();
            this.buttonSearchPallet = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonViewAllCompanies = new System.Windows.Forms.Button();
            this.listBoxPallets = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.palletToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.editDetailsToolStripMenuItem,
            this.manageLocationsToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.companyToolStripMenuItem.Text = "Company";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // editDetailsToolStripMenuItem
            // 
            this.editDetailsToolStripMenuItem.Name = "editDetailsToolStripMenuItem";
            this.editDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDetailsToolStripMenuItem.Text = "Edit details";
            this.editDetailsToolStripMenuItem.Click += new System.EventHandler(this.EditDetailsToolStripMenuItem_Click);
            // 
            // manageLocationsToolStripMenuItem
            // 
            this.manageLocationsToolStripMenuItem.Name = "manageLocationsToolStripMenuItem";
            this.manageLocationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageLocationsToolStripMenuItem.Text = "Manage locations";
            this.manageLocationsToolStripMenuItem.Click += new System.EventHandler(this.ManageLocationsToolStripMenuItem_Click);
            // 
            // palletToolStripMenuItem
            // 
            this.palletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem});
            this.palletToolStripMenuItem.Name = "palletToolStripMenuItem";
            this.palletToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.palletToolStripMenuItem.Text = "Pallet";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company IDs";
            // 
            // listBoxCompanyIDs
            // 
            this.listBoxCompanyIDs.FormattingEnabled = true;
            this.listBoxCompanyIDs.Location = new System.Drawing.Point(16, 102);
            this.listBoxCompanyIDs.Name = "listBoxCompanyIDs";
            this.listBoxCompanyIDs.Size = new System.Drawing.Size(166, 303);
            this.listBoxCompanyIDs.TabIndex = 3;
            this.listBoxCompanyIDs.SelectedIndexChanged += new System.EventHandler(this.ListBoxCompanyIDs_SelectedIndexChanged);
            // 
            // textBoxCompanyID
            // 
            this.textBoxCompanyID.Location = new System.Drawing.Point(16, 45);
            this.textBoxCompanyID.Name = "textBoxCompanyID";
            this.textBoxCompanyID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyID.TabIndex = 4;
            this.textBoxCompanyID.Text = "Company ID";
            // 
            // buttonSearchCompany
            // 
            this.buttonSearchCompany.Location = new System.Drawing.Point(16, 72);
            this.buttonSearchCompany.Name = "buttonSearchCompany";
            this.buttonSearchCompany.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCompany.TabIndex = 5;
            this.buttonSearchCompany.Text = "Search";
            this.buttonSearchCompany.UseVisualStyleBackColor = true;
            this.buttonSearchCompany.Click += new System.EventHandler(this.ButtonSearchCompany_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available for rent locations";
            // 
            // listBoxAvailableLocations
            // 
            this.listBoxAvailableLocations.FormattingEnabled = true;
            this.listBoxAvailableLocations.Location = new System.Drawing.Point(188, 102);
            this.listBoxAvailableLocations.Name = "listBoxAvailableLocations";
            this.listBoxAvailableLocations.Size = new System.Drawing.Size(188, 303);
            this.listBoxAvailableLocations.TabIndex = 7;
            this.listBoxAvailableLocations.SelectedIndexChanged += new System.EventHandler(this.ListBoxAvailableLocations_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "All stored pallets";
            // 
            // textBoxPalletIDs
            // 
            this.textBoxPalletIDs.Location = new System.Drawing.Point(581, 44);
            this.textBoxPalletIDs.Name = "textBoxPalletIDs";
            this.textBoxPalletIDs.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalletIDs.TabIndex = 9;
            this.textBoxPalletIDs.Text = "Pallet ID";
            // 
            // buttonSearchPallet
            // 
            this.buttonSearchPallet.Location = new System.Drawing.Point(581, 72);
            this.buttonSearchPallet.Name = "buttonSearchPallet";
            this.buttonSearchPallet.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPallet.TabIndex = 10;
            this.buttonSearchPallet.Text = "Search";
            this.buttonSearchPallet.UseVisualStyleBackColor = true;
            this.buttonSearchPallet.Click += new System.EventHandler(this.ButtonSearchPallet_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Location = new System.Drawing.Point(663, 72);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAll.TabIndex = 11;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.ButtonViewAll_Click);
            // 
            // buttonViewAllCompanies
            // 
            this.buttonViewAllCompanies.Location = new System.Drawing.Point(107, 72);
            this.buttonViewAllCompanies.Name = "buttonViewAllCompanies";
            this.buttonViewAllCompanies.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAllCompanies.TabIndex = 12;
            this.buttonViewAllCompanies.Text = "View All";
            this.buttonViewAllCompanies.UseVisualStyleBackColor = true;
            this.buttonViewAllCompanies.Click += new System.EventHandler(this.ButtonViewAllCompanies_Click);
            // 
            // listBoxPallets
            // 
            this.listBoxPallets.FormattingEnabled = true;
            this.listBoxPallets.Location = new System.Drawing.Point(382, 102);
            this.listBoxPallets.Name = "listBoxPallets";
            this.listBoxPallets.Size = new System.Drawing.Size(406, 303);
            this.listBoxPallets.TabIndex = 13;
            this.listBoxPallets.SelectedIndexChanged += new System.EventHandler(this.ListBoxPallets_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPallets);
            this.Controls.Add(this.buttonViewAllCompanies);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonSearchPallet);
            this.Controls.Add(this.textBoxPalletIDs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxAvailableLocations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchCompany);
            this.Controls.Add(this.textBoxCompanyID);
            this.Controls.Add(this.listBoxCompanyIDs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCompanyIDs;
        private System.Windows.Forms.TextBox textBoxCompanyID;
        private System.Windows.Forms.Button buttonSearchCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAvailableLocations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPalletIDs;
        private System.Windows.Forms.Button buttonSearchPallet;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonViewAllCompanies;
        private System.Windows.Forms.ListBox listBoxPallets;
    }
}

