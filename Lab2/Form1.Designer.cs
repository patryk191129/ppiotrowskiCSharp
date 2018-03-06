namespace Lab2
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
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplicationAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portValue = new System.Windows.Forms.TextBox();
            this.DirectoryLocation = new System.Windows.Forms.Label();
            this.SetDirectoryButton = new System.Windows.Forms.Button();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.StopServerButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.AutoSize = true;
            this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplicationTitle.Location = new System.Drawing.Point(407, 23);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(155, 29);
            this.ApplicationTitle.TabIndex = 0;
            this.ApplicationTitle.Text = "HTTP Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetDirectoryButton);
            this.groupBox1.Controls.Add(this.DirectoryLocation);
            this.groupBox1.Controls.Add(this.portValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server properties";
            // 
            // ApplicationAuthor
            // 
            this.ApplicationAuthor.AutoSize = true;
            this.ApplicationAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplicationAuthor.Location = new System.Drawing.Point(652, 518);
            this.ApplicationAuthor.Name = "ApplicationAuthor";
            this.ApplicationAuthor.Size = new System.Drawing.Size(278, 29);
            this.ApplicationAuthor.TabIndex = 2;
            this.ApplicationAuthor.Text = "Author: Patryk Piotrowski";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "File directory";
            // 
            // portValue
            // 
            this.portValue.Location = new System.Drawing.Point(198, 76);
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(135, 26);
            this.portValue.TabIndex = 2;
            this.portValue.Text = "8000";
            this.portValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DirectoryLocation
            // 
            this.DirectoryLocation.AutoSize = true;
            this.DirectoryLocation.Location = new System.Drawing.Point(198, 155);
            this.DirectoryLocation.Name = "DirectoryLocation";
            this.DirectoryLocation.Size = new System.Drawing.Size(157, 20);
            this.DirectoryLocation.TabIndex = 3;
            this.DirectoryLocation.Text = "No selected directory";
            this.DirectoryLocation.Click += new System.EventHandler(this.DirectoryLocation_Click);
            // 
            // SetDirectoryButton
            // 
            this.SetDirectoryButton.Location = new System.Drawing.Point(202, 198);
            this.SetDirectoryButton.Name = "SetDirectoryButton";
            this.SetDirectoryButton.Size = new System.Drawing.Size(131, 29);
            this.SetDirectoryButton.TabIndex = 4;
            this.SetDirectoryButton.Text = "Set directory";
            this.SetDirectoryButton.UseVisualStyleBackColor = true;
            this.SetDirectoryButton.Click += new System.EventHandler(this.SetDirectoryButton_Click);
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(288, 383);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(131, 29);
            this.StartServerButton.TabIndex = 5;
            this.StartServerButton.Text = "Run Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopServerButton
            // 
            this.StopServerButton.Location = new System.Drawing.Point(532, 383);
            this.StopServerButton.Name = "StopServerButton";
            this.StopServerButton.Size = new System.Drawing.Size(131, 29);
            this.StopServerButton.TabIndex = 6;
            this.StopServerButton.Text = "Stop Server";
            this.StopServerButton.UseVisualStyleBackColor = true;
            this.StopServerButton.Click += new System.EventHandler(this.StopServerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 556);
            this.Controls.Add(this.StopServerButton);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.ApplicationAuthor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ApplicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "HTTP Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplicationTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetDirectoryButton;
        private System.Windows.Forms.Label DirectoryLocation;
        private System.Windows.Forms.TextBox portValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApplicationAuthor;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Button StopServerButton;
    }
}

