namespace TaskYield
{
    partial class MainForm
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
            this.btnWithYield = new System.Windows.Forms.Button();
            this.btnWithoutYield = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithYield
            // 
            this.btnWithYield.Location = new System.Drawing.Point(12, 12);
            this.btnWithYield.Name = "btnWithYield";
            this.btnWithYield.Size = new System.Drawing.Size(119, 23);
            this.btnWithYield.TabIndex = 0;
            this.btnWithYield.Text = "Do With Yield";
            this.btnWithYield.UseVisualStyleBackColor = true;
            this.btnWithYield.Click += new System.EventHandler(this.btnWithYield_Click);
            // 
            // btnWithoutYield
            // 
            this.btnWithoutYield.Location = new System.Drawing.Point(12, 41);
            this.btnWithoutYield.Name = "btnWithoutYield";
            this.btnWithoutYield.Size = new System.Drawing.Size(119, 23);
            this.btnWithoutYield.TabIndex = 1;
            this.btnWithoutYield.Text = "Do Without Yield";
            this.btnWithoutYield.UseVisualStyleBackColor = true;
            this.btnWithoutYield.Click += new System.EventHandler(this.btnWithoutYield_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWithoutYield);
            this.Controls.Add(this.btnWithYield);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithYield;
        private System.Windows.Forms.Button btnWithoutYield;
    }
}

