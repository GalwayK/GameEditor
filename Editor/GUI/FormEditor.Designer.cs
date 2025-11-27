namespace Lab06
{
    partial class FormEditor
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            splitContainer4 = new System.Windows.Forms.SplitContainer();
            listBoxLevel = new System.Windows.Forms.ListBox();
            listBoxPrefabs = new System.Windows.Forms.ListBox();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            propertyGrid = new System.Windows.Forms.PropertyGrid();
            listBoxAssets = new System.Windows.Forms.ListBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, assetsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createToolStripMenuItem1, saveToolStripMenuItem, loadToolStripMenuItem });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            createToolStripMenuItem.Text = "Project";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            createToolStripMenuItem1.Text = "Create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(108, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // assetsToolStripMenuItem
            // 
            assetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { importToolStripMenuItem });
            assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            assetsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            assetsToolStripMenuItem.Text = "Assets";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            splitContainer1.Panel1.SizeChanged += splitContainer1_Panel1_SizeChanged;
            splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(800, 426);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            splitContainer3.Size = new System.Drawing.Size(500, 426);
            splitContainer3.SplitterDistance = 166;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer4.Location = new System.Drawing.Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(listBoxLevel);
            splitContainer4.Panel1MinSize = 170;
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(listBoxPrefabs);
            splitContainer4.Size = new System.Drawing.Size(166, 426);
            splitContainer4.SplitterDistance = 170;
            splitContainer4.TabIndex = 0;
            // 
            // listBoxLevel
            // 
            listBoxLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxLevel.FormattingEnabled = true;
            listBoxLevel.ItemHeight = 15;
            listBoxLevel.Location = new System.Drawing.Point(0, 0);
            listBoxLevel.Name = "listBoxLevel";
            listBoxLevel.Size = new System.Drawing.Size(166, 170);
            listBoxLevel.TabIndex = 0;
            listBoxLevel.SelectedIndexChanged += listBoxLevel_SelectedIndexChanged;
            // 
            // listBoxPrefabs
            // 
            listBoxPrefabs.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxPrefabs.FormattingEnabled = true;
            listBoxPrefabs.ItemHeight = 15;
            listBoxPrefabs.Location = new System.Drawing.Point(0, 0);
            listBoxPrefabs.Name = "listBoxPrefabs";
            listBoxPrefabs.Size = new System.Drawing.Size(166, 252);
            listBoxPrefabs.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(propertyGrid);
            splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listBoxAssets);
            splitContainer2.Size = new System.Drawing.Size(296, 426);
            splitContainer2.SplitterDistance = 150;
            splitContainer2.TabIndex = 1;
            // 
            // propertyGrid
            // 
            propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGrid.Location = new System.Drawing.Point(0, 0);
            propertyGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new System.Drawing.Size(296, 150);
            propertyGrid.TabIndex = 0;
            // 
            // listBoxAssets
            // 
            listBoxAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxAssets.FormattingEnabled = true;
            listBoxAssets.ItemHeight = 15;
            listBoxAssets.Location = new System.Drawing.Point(0, 0);
            listBoxAssets.Name = "listBoxAssets";
            listBoxAssets.Size = new System.Drawing.Size(296, 272);
            listBoxAssets.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new System.Drawing.Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormEditor";
            Text = "Kyle's Cool Editor";
            SizeChanged += FormEditor_SizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        public System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBoxAssets;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        public System.Windows.Forms.ListBox listBoxLevel;
        private System.Windows.Forms.ListBox listBoxPrefabs;
    }
}