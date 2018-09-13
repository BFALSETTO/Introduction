namespace HelloWorldMenuBenF
{
    partial class frmHelloWorldMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorldMenu));
            this.lblImmaculata = new System.Windows.Forms.Label();
            this.lblSaints = new System.Windows.Forms.Label();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.get1MillionDollarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImmaculata
            // 
            this.lblImmaculata.AutoSize = true;
            this.lblImmaculata.Font = new System.Drawing.Font("Rosewood Std Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmaculata.ForeColor = System.Drawing.Color.White;
            this.lblImmaculata.Location = new System.Drawing.Point(81, 99);
            this.lblImmaculata.Name = "lblImmaculata";
            this.lblImmaculata.Size = new System.Drawing.Size(193, 37);
            this.lblImmaculata.TabIndex = 1;
            this.lblImmaculata.Text = "Immaculata";
            // 
            // lblSaints
            // 
            this.lblSaints.AutoSize = true;
            this.lblSaints.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSaints.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaints.ForeColor = System.Drawing.Color.White;
            this.lblSaints.Location = new System.Drawing.Point(99, 165);
            this.lblSaints.Name = "lblSaints";
            this.lblSaints.Size = new System.Drawing.Size(147, 36);
            this.lblSaints.TabIndex = 2;
            this.lblSaints.Text = "Saints";
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(352, 24);
            this.mnuProgram.TabIndex = 3;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.get1MillionDollarsToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(179, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // get1MillionDollarsToolStripMenuItem
            // 
            this.get1MillionDollarsToolStripMenuItem.Name = "get1MillionDollarsToolStripMenuItem";
            this.get1MillionDollarsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.get1MillionDollarsToolStripMenuItem.Text = "Get 1 million dollars";
            this.get1MillionDollarsToolStripMenuItem.Click += new System.EventHandler(this.get1MillionDollarsToolStripMenuItem_Click);
            // 
            // frmHelloWorldMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 304);
            this.Controls.Add(this.lblSaints);
            this.Controls.Add(this.lblImmaculata);
            this.Controls.Add(this.mnuProgram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelloWorldMenu";
            this.Text = "Hello World With Menu by Ben";
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImmaculata;
        private System.Windows.Forms.Label lblSaints;
        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem get1MillionDollarsToolStripMenuItem;
    }
}

