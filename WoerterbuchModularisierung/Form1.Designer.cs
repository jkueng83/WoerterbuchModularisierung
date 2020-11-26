namespace WoerterbuchModularisierung
{
    partial class Dictionary
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
            this.btReadDataFromFile = new System.Windows.Forms.Button();
            this.btWriteDataToFile = new System.Windows.Forms.Button();
            this.lBoxABC = new System.Windows.Forms.ListBox();
            this.lBoxSearchResult = new System.Windows.Forms.ListBox();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btReadDataFromFile
            // 
            this.btReadDataFromFile.Location = new System.Drawing.Point(67, 30);
            this.btReadDataFromFile.Name = "btReadDataFromFile";
            this.btReadDataFromFile.Size = new System.Drawing.Size(100, 23);
            this.btReadDataFromFile.TabIndex = 0;
            this.btReadDataFromFile.Text = "read data form file";
            this.btReadDataFromFile.UseVisualStyleBackColor = true;
            this.btReadDataFromFile.Click += new System.EventHandler(this.btReadDataFromFile_Click);
            // 
            // btWriteDataToFile
            // 
            this.btWriteDataToFile.Location = new System.Drawing.Point(187, 30);
            this.btWriteDataToFile.Name = "btWriteDataToFile";
            this.btWriteDataToFile.Size = new System.Drawing.Size(100, 23);
            this.btWriteDataToFile.TabIndex = 1;
            this.btWriteDataToFile.Text = "write data to file";
            this.btWriteDataToFile.UseVisualStyleBackColor = true;
            this.btWriteDataToFile.Click += new System.EventHandler(this.btWriteDataToFile_Click);
            // 
            // lBoxABC
            // 
            this.lBoxABC.FormattingEnabled = true;
            this.lBoxABC.Location = new System.Drawing.Point(12, 102);
            this.lBoxABC.Name = "lBoxABC";
            this.lBoxABC.Size = new System.Drawing.Size(49, 212);
            this.lBoxABC.TabIndex = 3;
            this.lBoxABC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lBoxABC_MouseClick);
            // 
            // lBoxSearchResult
            // 
            this.lBoxSearchResult.FormattingEnabled = true;
            this.lBoxSearchResult.Location = new System.Drawing.Point(67, 102);
            this.lBoxSearchResult.Name = "lBoxSearchResult";
            this.lBoxSearchResult.Size = new System.Drawing.Size(549, 212);
            this.lBoxSearchResult.TabIndex = 4;
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(67, 72);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(220, 20);
            this.tBoxSearch.TabIndex = 5;
            this.tBoxSearch.TextChanged += new System.EventHandler(this.tBoxSearch_TextChanged);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 338);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.lBoxSearchResult);
            this.Controls.Add(this.lBoxABC);
            this.Controls.Add(this.btWriteDataToFile);
            this.Controls.Add(this.btReadDataFromFile);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReadDataFromFile;
        private System.Windows.Forms.Button btWriteDataToFile;
        private System.Windows.Forms.ListBox lBoxABC;
        private System.Windows.Forms.ListBox lBoxSearchResult;
        private System.Windows.Forms.TextBox tBoxSearch;
    }
}

