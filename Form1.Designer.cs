
namespace CopyDirectory
{
    partial class CopyDirectory_DCSL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDirectory_DCSL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_SourceFolder = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_DestinationFolder = new System.Windows.Forms.TextBox();
            this.displayView = new System.Windows.Forms.ListBox();
            this.folderBrowserSourceDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.searchButton_SourceDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDestinationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton_DestinationDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert a valid source and destination directories in order to copy files.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source directory";
            // 
            // Text_SourceFolder
            // 
            this.Text_SourceFolder.Location = new System.Drawing.Point(15, 87);
            this.Text_SourceFolder.Name = "Text_SourceFolder";
            this.Text_SourceFolder.Size = new System.Drawing.Size(598, 22);
            this.Text_SourceFolder.TabIndex = 2;
            this.Text_SourceFolder.TextChanged += new System.EventHandler(this.Text_SourceFolder_TextChanged);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(565, 207);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 34);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination directory";
            // 
            // Text_DestinationFolder
            // 
            this.Text_DestinationFolder.Location = new System.Drawing.Point(15, 158);
            this.Text_DestinationFolder.Name = "Text_DestinationFolder";
            this.Text_DestinationFolder.Size = new System.Drawing.Size(598, 22);
            this.Text_DestinationFolder.TabIndex = 5;
            this.Text_DestinationFolder.TextChanged += new System.EventHandler(this.Text_DestinationFolder_TextChanged);
            // 
            // displayView
            // 
            this.displayView.FormattingEnabled = true;
            this.displayView.ItemHeight = 16;
            this.displayView.Location = new System.Drawing.Point(15, 267);
            this.displayView.Name = "displayView";
            this.displayView.Size = new System.Drawing.Size(635, 164);
            this.displayView.TabIndex = 6;
            // 
            // searchButton_SourceDirectory
            // 
            this.searchButton_SourceDirectory.BackColor = System.Drawing.Color.White;
            this.searchButton_SourceDirectory.Image = ((System.Drawing.Image)(resources.GetObject("searchButton_SourceDirectory.Image")));
            this.searchButton_SourceDirectory.Location = new System.Drawing.Point(619, 83);
            this.searchButton_SourceDirectory.Name = "searchButton_SourceDirectory";
            this.searchButton_SourceDirectory.Size = new System.Drawing.Size(31, 31);
            this.searchButton_SourceDirectory.TabIndex = 7;
            this.searchButton_SourceDirectory.UseVisualStyleBackColor = false;
            this.searchButton_SourceDirectory.Click += new System.EventHandler(this.searchButton_SourceDirectory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Display View";
            // 
            // searchButton_DestinationDirectory
            // 
            this.searchButton_DestinationDirectory.BackColor = System.Drawing.Color.White;
            this.searchButton_DestinationDirectory.Image = ((System.Drawing.Image)(resources.GetObject("searchButton_DestinationDirectory.Image")));
            this.searchButton_DestinationDirectory.Location = new System.Drawing.Point(619, 154);
            this.searchButton_DestinationDirectory.Name = "searchButton_DestinationDirectory";
            this.searchButton_DestinationDirectory.Size = new System.Drawing.Size(31, 31);
            this.searchButton_DestinationDirectory.TabIndex = 10;
            this.searchButton_DestinationDirectory.UseVisualStyleBackColor = false;
            this.searchButton_DestinationDirectory.Click += new System.EventHandler(this.searchButton_DestinationDirectory_Click);
            // 
            // CopyDirectory_DCSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 459);
            this.Controls.Add(this.searchButton_DestinationDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchButton_SourceDirectory);
            this.Controls.Add(this.displayView);
            this.Controls.Add(this.Text_DestinationFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Text_SourceFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CopyDirectory_DCSL";
            this.Text = "CopyDirectory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_SourceFolder;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_DestinationFolder;
        private System.Windows.Forms.ListBox displayView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSourceDialog;
        private System.Windows.Forms.Button searchButton_SourceDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDestinationDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton_DestinationDirectory;
    }
}

