﻿namespace RuntimeContext
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
            this.btnAwaited = new System.Windows.Forms.Button();
            this.btnContinueWith = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWithExecutionContext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAwaited
            // 
            this.btnAwaited.Location = new System.Drawing.Point(12, 12);
            this.btnAwaited.Name = "btnAwaited";
            this.btnAwaited.Size = new System.Drawing.Size(128, 23);
            this.btnAwaited.TabIndex = 0;
            this.btnAwaited.Text = "Awaited";
            this.btnAwaited.UseVisualStyleBackColor = true;
            this.btnAwaited.Click += new System.EventHandler(this.btnAwaited_Click);
            // 
            // btnContinueWith
            // 
            this.btnContinueWith.Location = new System.Drawing.Point(12, 41);
            this.btnContinueWith.Name = "btnContinueWith";
            this.btnContinueWith.Size = new System.Drawing.Size(128, 23);
            this.btnContinueWith.TabIndex = 1;
            this.btnContinueWith.Text = "Continue With";
            this.btnContinueWith.UseVisualStyleBackColor = true;
            this.btnContinueWith.Click += new System.EventHandler(this.btnContinueWith_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 2;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnContinueWith);
            this.Controls.Add(this.btnAwaited);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAwaited;
        private System.Windows.Forms.Button btnContinueWith;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWithExecutionContext;
        private System.Windows.Forms.Button button1;
    }
}

