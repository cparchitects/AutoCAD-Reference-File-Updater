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
            PopulateListbox(txtPath.Text.Trim());

        }

        private void PopulateListbox(string dwgPath)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = dwgPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");

                // Load all the files into the listbox
                lstDwgs.DataSource = files;
                lblInfo.Text = "Total number of drawingings = " + lstDwgs.Items.Count;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PopulateListbox(fbd.SelectedPath);
                }
            }
        }

        private void btnUpdateRef_Click(object sender, EventArgs e)
        {
            int i = 1;
            AttachRef util = new AttachRef();
            int totalCount = lstDwgs.Items.Count;

            // Loop through
            foreach (string dwgFile in lstDwgs.Items)
            {
                lblInfo.Text = "Processing ( " + i.ToString() + " of " + totalCount + ") : " + dwgFile;
                lblInfo.ForeColor = Color.Green;
                string newReferenceFile = txtRefNew.Text;
                string ReferenceFilter = txtRefFilter.Text;
                if (newReferenceFile != null | ReferenceFilter != null)
                {
                    util.AttachingRef(dwgFile, newReferenceFile, ReferenceFilter);
                }
                
                i += 1;
            }
            lblInfo.Text = "Updating of Reference files completed successfuly!";
        }

        private void button1_Click(object sender, EventArgs e)// get the reference file name and path
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
                    

                    txtRefNew.Text = filePath;
                                                                                
                }
            }
        }
    }
}
