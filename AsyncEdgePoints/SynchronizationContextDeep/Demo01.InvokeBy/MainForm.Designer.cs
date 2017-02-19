namespace SynchronizationContextDeep.Demo01.InvokeBy
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
            this.btnSynchronizationContext = new System.Windows.Forms.Button();
            this.lbSynchronizationContext = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSynchronizationContext
            // 
            this.btnSynchronizationContext.Location = new System.Drawing.Point(12, 12);
            this.btnSynchronizationContext.Name = "btnSynchronizationContext";
            this.btnSynchronizationContext.Size = new System.Drawing.Size(192, 23);
            this.btnSynchronizationContext.TabIndex = 6;
            this.btnSynchronizationContext.Text = "Invoke By SynchronizationContext";
            this.btnSynchronizationContext.UseVisualStyleBackColor = true;
            this.btnSynchronizationContext.Click += new System.EventHandler(this.btnSynchronizationContext_Click);
            // 
            // lbSynchronizationContext
            // 
            this.lbSynchronizationContext.FormattingEnabled = true;
            this.lbSynchronizationContext.Location = new System.Drawing.Point(12, 41);
            this.lbSynchronizationContext.Name = "lbSynchronizationContext";
            this.lbSynchronizationContext.Size = new System.Drawing.Size(192, 316);
            this.lbSynchronizationContext.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 374);
            this.Controls.Add(this.lbSynchronizationContext);
            this.Controls.Add(this.btnSynchronizationContext);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSynchronizationContext;
        private System.Windows.Forms.ListBox lbSynchronizationContext;
    }
}

