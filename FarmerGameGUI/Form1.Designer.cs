namespace FarmerGameGUI
{
    partial class foxChickenGrain
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
            this.farmer = new System.Windows.Forms.Button();
            this.chicken = new System.Windows.Forms.Button();
            this.fox = new System.Windows.Forms.Button();
            this.grain = new System.Windows.Forms.Button();
            this.farmerGameMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.farmerGameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // farmer
            // 
            this.farmer.BackColor = System.Drawing.Color.Transparent;
            this.farmer.BackgroundImage = global::FarmerGameGUI.Properties.Resources.farme2r;
            this.farmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.farmer.FlatAppearance.BorderSize = 0;
            this.farmer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.farmer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.farmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.farmer.Location = new System.Drawing.Point(110, 425);
            this.farmer.Name = "farmer";
            this.farmer.Size = new System.Drawing.Size(139, 140);
            this.farmer.TabIndex = 0;
            this.farmer.TabStop = false;
            this.farmer.UseVisualStyleBackColor = false;
            this.farmer.Click += new System.EventHandler(this.farmer_Click);
            // 
            // chicken
            // 
            this.chicken.BackColor = System.Drawing.Color.Transparent;
            this.chicken.BackgroundImage = global::FarmerGameGUI.Properties.Resources.chick2en;
            this.chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chicken.FlatAppearance.BorderSize = 0;
            this.chicken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chicken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chicken.Location = new System.Drawing.Point(231, 429);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(133, 136);
            this.chicken.TabIndex = 1;
            this.chicken.TabStop = false;
            this.chicken.UseVisualStyleBackColor = false;
            this.chicken.Click += new System.EventHandler(this.chicken_Click);
            // 
            // fox
            // 
            this.fox.BackColor = System.Drawing.Color.Transparent;
            this.fox.BackgroundImage = global::FarmerGameGUI.Properties.Resources._2fox2;
            this.fox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fox.FlatAppearance.BorderSize = 0;
            this.fox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fox.Location = new System.Drawing.Point(350, 436);
            this.fox.Name = "fox";
            this.fox.Size = new System.Drawing.Size(126, 123);
            this.fox.TabIndex = 2;
            this.fox.TabStop = false;
            this.fox.UseVisualStyleBackColor = false;
            this.fox.Click += new System.EventHandler(this.fox_Click);
            // 
            // grain
            // 
            this.grain.BackColor = System.Drawing.Color.Transparent;
            this.grain.BackgroundImage = global::FarmerGameGUI.Properties.Resources.gr2ain;
            this.grain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grain.FlatAppearance.BorderSize = 0;
            this.grain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.grain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.grain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grain.Location = new System.Drawing.Point(493, 35);
            this.grain.Name = "grain";
            this.grain.Size = new System.Drawing.Size(141, 129);
            this.grain.TabIndex = 3;
            this.grain.TabStop = false;
            this.grain.UseVisualStyleBackColor = false;
            this.grain.Click += new System.EventHandler(this.grain_Click);
            // 
            // farmerGameMenu
            // 
            this.farmerGameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.farmerGameMenu.Location = new System.Drawing.Point(0, 0);
            this.farmerGameMenu.Name = "farmerGameMenu";
            this.farmerGameMenu.Size = new System.Drawing.Size(784, 24);
            this.farmerGameMenu.TabIndex = 4;
            this.farmerGameMenu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Close_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rules_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.MyInfo_Click);
            // 
            // foxChickenGrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmerGameGUI.Properties.Resources.river;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grain);
            this.Controls.Add(this.fox);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.farmer);
            this.Controls.Add(this.farmerGameMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.farmerGameMenu;
            this.Name = "foxChickenGrain";
            this.Text = "Fox, Chicken, Grain";
            this.farmerGameMenu.ResumeLayout(false);
            this.farmerGameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button farmer;
        private System.Windows.Forms.Button chicken;
        private System.Windows.Forms.Button fox;
        private System.Windows.Forms.Button grain;
        private System.Windows.Forms.MenuStrip farmerGameMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

