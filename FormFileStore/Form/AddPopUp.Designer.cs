namespace FormFileStore.Form
{
    partial class ErrorDialogBox
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
            this.bOkError = new System.Windows.Forms.Button();
            this.lError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOkError
            // 
            this.bOkError.Location = new System.Drawing.Point(227, 82);
            this.bOkError.Name = "bOkError";
            this.bOkError.Size = new System.Drawing.Size(75, 23);
            this.bOkError.TabIndex = 0;
            this.bOkError.Text = "OK";
            this.bOkError.UseVisualStyleBackColor = true;
            this.bOkError.UseWaitCursor = true;
            this.bOkError.Click += new System.EventHandler(this.button1_Click);
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(33, 27);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 13);
            this.lError.TabIndex = 1;
            this.lError.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrorDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 131);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.bOkError);
            this.Name = "ErrorDialogBox";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOkError;
        private System.Windows.Forms.Label lError;
    }
}