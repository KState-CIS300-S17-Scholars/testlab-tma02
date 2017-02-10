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
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxUpperBound = new System.Windows.Forms.TextBox();
            this.uxPrimes = new System.Windows.Forms.TextBox();
            this.uxFindPrimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(12, 15);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(81, 13);
            this.uxLabel.TabIndex = 0;
            this.uxLabel.Text = "Positve bound: ";
            // 
            // uxUpperBound
            // 
            this.uxUpperBound.Location = new System.Drawing.Point(99, 12);
            this.uxUpperBound.Name = "uxUpperBound";
            this.uxUpperBound.Size = new System.Drawing.Size(173, 20);
            this.uxUpperBound.TabIndex = 1;
            // 
            // uxPrimes
            // 
            this.uxPrimes.Location = new System.Drawing.Point(12, 67);
            this.uxPrimes.Multiline = true;
            this.uxPrimes.Name = "uxPrimes";
            this.uxPrimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxPrimes.Size = new System.Drawing.Size(260, 182);
            this.uxPrimes.TabIndex = 2;
            // 
            // uxFindPrimes
            // 
            this.uxFindPrimes.Location = new System.Drawing.Point(12, 38);
            this.uxFindPrimes.Name = "uxFindPrimes";
            this.uxFindPrimes.Size = new System.Drawing.Size(260, 23);
            this.uxFindPrimes.TabIndex = 3;
            this.uxFindPrimes.Text = "Find Primes";
            this.uxFindPrimes.UseVisualStyleBackColor = true;
            this.uxFindPrimes.Click += new System.EventHandler(this.uxFindPrimes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxFindPrimes);
            this.Controls.Add(this.uxPrimes);
            this.Controls.Add(this.uxUpperBound);
            this.Controls.Add(this.uxLabel);
            this.Name = "Form1";
            this.Text = "Sieve of Eratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.TextBox uxUpperBound;
        private System.Windows.Forms.TextBox uxPrimes;
        private System.Windows.Forms.Button uxFindPrimes;
    }
}

