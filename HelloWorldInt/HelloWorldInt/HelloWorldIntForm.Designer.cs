namespace HelloWorldInt
{
    partial class frmHelloWorldInt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorldInt));
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radItalian = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radIrish = new System.Windows.Forms.RadioButton();
            this.radRussian = new System.Windows.Forms.RadioButton();
            this.mnuHelloWorld = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.mnuHelloWorld.SuspendLayout();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloWorld.Font = new System.Drawing.Font("MV Boli", 70F, System.Drawing.FontStyle.Bold);
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWorld.Location = new System.Drawing.Point(78, 44);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(601, 123);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Checked = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radEnglish.ForeColor = System.Drawing.Color.Red;
            this.radEnglish.Location = new System.Drawing.Point(6, 37);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(121, 35);
            this.radEnglish.TabIndex = 1;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radFrench.ForeColor = System.Drawing.Color.Red;
            this.radFrench.Location = new System.Drawing.Point(133, 37);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(137, 35);
            this.radFrench.TabIndex = 2;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radItalian
            // 
            this.radItalian.AutoSize = true;
            this.radItalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radItalian.ForeColor = System.Drawing.Color.Red;
            this.radItalian.Location = new System.Drawing.Point(276, 37);
            this.radItalian.Name = "radItalian";
            this.radItalian.Size = new System.Drawing.Size(120, 35);
            this.radItalian.TabIndex = 3;
            this.radItalian.TabStop = true;
            this.radItalian.Text = "Italiano";
            this.radItalian.UseVisualStyleBackColor = true;
            this.radItalian.CheckedChanged += new System.EventHandler(this.radItalian_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radSpanish.ForeColor = System.Drawing.Color.Red;
            this.radSpanish.Location = new System.Drawing.Point(402, 37);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(130, 35);
            this.radSpanish.TabIndex = 4;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Español";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.radSpanish_CheckedChanged);
            // 
            // radIrish
            // 
            this.radIrish.AutoSize = true;
            this.radIrish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radIrish.ForeColor = System.Drawing.Color.Red;
            this.radIrish.Location = new System.Drawing.Point(538, 37);
            this.radIrish.Name = "radIrish";
            this.radIrish.Size = new System.Drawing.Size(125, 35);
            this.radIrish.TabIndex = 5;
            this.radIrish.TabStop = true;
            this.radIrish.Text = "Gaeilge";
            this.radIrish.UseVisualStyleBackColor = true;
            this.radIrish.CheckedChanged += new System.EventHandler(this.radIrish_CheckedChanged);
            // 
            // radRussian
            // 
            this.radRussian.AutoSize = true;
            this.radRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radRussian.ForeColor = System.Drawing.Color.Red;
            this.radRussian.Location = new System.Drawing.Point(669, 37);
            this.radRussian.Name = "radRussian";
            this.radRussian.Size = new System.Drawing.Size(136, 35);
            this.radRussian.TabIndex = 6;
            this.radRussian.TabStop = true;
            this.radRussian.Text = "Pусский";
            this.radRussian.UseVisualStyleBackColor = true;
            this.radRussian.CheckedChanged += new System.EventHandler(this.radRussian_CheckedChanged);
            // 
            // mnuHelloWorld
            // 
            this.mnuHelloWorld.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuHelloWorld.Location = new System.Drawing.Point(0, 0);
            this.mnuHelloWorld.Name = "mnuHelloWorld";
            this.mnuHelloWorld.Size = new System.Drawing.Size(1408, 24);
            this.mnuHelloWorld.TabIndex = 7;
            this.mnuHelloWorld.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Controls.Add(this.radRussian);
            this.grbLanguages.Controls.Add(this.radFrench);
            this.grbLanguages.Controls.Add(this.radIrish);
            this.grbLanguages.Controls.Add(this.radItalian);
            this.grbLanguages.Controls.Add(this.radSpanish);
            this.grbLanguages.Location = new System.Drawing.Point(313, 445);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(808, 100);
            this.grbLanguages.TabIndex = 8;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "groupBox1";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1408, 739);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.mnuHelloWorld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuHelloWorld;
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International";
            this.mnuHelloWorld.ResumeLayout(false);
            this.mnuHelloWorld.PerformLayout();
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radItalian;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radIrish;
        private System.Windows.Forms.RadioButton radRussian;
        private System.Windows.Forms.MenuStrip mnuHelloWorld;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.GroupBox grbLanguages;
    }
}

