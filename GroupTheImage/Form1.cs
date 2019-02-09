using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GroupTheImage
{
    public partial class Form1 : Form
    {
        private string sourcePath = string.Empty;
        private string outputPath = string.Empty;
        private List<string> extensions = new List<string>();

        // Default value
        private GroupItTools.GroupOption option = GroupItTools.GroupOption.Copy;

        CommonOpenFileDialog dialog = new CommonOpenFileDialog()
        { IsFolderPicker = true, InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetSourcePath_Click(object sender, EventArgs e)
        {
            dialog.Title = "Select resource folder";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                sourcePath = dialog.FileName;
                txtBoxSource.Text = sourcePath;

                var content = GroupItTools.GetContent(sourcePath);
                StringBuilder sbBasicInfo = new StringBuilder();
                int count  = 0;

                //  Amount
                content.ForEach(c => count++);

                //  File extensnions
                extensions.Clear();
                foreach (string fileName in content)
                {
                    var ext = Path.GetExtension(fileName);
                    if (!extensions.Contains(ext.ToLower()))
                    {
                        extensions.Add(ext.ToLower());
                    }
                }

                lblBasicInfo.Text = $"Info: Total files: {count}";

                List<int> boxesWidths = new List<int>();
                for (int i = 0; i < extensions.Count; i++)
                {
                    boxesWidths.Add(extensions[i].Length);
                    chkBoxList.Items.Add(extensions[i]);
                }

                chkBoxList.ColumnWidth = boxesWidths.Max() * 15;
            }
        }

        private void btnGetDestination_Click(object sender, EventArgs e)
        {
            dialog.Title = "Select output folder";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputPath = dialog.FileName;
                txtBoxDestination.Text = outputPath;
            }
        }

        private void rbMmove_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMmove.Checked)
                option = GroupItTools.GroupOption.Move;
        }

        private void rdCopy_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCopy.Checked)
                option = GroupItTools.GroupOption.Copy;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var chosenFileTypes = chkBoxList.CheckedItems.Cast<string>().ToList();

                // TODO: Remove hardcoded paths
                sourcePath = @"D:\Pictures\all";
                outputPath = @"D:\Pictures\output";
                chosenFileTypes = new List<string>() { ".jpg", ".cr2" };

                // Call Group API main function
                GroupItTools.GroupImages(sourcePath, outputPath, new List<string>(), option);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
