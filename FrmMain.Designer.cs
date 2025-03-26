namespace Whiteboard1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnSize4 = new System.Windows.Forms.Button();
            this.BtnSize3 = new System.Windows.Forms.Button();
            this.BtnSize2 = new System.Windows.Forms.Button();
            this.BtnSize1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBalckColor = new System.Windows.Forms.Button();
            this.BtnRedColor = new System.Windows.Forms.Button();
            this.BtnBuleColor = new System.Windows.Forms.Button();
            this.BtnGreenColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnErase = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSize4
            // 
            this.BtnSize4.BackColor = System.Drawing.Color.Black;
            this.BtnSize4.FlatAppearance.BorderSize = 0;
            this.BtnSize4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize4.Location = new System.Drawing.Point(125, 30);
            this.BtnSize4.Name = "BtnSize4";
            this.BtnSize4.Size = new System.Drawing.Size(25, 25);
            this.BtnSize4.TabIndex = 0;
            this.BtnSize4.UseVisualStyleBackColor = false;
            this.BtnSize4.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // BtnSize3
            // 
            this.BtnSize3.BackColor = System.Drawing.Color.Black;
            this.BtnSize3.FlatAppearance.BorderSize = 0;
            this.BtnSize3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize3.Location = new System.Drawing.Point(83, 32);
            this.BtnSize3.Name = "BtnSize3";
            this.BtnSize3.Size = new System.Drawing.Size(20, 20);
            this.BtnSize3.TabIndex = 1;
            this.BtnSize3.UseVisualStyleBackColor = false;
            this.BtnSize3.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // BtnSize2
            // 
            this.BtnSize2.BackColor = System.Drawing.Color.Black;
            this.BtnSize2.FlatAppearance.BorderSize = 0;
            this.BtnSize2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize2.Location = new System.Drawing.Point(46, 35);
            this.BtnSize2.Name = "BtnSize2";
            this.BtnSize2.Size = new System.Drawing.Size(15, 15);
            this.BtnSize2.TabIndex = 2;
            this.BtnSize2.UseVisualStyleBackColor = false;
            this.BtnSize2.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // BtnSize1
            // 
            this.BtnSize1.BackColor = System.Drawing.Color.Black;
            this.BtnSize1.FlatAppearance.BorderSize = 0;
            this.BtnSize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize1.Location = new System.Drawing.Point(14, 37);
            this.BtnSize1.Name = "BtnSize1";
            this.BtnSize1.Size = new System.Drawing.Size(10, 10);
            this.BtnSize1.TabIndex = 3;
            this.BtnSize1.UseVisualStyleBackColor = false;
            this.BtnSize1.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.BtnSize4);
            this.groupBox1.Controls.Add(this.BtnSize1);
            this.groupBox1.Controls.Add(this.BtnSize3);
            this.groupBox1.Controls.Add(this.BtnSize2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(478, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen size";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.BtnBalckColor);
            this.groupBox2.Controls.Add(this.BtnRedColor);
            this.groupBox2.Controls.Add(this.BtnBuleColor);
            this.groupBox2.Controls.Add(this.BtnGreenColor);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(305, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color picker";
            // 
            // BtnBalckColor
            // 
            this.BtnBalckColor.BackColor = System.Drawing.Color.Black;
            this.BtnBalckColor.FlatAppearance.BorderSize = 0;
            this.BtnBalckColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBalckColor.Location = new System.Drawing.Point(125, 30);
            this.BtnBalckColor.Name = "BtnBalckColor";
            this.BtnBalckColor.Size = new System.Drawing.Size(25, 25);
            this.BtnBalckColor.TabIndex = 0;
            this.BtnBalckColor.UseVisualStyleBackColor = false;
            this.BtnBalckColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnRedColor
            // 
            this.BtnRedColor.BackColor = System.Drawing.Color.Red;
            this.BtnRedColor.FlatAppearance.BorderSize = 0;
            this.BtnRedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRedColor.Location = new System.Drawing.Point(14, 30);
            this.BtnRedColor.Name = "BtnRedColor";
            this.BtnRedColor.Size = new System.Drawing.Size(25, 25);
            this.BtnRedColor.TabIndex = 3;
            this.BtnRedColor.UseVisualStyleBackColor = false;
            this.BtnRedColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnBuleColor
            // 
            this.BtnBuleColor.BackColor = System.Drawing.Color.Blue;
            this.BtnBuleColor.FlatAppearance.BorderSize = 0;
            this.BtnBuleColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuleColor.Location = new System.Drawing.Point(88, 30);
            this.BtnBuleColor.Name = "BtnBuleColor";
            this.BtnBuleColor.Size = new System.Drawing.Size(25, 25);
            this.BtnBuleColor.TabIndex = 1;
            this.BtnBuleColor.UseVisualStyleBackColor = false;
            this.BtnBuleColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnGreenColor
            // 
            this.BtnGreenColor.BackColor = System.Drawing.Color.Green;
            this.BtnGreenColor.FlatAppearance.BorderSize = 0;
            this.BtnGreenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGreenColor.Location = new System.Drawing.Point(51, 30);
            this.BtnGreenColor.Name = "BtnGreenColor";
            this.BtnGreenColor.Size = new System.Drawing.Size(25, 25);
            this.BtnGreenColor.TabIndex = 2;
            this.BtnGreenColor.UseVisualStyleBackColor = false;
            this.BtnGreenColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.BtnErase);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(218, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(81, 69);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Erase";
            // 
            // BtnErase
            // 
            this.BtnErase.BackColor = System.Drawing.Color.MistyRose;
            this.BtnErase.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnErase.FlatAppearance.BorderSize = 2;
            this.BtnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnErase.Location = new System.Drawing.Point(17, 30);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Size = new System.Drawing.Size(50, 25);
            this.BtnErase.TabIndex = 0;
            this.BtnErase.UseVisualStyleBackColor = false;
            this.BtnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whiteboard";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSize4;
        private System.Windows.Forms.Button BtnSize3;
        private System.Windows.Forms.Button BtnSize2;
        private System.Windows.Forms.Button BtnSize1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBalckColor;
        private System.Windows.Forms.Button BtnRedColor;
        private System.Windows.Forms.Button BtnBuleColor;
        private System.Windows.Forms.Button BtnGreenColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnErase;
    }
}

