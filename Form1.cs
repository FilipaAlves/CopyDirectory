using System;
using System.IO;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class CopyDirectory_DCSL : Form
    {
        public CopyDirectory_DCSL()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            displayView.Items.Clear();
            string sourceDirText = Text_SourceFolder.Text;
            string destinationDirText = Text_DestinationFolder.Text;

            if (sourceDirText == destinationDirText)
            {
                MessageBox.Show("Error: Source and destination folder can't be the same, please change the destination folder");
            }
            else
            {
                try
                {
                    CopyDirectory(sourceDirText, destinationDirText);

                    MessageBox.Show("Copied successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in the process: " + ex.Message);
                }
            }
        }

        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            var getDirectoryInfo = new DirectoryInfo(sourceDir);

            if (!getDirectoryInfo.Exists)
            {
                throw new DirectoryNotFoundException(string.Format("The input {0} is invalid", sourceDir));
            }

            var pathsDirectory = getDirectoryInfo.GetDirectories();

            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            var files = getDirectoryInfo.GetFiles();

            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destinationDir, file.Name), true);
                displayView.Items.Add(string.Format("Copied file {0} from the path {1}", file.Name, sourceDir));
            }

            foreach (var subdir in pathsDirectory)
            {        
                CopyDirectory(subdir.FullName, Path.Combine(destinationDir, subdir.Name));
            }
        }

        private void searchButton_SourceDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserSourceDialog.ShowDialog() == DialogResult.OK)
            {
                Text_SourceFolder.Text = folderBrowserSourceDialog.SelectedPath;
            }
        }

        private void searchButton_DestinationDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDestinationDialog.ShowDialog() == DialogResult.OK)
            {
                Text_DestinationFolder.Text = folderBrowserDestinationDialog.SelectedPath;
            }
        }

        private void Text_SourceFolder_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(Text_DestinationFolder.Text))
                    submit.Enabled = false;
                else
                submit.Enabled = true;
        }

        private void Text_DestinationFolder_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text_SourceFolder.Text))
                submit.Enabled = false;
            else
                submit.Enabled = true;
        }
    }
}
