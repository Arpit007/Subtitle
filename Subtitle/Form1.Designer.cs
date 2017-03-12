namespace Subtitle
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.moviePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subsPath = new System.Windows.Forms.TextBox();
            this.subsPathButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputPathButton = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Progress = new System.Windows.Forms.Label();
            this.moviePathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // moviePath
            // 
            this.moviePath.BackColor = System.Drawing.SystemColors.Window;
            this.moviePath.Location = new System.Drawing.Point(81, 12);
            this.moviePath.Name = "moviePath";
            this.moviePath.ReadOnly = true;
            this.moviePath.Size = new System.Drawing.Size(431, 20);
            this.moviePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtitle";
            // 
            // subsPath
            // 
            this.subsPath.BackColor = System.Drawing.SystemColors.Window;
            this.subsPath.Location = new System.Drawing.Point(81, 44);
            this.subsPath.Name = "subsPath";
            this.subsPath.ReadOnly = true;
            this.subsPath.Size = new System.Drawing.Size(431, 20);
            this.subsPath.TabIndex = 4;
            // 
            // subsPathButton
            // 
            this.subsPathButton.Location = new System.Drawing.Point(534, 40);
            this.subsPathButton.Name = "subsPathButton";
            this.subsPathButton.Size = new System.Drawing.Size(59, 23);
            this.subsPathButton.TabIndex = 5;
            this.subsPathButton.Text = "Browse";
            this.subsPathButton.UseVisualStyleBackColor = true;
            this.subsPathButton.Click += new System.EventHandler(this.subsPathButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(506, 119);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputPathButton
            // 
            this.outputPathButton.Location = new System.Drawing.Point(533, 69);
            this.outputPathButton.Name = "outputPathButton";
            this.outputPathButton.Size = new System.Drawing.Size(59, 23);
            this.outputPathButton.TabIndex = 9;
            this.outputPathButton.Text = "Browse";
            this.outputPathButton.UseVisualStyleBackColor = true;
            this.outputPathButton.Click += new System.EventHandler(this.outputPathButton_Click);
            // 
            // outputPath
            // 
            this.outputPath.BackColor = System.Drawing.SystemColors.Window;
            this.outputPath.Location = new System.Drawing.Point(80, 73);
            this.outputPath.Name = "outputPath";
            this.outputPath.ReadOnly = true;
            this.outputPath.Size = new System.Drawing.Size(431, 20);
            this.outputPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output";
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(78, 129);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(120, 13);
            this.Progress.TabIndex = 10;
            this.Progress.Text = "No Ongoing Conversion";
            // 
            // moviePathButton
            // 
            this.moviePathButton.Location = new System.Drawing.Point(534, 12);
            this.moviePathButton.Name = "moviePathButton";
            this.moviePathButton.Size = new System.Drawing.Size(59, 22);
            this.moviePathButton.TabIndex = 2;
            this.moviePathButton.Text = "Browse";
            this.moviePathButton.UseVisualStyleBackColor = true;
            this.moviePathButton.Click += new System.EventHandler(this.moviePathButton_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 163);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.outputPathButton);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.subsPathButton);
            this.Controls.Add(this.subsPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moviePathButton);
            this.Controls.Add(this.moviePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Subtitles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox moviePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subsPath;
        private System.Windows.Forms.Button subsPathButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button outputPathButton;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.Button moviePathButton;
    }
}

