namespace SynchronizationContextDeep.Demo03.StaSyncContext
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
            this.btnStaSynchronizationContext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaSynchronizationContext
            // 
            this.btnStaSynchronizationContext.Location = new System.Drawing.Point(12, 12);
            this.btnStaSynchronizationContext.Name = "btnStaSynchronizationContext";
            this.btnStaSynchronizationContext.Size = new System.Drawing.Size(192, 23);
            this.btnStaSynchronizationContext.TabIndex = 9;
            this.btnStaSynchronizationContext.Text = "StaSynchronizationContext";
            this.btnStaSynchronizationContext.UseVisualStyleBackColor = true;
            this.btnStaSynchronizationContext.Click += new System.EventHandler(this.btnStaSynchronizationContext_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 167);
            this.Controls.Add(this.btnStaSynchronizationContext);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStaSynchronizationContext;
    }
}

