namespace TaskVsVoid
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
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(33, 23);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(75, 23);
            this.btnVoid.TabIndex = 0;
            this.btnVoid.Text = "void";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(33, 68);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(75, 23);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(200, 23);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(75, 23);
            this.btnGC.TabIndex = 2;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 133);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnVoid);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnGC;
    }
}

