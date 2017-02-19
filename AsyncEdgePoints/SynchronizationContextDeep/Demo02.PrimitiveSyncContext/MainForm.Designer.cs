namespace SynchronizationContextDeep.Demo02.PrimitiveSyncContext
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
            this.btnMyPrimitiveSynchronisationContext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyPrimitiveSynchronisationContext
            // 
            this.btnMyPrimitiveSynchronisationContext.Location = new System.Drawing.Point(12, 12);
            this.btnMyPrimitiveSynchronisationContext.Name = "btnMyPrimitiveSynchronisationContext";
            this.btnMyPrimitiveSynchronisationContext.Size = new System.Drawing.Size(192, 23);
            this.btnMyPrimitiveSynchronisationContext.TabIndex = 8;
            this.btnMyPrimitiveSynchronisationContext.Text = "MyPrimitiveSynchronisationContext";
            this.btnMyPrimitiveSynchronisationContext.UseVisualStyleBackColor = true;
            this.btnMyPrimitiveSynchronisationContext.Click += new System.EventHandler(this.btnMyPrimitiveSynchronisationContext_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 374);
            this.Controls.Add(this.btnMyPrimitiveSynchronisationContext);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMyPrimitiveSynchronisationContext;
    }
}

