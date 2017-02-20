namespace RuntimeContext
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
            this.btnWithExecutionContext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithExecutionContext
            // 
            this.btnWithExecutionContext.Location = new System.Drawing.Point(12, 86);
            this.btnWithExecutionContext.Name = "btnWithExecutionContext";
            this.btnWithExecutionContext.Size = new System.Drawing.Size(282, 23);
            this.btnWithExecutionContext.TabIndex = 3;
            this.btnWithExecutionContext.Text = "With ExecutionContext";
            this.btnWithExecutionContext.UseVisualStyleBackColor = true;
            this.btnWithExecutionContext.Click += new System.EventHandler(this.btnWithExecutionContext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "With ExecutionContext-SynchronizationContext";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWithExecutionContext);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWithExecutionContext;
        private System.Windows.Forms.Button button1;
    }
}

