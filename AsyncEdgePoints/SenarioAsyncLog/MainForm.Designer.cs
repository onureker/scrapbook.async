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
            this.btnConsoleLog = new System.Windows.Forms.Button();
            this.btnTraceLog1 = new System.Windows.Forms.Button();
            this.btnDBLog = new System.Windows.Forms.Button();
            this.btnHostingEnviornment = new System.Windows.Forms.Button();
            this.btnTraceLog2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsoleLog
            // 
            this.btnConsoleLog.Location = new System.Drawing.Point(12, 12);
            this.btnConsoleLog.Name = "btnConsoleLog";
            this.btnConsoleLog.Size = new System.Drawing.Size(150, 23);
            this.btnConsoleLog.TabIndex = 0;
            this.btnConsoleLog.Text = "Log To Console (1000)";
            this.btnConsoleLog.UseVisualStyleBackColor = true;
            this.btnConsoleLog.Click += new System.EventHandler(this.btnConsoleLog_Click);
            // 
            // btnTraceLog1
            // 
            this.btnTraceLog1.Location = new System.Drawing.Point(12, 41);
            this.btnTraceLog1.Name = "btnTraceLog1";
            this.btnTraceLog1.Size = new System.Drawing.Size(150, 23);
            this.btnTraceLog1.TabIndex = 1;
            this.btnTraceLog1.Text = "Log To Trace (1000)";
            this.btnTraceLog1.UseVisualStyleBackColor = true;
            this.btnTraceLog1.Click += new System.EventHandler(this.btnTraceLog_Click);
            // 
            // btnDBLog
            // 
            this.btnDBLog.Location = new System.Drawing.Point(12, 70);
            this.btnDBLog.Name = "btnDBLog";
            this.btnDBLog.Size = new System.Drawing.Size(150, 23);
            this.btnDBLog.TabIndex = 2;
            this.btnDBLog.Text = "Log To DB (10)";
            this.btnDBLog.UseVisualStyleBackColor = true;
            this.btnDBLog.Click += new System.EventHandler(this.btnDBLog_Click);
            // 
            // btnHostingEnviornment
            // 
            this.btnHostingEnviornment.Location = new System.Drawing.Point(12, 121);
            this.btnHostingEnviornment.Name = "btnHostingEnviornment";
            this.btnHostingEnviornment.Size = new System.Drawing.Size(150, 23);
            this.btnHostingEnviornment.TabIndex = 3;
            this.btnHostingEnviornment.Text = "HostingEnviornment";
            this.btnHostingEnviornment.UseVisualStyleBackColor = true;
            this.btnHostingEnviornment.Click += new System.EventHandler(this.btnHostingEnviornment_Click);
            // 
            // btnTraceLog2
            // 
            this.btnTraceLog2.Location = new System.Drawing.Point(168, 41);
            this.btnTraceLog2.Name = "btnTraceLog2";
            this.btnTraceLog2.Size = new System.Drawing.Size(150, 23);
            this.btnTraceLog2.TabIndex = 4;
            this.btnTraceLog2.Text = "Log To Trace (1000)";
            this.btnTraceLog2.UseVisualStyleBackColor = true;
            this.btnTraceLog2.Click += new System.EventHandler(this.btnTraceLog2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 217);
            this.Controls.Add(this.btnTraceLog2);
            this.Controls.Add(this.btnHostingEnviornment);
            this.Controls.Add(this.btnDBLog);
            this.Controls.Add(this.btnTraceLog1);
            this.Controls.Add(this.btnConsoleLog);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsoleLog;
        private System.Windows.Forms.Button btnTraceLog1;
        private System.Windows.Forms.Button btnDBLog;
        private System.Windows.Forms.Button btnHostingEnviornment;
        private System.Windows.Forms.Button btnTraceLog2;
    }
}

