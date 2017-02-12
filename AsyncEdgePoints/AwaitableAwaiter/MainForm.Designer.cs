namespace AwaitableAwaiter
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
            this.btnBasicAwaitable = new System.Windows.Forms.Button();
            this.btnFuncAwaitable = new System.Windows.Forms.Button();
            this.lblFuncResult = new System.Windows.Forms.Label();
            this.btnFuncExtension = new System.Windows.Forms.Button();
            this.btnActionExtension = new System.Windows.Forms.Button();
            this.btnObservable1 = new System.Windows.Forms.Button();
            this.btnObservable2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasicAwaitable
            // 
            this.btnBasicAwaitable.Location = new System.Drawing.Point(12, 12);
            this.btnBasicAwaitable.Name = "btnBasicAwaitable";
            this.btnBasicAwaitable.Size = new System.Drawing.Size(129, 23);
            this.btnBasicAwaitable.TabIndex = 0;
            this.btnBasicAwaitable.Text = "Basic Awaitable";
            this.btnBasicAwaitable.UseVisualStyleBackColor = true;
            this.btnBasicAwaitable.Click += new System.EventHandler(this.btnCustomAwaitable_Click);
            // 
            // btnFuncAwaitable
            // 
            this.btnFuncAwaitable.Location = new System.Drawing.Point(12, 41);
            this.btnFuncAwaitable.Name = "btnFuncAwaitable";
            this.btnFuncAwaitable.Size = new System.Drawing.Size(129, 23);
            this.btnFuncAwaitable.TabIndex = 1;
            this.btnFuncAwaitable.Text = "Func Awaitable";
            this.btnFuncAwaitable.UseVisualStyleBackColor = true;
            this.btnFuncAwaitable.Click += new System.EventHandler(this.btnFuncAwaitable_Click);
            // 
            // lblFuncResult
            // 
            this.lblFuncResult.AutoSize = true;
            this.lblFuncResult.Location = new System.Drawing.Point(160, 46);
            this.lblFuncResult.Name = "lblFuncResult";
            this.lblFuncResult.Size = new System.Drawing.Size(37, 13);
            this.lblFuncResult.TabIndex = 2;
            this.lblFuncResult.Text = "Result";
            // 
            // btnFuncExtension
            // 
            this.btnFuncExtension.Location = new System.Drawing.Point(12, 70);
            this.btnFuncExtension.Name = "btnFuncExtension";
            this.btnFuncExtension.Size = new System.Drawing.Size(129, 23);
            this.btnFuncExtension.TabIndex = 3;
            this.btnFuncExtension.Text = "Func Extension";
            this.btnFuncExtension.UseVisualStyleBackColor = true;
            this.btnFuncExtension.Click += new System.EventHandler(this.btnFuncExtension_Click);
            // 
            // btnActionExtension
            // 
            this.btnActionExtension.Location = new System.Drawing.Point(12, 99);
            this.btnActionExtension.Name = "btnActionExtension";
            this.btnActionExtension.Size = new System.Drawing.Size(129, 23);
            this.btnActionExtension.TabIndex = 4;
            this.btnActionExtension.Text = "Action Extension";
            this.btnActionExtension.UseVisualStyleBackColor = true;
            this.btnActionExtension.Click += new System.EventHandler(this.btnActionExtension_Click);
            // 
            // btnObservable1
            // 
            this.btnObservable1.Location = new System.Drawing.Point(12, 142);
            this.btnObservable1.Name = "btnObservable1";
            this.btnObservable1.Size = new System.Drawing.Size(129, 23);
            this.btnObservable1.TabIndex = 5;
            this.btnObservable1.Text = "Observable 1";
            this.btnObservable1.UseVisualStyleBackColor = true;
            this.btnObservable1.Click += new System.EventHandler(this.btnObservable1_Click);
            // 
            // btnObservable2
            // 
            this.btnObservable2.Location = new System.Drawing.Point(12, 171);
            this.btnObservable2.Name = "btnObservable2";
            this.btnObservable2.Size = new System.Drawing.Size(129, 23);
            this.btnObservable2.TabIndex = 6;
            this.btnObservable2.Text = "Observable 2";
            this.btnObservable2.UseVisualStyleBackColor = true;
            this.btnObservable2.Click += new System.EventHandler(this.btnObservable2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 268);
            this.Controls.Add(this.btnObservable2);
            this.Controls.Add(this.btnObservable1);
            this.Controls.Add(this.btnActionExtension);
            this.Controls.Add(this.btnFuncExtension);
            this.Controls.Add(this.lblFuncResult);
            this.Controls.Add(this.btnFuncAwaitable);
            this.Controls.Add(this.btnBasicAwaitable);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasicAwaitable;
        private System.Windows.Forms.Button btnFuncAwaitable;
        private System.Windows.Forms.Label lblFuncResult;
        private System.Windows.Forms.Button btnFuncExtension;
        private System.Windows.Forms.Button btnActionExtension;
        private System.Windows.Forms.Button btnObservable1;
        private System.Windows.Forms.Button btnObservable2;
    }
}

