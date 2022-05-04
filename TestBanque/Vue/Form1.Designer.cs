
namespace TestBanque.Vue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.découvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(333, 45);
            this.lb.Margin = new System.Windows.Forms.Padding(2);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(358, 251);
            this.lb.TabIndex = 0;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditerToolStripMenuItem,
            this.débiterToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // créditerToolStripMenuItem
            // 
            this.créditerToolStripMenuItem.Name = "créditerToolStripMenuItem";
            this.créditerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.créditerToolStripMenuItem.Text = "Créditer";
            this.créditerToolStripMenuItem.Click += new System.EventHandler(this.créditerToolStripMenuItem_Click);
            // 
            // débiterToolStripMenuItem
            // 
            this.débiterToolStripMenuItem.Name = "débiterToolStripMenuItem";
            this.débiterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.débiterToolStripMenuItem.Text = "Débiter";
            this.débiterToolStripMenuItem.Click += new System.EventHandler(this.débiterToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvertToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // découvertToolStripMenuItem
            // 
            this.découvertToolStripMenuItem.Name = "découvertToolStripMenuItem";
            this.découvertToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.découvertToolStripMenuItem.Text = "Découvert";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 316);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Compte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débiterToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem découvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

