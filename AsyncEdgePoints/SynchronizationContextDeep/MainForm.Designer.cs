namespace SynchronizationContextDeep
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
            this.btnMyPrimitiveSynchronisationContext = new System.Windows.Forms.Button();
            this.btnStaSynchronizationContext = new System.Windows.Forms.Button();
            this.btnWCFSynchronizationContext = new System.Windows.Forms.Button();
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
            // btnMyPrimitiveSynchronisationContext
            // 
            this.btnMyPrimitiveSynchronisationContext.Location = new System.Drawing.Point(12, 41);
            this.btnMyPrimitiveSynchronisationContext.Name = "btnMyPrimitiveSynchronisationContext";
            this.btnMyPrimitiveSynchronisationContext.Size = new System.Drawing.Size(192, 23);
            this.btnMyPrimitiveSynchronisationContext.TabIndex = 8;
            this.btnMyPrimitiveSynchronisationContext.Text = "MyPrimitiveSynchronisationContext";
            this.btnMyPrimitiveSynchronisationContext.UseVisualStyleBackColor = true;
            this.btnMyPrimitiveSynchronisationContext.Click += new System.EventHandler(this.btnMyPrimitiveSynchronisationContext_Click);
            // 
            // btnStaSynchronizationContext
            // 
            this.btnStaSynchronizationContext.Location = new System.Drawing.Point(12, 70);
            this.btnStaSynchronizationContext.Name = "btnStaSynchronizationContext";
            this.btnStaSynchronizationContext.Size = new System.Drawing.Size(192, 23);
            this.btnStaSynchronizationContext.TabIndex = 9;
            this.btnStaSynchronizationContext.Text = "StaSynchronizationContext";
            this.btnStaSynchronizationContext.UseVisualStyleBackColor = true;
            this.btnStaSynchronizationContext.Click += new System.EventHandler(this.btnStaSynchronizationContext_Click);
            // 
            // btnWCFSynchronizationContext
            // 
            this.btnWCFSynchronizationContext.Location = new System.Drawing.Point(12, 99);
            this.btnWCFSynchronizationContext.Name = "btnWCFSynchronizationContext";
            this.btnWCFSynchronizationContext.Size = new System.Drawing.Size(192, 23);
            this.btnWCFSynchronizationContext.TabIndex = 10;
            this.btnWCFSynchronizationContext.Text = "WCF SynchronizationContext";
            this.btnWCFSynchronizationContext.UseVisualStyleBackColor = true;
            this.btnWCFSynchronizationContext.Click += new System.EventHandler(this.btnWCFSynchronizationContext_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 310);
            this.Controls.Add(this.btnWCFSynchronizationContext);
            this.Controls.Add(this.btnStaSynchronizationContext);
            this.Controls.Add(this.btnMyPrimitiveSynchronisationContext);
            this.Controls.Add(this.btnSynchronizationContext);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSynchronizationContext;
        private System.Windows.Forms.Button btnMyPrimitiveSynchronisationContext;
        private System.Windows.Forms.Button btnStaSynchronizationContext;
        private System.Windows.Forms.Button btnWCFSynchronizationContext;
    }
}

