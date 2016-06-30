namespace FormFileStore.View
{
    partial class Form1
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearchId = new System.Windows.Forms.TextBox();
            this.rtbSearchResult = new System.Windows.Forms.RichTextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.bGetAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(134, 61);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(119, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIRSTNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LASTNAME";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(134, 87);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(119, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PERSON ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(134, 35);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(119, 20);
            this.tbId.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(51, 113);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(98, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "ADD";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(293, 58);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 7;
            this.bSearch.Text = "SEARCH";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearchId
            // 
            this.tbSearchId.Location = new System.Drawing.Point(374, 60);
            this.tbSearchId.Name = "tbSearchId";
            this.tbSearchId.Size = new System.Drawing.Size(100, 20);
            this.tbSearchId.TabIndex = 8;
            // 
            // rtbSearchResult
            // 
            this.rtbSearchResult.Location = new System.Drawing.Point(51, 168);
            this.rtbSearchResult.Name = "rtbSearchResult";
            this.rtbSearchResult.Size = new System.Drawing.Size(519, 265);
            this.rtbSearchResult.TabIndex = 9;
            this.rtbSearchResult.Text = " ";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(293, 94);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "DELETE";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(374, 94);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(100, 20);
            this.tbDelete.TabIndex = 11;
            // 
            // bGetAll
            // 
            this.bGetAll.Location = new System.Drawing.Point(495, 139);
            this.bGetAll.Name = "bGetAll";
            this.bGetAll.Size = new System.Drawing.Size(75, 23);
            this.bGetAll.TabIndex = 12;
            this.bGetAll.Text = "GET ALL";
            this.bGetAll.UseVisualStyleBackColor = true;
            this.bGetAll.Click += new System.EventHandler(this.bGetAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bGetAll);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.rtbSearchResult);
            this.Controls.Add(this.tbSearchId);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.RichTextBox rtbSearchResult;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.Button bGetAll;
        private System.Windows.Forms.Button button1;
    }
}