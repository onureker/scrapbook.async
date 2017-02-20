namespace TaskRunVsAwaitTaskRun
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
            this.btnTaskRunReturn = new System.Windows.Forms.Button();
            this.btnTaskRunAwait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaskRunReturn
            // 
            this.btnTaskRunReturn.Location = new System.Drawing.Point(12, 12);
            this.btnTaskRunReturn.Name = "btnTaskRunReturn";
            this.btnTaskRunReturn.Size = new System.Drawing.Size(153, 23);
            this.btnTaskRunReturn.TabIndex = 0;
            this.btnTaskRunReturn.Text = "Task.Run returned";
            this.btnTaskRunReturn.UseVisualStyleBackColor = true;
            this.btnTaskRunReturn.Click += new System.EventHandler(this.btnTaskRunReturn_Click);
            // 
            // btnTaskRunAwait
            // 
            this.btnTaskRunAwait.Location = new System.Drawing.Point(12, 41);
            this.btnTaskRunAwait.Name = "btnTaskRunAwait";
            this.btnTaskRunAwait.Size = new System.Drawing.Size(153, 23);
            this.btnTaskRunAwait.TabIndex = 1;
            this.btnTaskRunAwait.Text = "await Task.Run";
            this.btnTaskRunAwait.UseVisualStyleBackColor = true;
            this.btnTaskRunAwait.Click += new System.EventHandler(this.btnTaskRunAwait_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 89);
            this.Controls.Add(this.btnTaskRunAwait);
            this.Controls.Add(this.btnTaskRunReturn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaskRunReturn;
        private System.Windows.Forms.Button btnTaskRunAwait;
    }
}

