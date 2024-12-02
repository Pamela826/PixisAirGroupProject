namespace PixisAirGroupProject
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ListJobsButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listJobsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomersFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(272, 284);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(205, 81);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ListJobsButton
            // 
            this.ListJobsButton.Location = new System.Drawing.Point(272, 67);
            this.ListJobsButton.Name = "ListJobsButton";
            this.ListJobsButton.Size = new System.Drawing.Size(205, 81);
            this.ListJobsButton.TabIndex = 1;
            this.ListJobsButton.Text = "List All Jobs";
            this.ListJobsButton.UseVisualStyleBackColor = true;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(272, 178);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(205, 81);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listJobsFormToolStripMenuItem,
            this.addCustomersFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // listJobsFormToolStripMenuItem
            // 
            this.listJobsFormToolStripMenuItem.Name = "listJobsFormToolStripMenuItem";
            this.listJobsFormToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.listJobsFormToolStripMenuItem.Text = "Open List Jobs Form";
            this.listJobsFormToolStripMenuItem.Click += new System.EventHandler(this.listJobsFormToolStripMenuItem_Click);
            // 
            // addCustomersFormToolStripMenuItem
            // 
            this.addCustomersFormToolStripMenuItem.Name = "addCustomersFormToolStripMenuItem";
            this.addCustomersFormToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.addCustomersFormToolStripMenuItem.Text = "Open Add Customers Form";
            this.addCustomersFormToolStripMenuItem.Click += new System.EventHandler(this.addCustomersFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.ListJobsButton);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ListJobsButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listJobsFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomersFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

