namespace BakeryInventorySystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBread = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBread,
            this.tsListofProducts,
            this.tsUser,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(106, 604);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsBread
            // 
            this.tsBread.Image = ((System.Drawing.Image)(resources.GetObject("tsBread.Image")));
            this.tsBread.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBread.Name = "tsBread";
            this.tsBread.Size = new System.Drawing.Size(99, 114);
            this.tsBread.Text = "Add Item";
            this.tsBread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBread.Click += new System.EventHandler(this.tsBread_Click);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsListofProducts.Image")));
            this.tsListofProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListofProducts.Margin = new System.Windows.Forms.Padding(0, 20, 0, 3);
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(99, 114);
            this.tsListofProducts.Text = "List Item";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.tsListofProducts_Click);
            // 
            // tsUser
            // 
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Margin = new System.Windows.Forms.Padding(0, 20, 0, 3);
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(99, 114);
            this.tsUser.Text = "Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsLogin.Image")));
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Margin = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(99, 114);
            this.tsLogin.Text = "Login/Logout";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1326, 604);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBread;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
    }
}

