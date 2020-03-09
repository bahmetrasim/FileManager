namespace FileManager
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
            this.Open = new System.Windows.Forms.Button();
            this.Save_As = new System.Windows.Forms.Button();
            this.SSort = new System.Windows.Forms.RadioButton();
            this.BSort = new System.Windows.Forms.RadioButton();
            this.MSort = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(291, 155);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(198, 39);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save_As
            // 
            this.Save_As.Location = new System.Drawing.Point(291, 217);
            this.Save_As.Name = "Save_As";
            this.Save_As.Size = new System.Drawing.Size(198, 49);
            this.Save_As.TabIndex = 1;
            this.Save_As.Text = "Save As";
            this.Save_As.UseVisualStyleBackColor = true;
            this.Save_As.Click += new System.EventHandler(this.Save_As_Click);
            // 
            // SSort
            // 
            this.SSort.AutoSize = true;
            this.SSort.Location = new System.Drawing.Point(212, 74);
            this.SSort.Name = "SSort";
            this.SSort.Size = new System.Drawing.Size(101, 19);
            this.SSort.TabIndex = 2;
            this.SSort.TabStop = true;
            this.SSort.Text = "Selection Sort";
            this.SSort.UseVisualStyleBackColor = true;
            // 
            // BSort
            // 
            this.BSort.AutoSize = true;
            this.BSort.Location = new System.Drawing.Point(386, 74);
            this.BSort.Name = "BSort";
            this.BSort.Size = new System.Drawing.Size(82, 19);
            this.BSort.TabIndex = 3;
            this.BSort.TabStop = true;
            this.BSort.Text = "Buble Sort";
            this.BSort.UseVisualStyleBackColor = true;
            // 
            // MSort
            // 
            this.MSort.AutoSize = true;
            this.MSort.Location = new System.Drawing.Point(538, 74);
            this.MSort.Name = "MSort";
            this.MSort.Size = new System.Drawing.Size(61, 19);
            this.MSort.TabIndex = 4;
            this.MSort.TabStop = true;
            this.MSort.Text = "Merge";
            this.MSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MSort);
            this.Controls.Add(this.BSort);
            this.Controls.Add(this.SSort);
            this.Controls.Add(this.Save_As);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save_As;
        private System.Windows.Forms.RadioButton SSort;
        private System.Windows.Forms.RadioButton BSort;
        private System.Windows.Forms.RadioButton MSort;
    }
}

