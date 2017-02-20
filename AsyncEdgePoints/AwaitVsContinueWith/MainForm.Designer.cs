namespace AwaitVsContinueWith
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
            this.btnContinueWith = new System.Windows.Forms.Button();
            this.btnAwaited = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinueWith
            // 
            this.btnContinueWith.Location = new System.Drawing.Point(12, 41);
            this.btnContinueWith.Name = "btnContinueWith";
            this.btnContinueWith.Size = new System.Drawing.Size(128, 23);
            this.btnContinueWith.TabIndex = 3;
            this.btnContinueWith.Text = "Continue With";
            this.btnContinueWith.UseVisualStyleBackColor = true;
            this.btnContinueWith.Click += new System.EventHandler(this.btnContinueWith_Click);
            // 
            // btnAwaited
            // 
            this.btnAwaited.Location = new System.Drawing.Point(12, 12);
            this.btnAwaited.Name = "btnAwaited";
            this.btnAwaited.Size = new System.Drawing.Size(128, 23);
            this.btnAwaited.TabIndex = 2;
            this.btnAwaited.Text = "Awaited";
            this.btnAwaited.UseVisualStyleBackColor = true;
            this.btnAwaited.Click += new System.EventHandler(this.btnAwaited_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(169, 14);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(135, 21);
            this.tbResult.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 102);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnContinueWith);
            this.Controls.Add(this.btnAwaited);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinueWith;
        private System.Windows.Forms.Button btnAwaited;
        private System.Windows.Forms.TextBox tbResult;
    }
}

