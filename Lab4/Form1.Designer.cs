namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorB = new System.Windows.Forms.TrackBar();
            this.ColorG = new System.Windows.Forms.TrackBar();
            this.ColorR = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(30, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 981);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Black;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(23, 27);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(316, 120);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ColorB);
            this.panel2.Controls.Add(this.ColorG);
            this.panel2.Controls.Add(this.ColorR);
            this.panel2.Controls.Add(this.PictureBox);
            this.panel2.Location = new System.Drawing.Point(1478, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 556);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green Channel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red Channel";
            // 
            // ColorB
            // 
            this.ColorB.LargeChange = 1;
            this.ColorB.Location = new System.Drawing.Point(23, 375);
            this.ColorB.Maximum = 255;
            this.ColorB.Name = "ColorB";
            this.ColorB.Size = new System.Drawing.Size(316, 69);
            this.ColorB.TabIndex = 4;
            this.ColorB.Scroll += new System.EventHandler(this.ColorB_Scroll);
            // 
            // ColorG
            // 
            this.ColorG.LargeChange = 1;
            this.ColorG.Location = new System.Drawing.Point(23, 282);
            this.ColorG.Maximum = 255;
            this.ColorG.Name = "ColorG";
            this.ColorG.Size = new System.Drawing.Size(316, 69);
            this.ColorG.TabIndex = 3;
            this.ColorG.Scroll += new System.EventHandler(this.ColorG_Scroll);
            // 
            // ColorR
            // 
            this.ColorR.LargeChange = 1;
            this.ColorR.Location = new System.Drawing.Point(23, 186);
            this.ColorR.Maximum = 255;
            this.ColorR.Name = "ColorR";
            this.ColorR.Size = new System.Drawing.Size(316, 69);
            this.ColorR.TabIndex = 2;
            this.ColorR.Scroll += new System.EventHandler(this.ColorR_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(1478, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 405);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Draw Point";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Draw Line";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw Rectangle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1867, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(106, 29);
            this.toolStripButton1.Text = "New Image";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(23, 468);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(316, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Brush Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1062);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar ColorB;
        private System.Windows.Forms.TrackBar ColorG;
        private System.Windows.Forms.TrackBar ColorR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

