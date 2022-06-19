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
                toolStripStatusLabel1.Text = "Total number of drawings = " + lstDwgs.Items.Count.ToString();
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

            }
        }
        private void btnUpdateRef_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
     
            int i = 1;
            AttachRef util = new AttachRef();
            int totalCount = lstDwgs.Items.Count;
            Globals.ReferenceFilter = txtRefFilter.Text;

            // Loop through
            foreach (string dwgFile in lstDwgs.Items)
            {
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel1.Text = "Processing: " + i.ToString() + " of " + totalCount.ToString()  + dwgFile.ToString();
                toolStripStatusLabel1.ForeColor = Color.Green;

                if (txtRefName.Text != null | txtRefFilter.Text != null | txtRefPath.Text != null)
                {
                    util.AttachingRef(dwgFile, txtRefName.Text, txtRefPath.Text, txtRefFilter.Text);
                }

                i += 1;
            }

            
            toolStripStatusLabel1.Text = "Updating of Reference files completed successfuly!";
            toolStripStatusLabel1.ForeColor = Color.Green;
            // Get the script run time
            TimeSpan timeDiff = DateTime.Now - start;
            string runtime = timeDiff.TotalSeconds.ToString();
            try
            {
                
                //adding sharepoint tracker information
                double totalTimeSaved = lstDwgs.Items.Count * 2.3; //calculate time saved per unit times number of files
                SharePointConnectApp.SharePointAdd.AddItem("Sprouts Update Reference", "Autocad", totalTimeSaved.ToString(), Environment.UserName, "22", Globals.projectName, Globals.projectNumber, runtime);


            }
            catch (Exception)
            {

                return;
            }
            
        }


        private void SelectNewRF_Click(object sender, EventArgs e)// get the reference file name and path

        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Globals.DwgsFilePath;
                openFileDialog.Filter = "dwg files (*.dwg)|*.dwg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file D:\Programming\AutoCAD\ARCH
                    string filePath = openFileDialog.FileName;//"D:\Programming\AutoCAD\Base_Files\X_Titleblock30x42_NBTS XXX.dwg" 
                    Globals.newReferenceName = Path.GetFileNameWithoutExtension(filePath);
                    Globals.titleBlockDwgPath = filePath;// get titleblock drawing to extract the project name and number
                    txtRefName.Text = Globals.newReferenceName;
                    // newReferencePath then repalce dwgsPath with "."
                    //string basePath = Globals.DwgsFilePath.Replace("ARCH", @"Base_files\");//not used???? may need to remove??
                    Globals.newReferencePath = @"..\Base_Files\" + Globals.newReferenceName;//filePath.Replace(@"D:\Programming\AutoCAD", "..");// ..\Base_Files\X_Titleblock30x42_NBTS XXX.dwg
                    txtRefPath.Text = Globals.newReferencePath;// D:\Programming\AutoCAD\ARCHX_Titleblock30x42_NBTS XXX  ....D:\Programming\AutoCAD\Base_Files\X_Titleblock30x42_NBTS XXX.dwg
                    AttachRef util = new AttachRef(); 
                    util.GetTitleProjectNameNumber(Globals.titleBlockDwgPath);
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
        public static String titleBlockDwgPath; // Modifiable Global varibles
        public static String projectName; // Modifiable Global varibles
        public static String projectNumber; // Modifiable Global varibles
        public static List<string> titleBlockText; // Modifiable Global varibles
    } 

}
