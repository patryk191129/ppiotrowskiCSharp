namespace Lab6
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
            this.button1 = new System.Windows.Forms.Button();
            this.FileDirectoryText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.GroupBox();
            this.ThreeElementsDictionaryCountValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TwoElementsDictionaryCountValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ThreeElementsTimeValue = new System.Windows.Forms.Label();
            this.TwoElementsTimeValue = new System.Windows.Forms.Label();
            this.ReadFileTimeValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FoundMatchesValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileDirectoryText
            // 
            this.FileDirectoryText.AutoSize = true;
            this.FileDirectoryText.Location = new System.Drawing.Point(122, 45);
            this.FileDirectoryText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileDirectoryText.Name = "FileDirectoryText";
            this.FileDirectoryText.Size = new System.Drawing.Size(98, 20);
            this.FileDirectoryText.TabIndex = 1;
            this.FileDirectoryText.Text = "Not selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "File directory:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.FileDirectoryText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1409, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SelectFile";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Statistics
            // 
            this.Statistics.Controls.Add(this.ThreeElementsDictionaryCountValue);
            this.Statistics.Controls.Add(this.label7);
            this.Statistics.Controls.Add(this.TwoElementsDictionaryCountValue);
            this.Statistics.Controls.Add(this.label6);
            this.Statistics.Controls.Add(this.label5);
            this.Statistics.Controls.Add(this.ThreeElementsTimeValue);
            this.Statistics.Controls.Add(this.TwoElementsTimeValue);
            this.Statistics.Controls.Add(this.ReadFileTimeValue);
            this.Statistics.Controls.Add(this.label4);
            this.Statistics.Controls.Add(this.label3);
            this.Statistics.Controls.Add(this.label1);
            this.Statistics.Location = new System.Drawing.Point(18, 248);
            this.Statistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Statistics.Size = new System.Drawing.Size(562, 491);
            this.Statistics.TabIndex = 4;
            this.Statistics.TabStop = false;
            this.Statistics.Text = "Statistics";
            this.Statistics.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ThreeElementsDictionaryCountValue
            // 
            this.ThreeElementsDictionaryCountValue.AutoSize = true;
            this.ThreeElementsDictionaryCountValue.Location = new System.Drawing.Point(312, 405);
            this.ThreeElementsDictionaryCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThreeElementsDictionaryCountValue.Name = "ThreeElementsDictionaryCountValue";
            this.ThreeElementsDictionaryCountValue.Size = new System.Drawing.Size(207, 20);
            this.ThreeElementsDictionaryCountValue.TabIndex = 10;
            this.ThreeElementsDictionaryCountValue.Text = "3-elements dictionary count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 9;
            // 
            // TwoElementsDictionaryCountValue
            // 
            this.TwoElementsDictionaryCountValue.AutoSize = true;
            this.TwoElementsDictionaryCountValue.Location = new System.Drawing.Point(312, 354);
            this.TwoElementsDictionaryCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TwoElementsDictionaryCountValue.Name = "TwoElementsDictionaryCountValue";
            this.TwoElementsDictionaryCountValue.Size = new System.Drawing.Size(0, 20);
            this.TwoElementsDictionaryCountValue.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "3-elements dictionary count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "2-elements dictionary count:";
            // 
            // ThreeElementsTimeValue
            // 
            this.ThreeElementsTimeValue.AutoSize = true;
            this.ThreeElementsTimeValue.Location = new System.Drawing.Point(224, 177);
            this.ThreeElementsTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThreeElementsTimeValue.Name = "ThreeElementsTimeValue";
            this.ThreeElementsTimeValue.Size = new System.Drawing.Size(151, 20);
            this.ThreeElementsTimeValue.TabIndex = 5;
            this.ThreeElementsTimeValue.Text = "ThreeElementsTime";
            // 
            // TwoElementsTimeValue
            // 
            this.TwoElementsTimeValue.AutoSize = true;
            this.TwoElementsTimeValue.Location = new System.Drawing.Point(224, 118);
            this.TwoElementsTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TwoElementsTimeValue.Name = "TwoElementsTimeValue";
            this.TwoElementsTimeValue.Size = new System.Drawing.Size(139, 20);
            this.TwoElementsTimeValue.TabIndex = 4;
            this.TwoElementsTimeValue.Text = "TwoElementsTime";
            // 
            // ReadFileTimeValue
            // 
            this.ReadFileTimeValue.AutoSize = true;
            this.ReadFileTimeValue.Location = new System.Drawing.Point(224, 58);
            this.ReadFileTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadFileTimeValue.Name = "ReadFileTimeValue";
            this.ReadFileTimeValue.Size = new System.Drawing.Size(107, 20);
            this.ReadFileTimeValue.TabIndex = 3;
            this.ReadFileTimeValue.Text = "ReadFileTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "3-elements dictionary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "2-elements dictionary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Readfile:";
            // 
            // SetValue
            // 
            this.SetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetValue.Location = new System.Drawing.Point(46, 70);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(365, 35);
            this.SetValue.TabIndex = 5;
            this.SetValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.FoundMatchesValue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox);
            this.groupBox3.Controls.Add(this.SetValue);
            this.groupBox3.Location = new System.Drawing.Point(605, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 482);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(620, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Patryk Piotrowski";
            // 
            // FoundMatchesValue
            // 
            this.FoundMatchesValue.AutoSize = true;
            this.FoundMatchesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FoundMatchesValue.Location = new System.Drawing.Point(676, 70);
            this.FoundMatchesValue.Name = "FoundMatchesValue";
            this.FoundMatchesValue.Size = new System.Drawing.Size(31, 32);
            this.FoundMatchesValue.TabIndex = 8;
            this.FoundMatchesValue.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(452, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Found matches:";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(46, 158);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(365, 37);
            this.comboBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 757);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Statistics.ResumeLayout(false);
            this.Statistics.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FileDirectoryText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Statistics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ReadFileTimeValue;
        private System.Windows.Forms.Label TwoElementsTimeValue;
        private System.Windows.Forms.Label ThreeElementsTimeValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TwoElementsDictionaryCountValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SetValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ThreeElementsDictionaryCountValue;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label FoundMatchesValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

