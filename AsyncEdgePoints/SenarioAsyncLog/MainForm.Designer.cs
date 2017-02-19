namespace SenarioAsyncLog
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
            this.btnInsertLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertLogs
            // 
            this.btnInsertLogs.Location = new System.Drawing.Point(12, 12);
            this.btnInsertLogs.Name = "btnInsertLogs";
            this.btnInsertLogs.Size = new System.Drawing.Size(103, 23);
            this.btnInsertLogs.TabIndex = 0;
            this.btnInsertLogs.Text = "Insert Logs";
            this.btnInsertLogs.UseVisualStyleBackColor = true;
            this.btnInsertLogs.Click += new System.EventHandler(this.btnInsertLogs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnInsertLogs);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertLogs;
    }
}

