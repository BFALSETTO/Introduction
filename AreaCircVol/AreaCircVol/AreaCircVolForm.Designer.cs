namespace AreaCircVol
{
    partial class AreaCircVolForm
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
            this.btnPerRect = new System.Windows.Forms.Button();
            this.btnAreaCirc = new System.Windows.Forms.Button();
            this.btnVolSphere = new System.Windows.Forms.Button();
            this.lblPerRect = new System.Windows.Forms.Label();
            this.lblAreaCirc = new System.Windows.Forms.Label();
            this.lblVolSphereAns = new System.Windows.Forms.Label();
            this.lblAreaCircAns = new System.Windows.Forms.Label();
            this.lblPerRectAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerRect
            // 
            this.btnPerRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPerRect.Location = new System.Drawing.Point(35, 45);
            this.btnPerRect.Name = "btnPerRect";
            this.btnPerRect.Size = new System.Drawing.Size(194, 84);
            this.btnPerRect.TabIndex = 0;
            this.btnPerRect.Text = "Calculate the perimeter of a rectangle with a length of 10 and a width of 3cm";
            this.btnPerRect.UseVisualStyleBackColor = true;
            this.btnPerRect.Click += new System.EventHandler(this.btnPerRect_Click);
            // 
            // btnAreaCirc
            // 
            this.btnAreaCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAreaCirc.Location = new System.Drawing.Point(35, 182);
            this.btnAreaCirc.Name = "btnAreaCirc";
            this.btnAreaCirc.Size = new System.Drawing.Size(153, 77);
            this.btnAreaCirc.TabIndex = 1;
            this.btnAreaCirc.Text = "Calculate the area of a circle with a radius of 10cm";
            this.btnAreaCirc.UseVisualStyleBackColor = true;
            this.btnAreaCirc.Click += new System.EventHandler(this.btnAreaCirc_Click);
            // 
            // btnVolSphere
            // 
            this.btnVolSphere.Location = new System.Drawing.Point(35, 312);
            this.btnVolSphere.Name = "btnVolSphere";
            this.btnVolSphere.Size = new System.Drawing.Size(109, 60);
            this.btnVolSphere.TabIndex = 2;
            this.btnVolSphere.Text = "Calculate the volume of a sphere with a radius of 6cm";
            this.btnVolSphere.UseVisualStyleBackColor = true;
            this.btnVolSphere.Click += new System.EventHandler(this.btnVolSphere_Click);
            // 
            // lblPerRect
            // 
            this.lblPerRect.Location = new System.Drawing.Point(0, 0);
            this.lblPerRect.Name = "lblPerRect";
            this.lblPerRect.Size = new System.Drawing.Size(100, 23);
            this.lblPerRect.TabIndex = 7;
            // 
            // lblAreaCirc
            // 
            this.lblAreaCirc.Location = new System.Drawing.Point(0, 0);
            this.lblAreaCirc.Name = "lblAreaCirc";
            this.lblAreaCirc.Size = new System.Drawing.Size(100, 23);
            this.lblAreaCirc.TabIndex = 6;
            // 
            // lblVolSphereAns
            // 
            this.lblVolSphereAns.AutoSize = true;
            this.lblVolSphereAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVolSphereAns.Location = new System.Drawing.Point(247, 334);
            this.lblVolSphereAns.Name = "lblVolSphereAns";
            this.lblVolSphereAns.Size = new System.Drawing.Size(24, 17);
            this.lblVolSphereAns.TabIndex = 5;
            this.lblVolSphereAns.Text = "??";
            // 
            // lblAreaCircAns
            // 
            this.lblAreaCircAns.AutoSize = true;
            this.lblAreaCircAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAreaCircAns.Location = new System.Drawing.Point(247, 212);
            this.lblAreaCircAns.Name = "lblAreaCircAns";
            this.lblAreaCircAns.Size = new System.Drawing.Size(24, 17);
            this.lblAreaCircAns.TabIndex = 8;
            this.lblAreaCircAns.Text = "??";
            // 
            // lblPerRectAns
            // 
            this.lblPerRectAns.AutoSize = true;
            this.lblPerRectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPerRectAns.Location = new System.Drawing.Point(244, 66);
            this.lblPerRectAns.Name = "lblPerRectAns";
            this.lblPerRectAns.Size = new System.Drawing.Size(44, 31);
            this.lblPerRectAns.TabIndex = 9;
            this.lblPerRectAns.Text = "??";
            // 
            // AreaCircVolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 441);
            this.Controls.Add(this.lblPerRectAns);
            this.Controls.Add(this.lblAreaCircAns);
            this.Controls.Add(this.lblVolSphereAns);
            this.Controls.Add(this.lblAreaCirc);
            this.Controls.Add(this.lblPerRect);
            this.Controls.Add(this.btnVolSphere);
            this.Controls.Add(this.btnAreaCirc);
            this.Controls.Add(this.btnPerRect);
            this.Name = "AreaCircVolForm";
            this.Text = "Area Circumference Volume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerRect;
        private System.Windows.Forms.Button btnAreaCirc;
        private System.Windows.Forms.Button btnVolSphere;
        private System.Windows.Forms.Label lblPerRect;
        private System.Windows.Forms.Label lblAreaCirc;
        private System.Windows.Forms.Label lblVolSphereAns;
        private System.Windows.Forms.Label lblAreaCircAns;
        private System.Windows.Forms.Label lblPerRectAns;
    }
}

