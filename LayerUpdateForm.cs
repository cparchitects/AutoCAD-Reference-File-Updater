using System;
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




namespace AutoUpdateRef
{
    
    public partial class RefUpdateForm : Form
    {
        
        public RefUpdateForm()
        {
            InitializeComponent();
        }

        private void RefUpdateForm_Load(object sender, EventArgs e)
        {

            //PopulateListbox(txtPath.Text.Trim());

        }

        private void PopulateListbox(string dwgPath)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = dwgPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");

                // Load all the files into the listbox
                lstDwgs.DataSource = files;
                toolStripStatusLabel1.Text = "Total number of drawingings = " + lstDwgs.Items.Count;
            }
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            // switch to make the file dialog to accept folder in place of file selector
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)//(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // send user selected path to function call
                var docPath = dialog.FileName;
                Globals.DwgsFilePath = docPath;

                // get files with directory
                string[] files = Directory.GetFiles(docPath, "*.dwg");

                PopulateListbox(docPath);
                //adding sharepoint tracker information
                SharePointConnectApp.SharePointAdd.AddItem("Sprouts Update Reference", "Autocad", "3", Environment.UserName, "22", "Sprouts Testing", "222222", "2.5");
            }
        }
        private void btnUpdateRef_Click(object sender, EventArgs e)
        {
            int i = 1;
            AttachRef util = new AttachRef();
            int totalCount = lstDwgs.Items.Count;
            Globals.ReferenceFilter = txtRefFilter.Text;

            // Loop through
            foreach (string dwgFile in lstDwgs.Items)
            {                
                toolStripStatusLabel1.Text = "Processing ( " + i.ToString() + " of " + totalCount + ") : " + dwgFile;
                toolStripStatusLabel1.ForeColor = Color.Green;

                if (Globals.newReferenceName != null | Globals.ReferenceFilter != null | Globals.newReferencePath != null)
                {
                    util.AttachingRef(dwgFile, Globals.newReferenceName, Globals.newReferencePath, Globals.ReferenceFilter);
                }

                i += 1;
            }
            
            toolStripStatusLabel1.Text = "Updating of Reference files completed successfuly!";
            toolStripStatusLabel1.ForeColor = Color.Green;
            
        }

        
        private void SelectNewRF_Click(object sender, EventArgs e)// get the reference file name and path

        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "dwg files (*.dwg)|*.dwg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    Globals.newReferenceName = Path.GetFileNameWithoutExtension(filePath);
                    lblRefName.Text = Globals.newReferenceName;
                    // newReferencePath then repalce dwgsPath with "."
                    Globals.newReferencePath = filePath.Replace(Globals.DwgsFilePath, ".");
                    lblRefPath.Text = Globals.newReferencePath;
                }
            }
        }
        
    }
    public static class Globals
    {
        public static String DwgsFilePath; // Modifiable Global varibles
        public static String newReferenceName; // Modifiable Global varibles
        public static String newReferencePath; // Modifiable Global varibles
        public static String ReferenceFilter; // Modifiable Global varibles

    }
 

}
