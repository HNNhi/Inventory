namespace QuanlyKho1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem1 = new ToolStripMenuItem();
            manageUserToolStripMenuItem = new ToolStripMenuItem();
            personToolStripMenuItem1 = new ToolStripMenuItem();
            managePersonToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            manageProductToolStripMenuItem1 = new ToolStripMenuItem();
            inventoryToolStripMenuItem1 = new ToolStripMenuItem();
            manageInventoryToolStripMenuItem1 = new ToolStripMenuItem();
            documentToolStripMenuItem = new ToolStripMenuItem();
            manageDocumentToolStripMenuItem = new ToolStripMenuItem();
            processDocumentDetailsToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem1, personToolStripMenuItem1, inventoryToolStripMenuItem, inventoryToolStripMenuItem1, documentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1863, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem1
            // 
            userToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { manageUserToolStripMenuItem });
            userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            userToolStripMenuItem1.Size = new Size(63, 29);
            userToolStripMenuItem1.Text = "User";
            // 
            // manageUserToolStripMenuItem
            // 
            manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            manageUserToolStripMenuItem.Size = new Size(218, 34);
            manageUserToolStripMenuItem.Text = "Manage User";
            manageUserToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // personToolStripMenuItem1
            // 
            personToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { managePersonToolStripMenuItem });
            personToolStripMenuItem1.Name = "personToolStripMenuItem1";
            personToolStripMenuItem1.Size = new Size(81, 29);
            personToolStripMenuItem1.Text = "Person";
            // 
            // managePersonToolStripMenuItem
            // 
            managePersonToolStripMenuItem.Name = "managePersonToolStripMenuItem";
            managePersonToolStripMenuItem.Size = new Size(236, 34);
            managePersonToolStripMenuItem.Text = "Manage Person";
            managePersonToolStripMenuItem.Click += personToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageProductToolStripMenuItem1 });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(90, 29);
            inventoryToolStripMenuItem.Text = "Product";
            // 
            // manageProductToolStripMenuItem1
            // 
            manageProductToolStripMenuItem1.Name = "manageProductToolStripMenuItem1";
            manageProductToolStripMenuItem1.Size = new Size(240, 34);
            manageProductToolStripMenuItem1.Text = "ManageProduct";
            manageProductToolStripMenuItem1.Click += manageProductToolStripMenuItem1_Click;
            // 
            // inventoryToolStripMenuItem1
            // 
            inventoryToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { manageInventoryToolStripMenuItem1 });
            inventoryToolStripMenuItem1.Name = "inventoryToolStripMenuItem1";
            inventoryToolStripMenuItem1.Size = new Size(103, 29);
            inventoryToolStripMenuItem1.Text = "Inventory";
            // 
            // manageInventoryToolStripMenuItem1
            // 
            manageInventoryToolStripMenuItem1.Name = "manageInventoryToolStripMenuItem1";
            manageInventoryToolStripMenuItem1.Size = new Size(258, 34);
            manageInventoryToolStripMenuItem1.Text = "Manage Inventory";
            manageInventoryToolStripMenuItem1.Click += inventoryToolStripMenuItem_Click;
            // 
            // documentToolStripMenuItem
            // 
            documentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDocumentToolStripMenuItem, processDocumentDetailsToolStripMenuItem1 });
            documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            documentToolStripMenuItem.Size = new Size(111, 29);
            documentToolStripMenuItem.Text = "Document";
            // 
            // manageDocumentToolStripMenuItem
            // 
            manageDocumentToolStripMenuItem.Name = "manageDocumentToolStripMenuItem";
            manageDocumentToolStripMenuItem.Size = new Size(320, 34);
            manageDocumentToolStripMenuItem.Text = "Manage Document";
            manageDocumentToolStripMenuItem.Click += manageDocumentToolStripMenuItem1_Click;
            // 
            // processDocumentDetailsToolStripMenuItem1
            // 
            processDocumentDetailsToolStripMenuItem1.Name = "processDocumentDetailsToolStripMenuItem1";
            processDocumentDetailsToolStripMenuItem1.Size = new Size(320, 34);
            processDocumentDetailsToolStripMenuItem1.Text = "Process Document Details";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1863, 1048);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý kho";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem1;
        private ToolStripMenuItem manageUserToolStripMenuItem;
        private ToolStripMenuItem personToolStripMenuItem1;
        private ToolStripMenuItem managePersonToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem manageProductToolStripMenuItem1;
        private ToolStripMenuItem inventoryToolStripMenuItem1;
        private ToolStripMenuItem manageInventoryToolStripMenuItem1;
        private ToolStripMenuItem documentToolStripMenuItem;
        private ToolStripMenuItem manageDocumentToolStripMenuItem;
        private ToolStripMenuItem processDocumentDetailsToolStripMenuItem1;
    }
}