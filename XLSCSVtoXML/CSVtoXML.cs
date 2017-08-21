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
using System.Xml.Linq;

namespace XLSCSVtoXML
{
    public partial class CSVtoXML : Form
    {
        private OpenFileDialog openFileDialogModule;
        private FolderBrowserDialog folderBrowserDialogModule;
        private string selectedFolder;
        private BindingList<string> listOfSelectedFileAddresses;
        private BindingList<string> listOfSelectedFileNames;
        private BindingList<string> listOfFailedConversions;

        public CSVtoXML()
        {
            InitializeComponent();

            openFileDialogModule = new OpenFileDialog();
            openFileDialogModule.Multiselect = true;
            folderBrowserDialogModule = new FolderBrowserDialog();

            listOfFailedConversions = new BindingList<string>();
        }

        private void actionOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogModule.Filter = "CSV |*.csv"; //|XLS|*.xls comming soon.
            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                listOfSelectedFileAddresses = new BindingList<string>(openFileDialogModule.FileNames);
                listOfSelectedFileNames = new BindingList<string>(openFileDialogModule.SafeFileNames);
                outputSelectedFiles.DataSource = listOfSelectedFileNames;
            }

        }

        private void actionExportFilesToXML_Click(object sender, EventArgs e)
        {
            CSVtoXMLConverter xmlConverterModule = new CSVtoXMLConverter();
            XElement xmlOutputFile;

            int counter = 0;
            if (listOfSelectedFileAddresses != null && selectedFolder != null)
            {
                foreach (var fileAddress in listOfSelectedFileAddresses)
                {
                    counter++;
                    string fileName = Path.GetFileName(fileAddress);
                    string oldFileName = Path.GetFileNameWithoutExtension(fileAddress);
                    string newFileName = oldFileName + ".xml";
                    outputProgress.Text = counter + "/" + listOfSelectedFileAddresses.Count();
                    try
                    {
                        xmlOutputFile = xmlConverterModule.ConvertCSVtoXML(fileAddress);
                        xmlOutputFile.Save(@selectedFolder + "\\" + newFileName);
                    }
                    catch
                    {
                        MessageBox.Show("Unfortunately file: "+ fileName + " contains illegal delimiter!  Comma is a default delimiter for csv files but in this case it is possibly also used as a separator of thousands.\n Please edit your CSV file.");
                        listOfFailedConversions.Add(fileName);
                    }

                }
                outputProgress.Text = "Finished";
            }
            else
            {
                MessageBox.Show("Pick some files and export destination first!");
            }

            if (listOfFailedConversions.Count != 0)
            {
                outputFailedTag.Visible = true;
                outputFailed.DataSource = listOfFailedConversions;
                outputFailed.Visible = true;
            }
        }

        private void actionSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogModule.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialogModule.SelectedPath;
                outputExportFolder.Text = selectedFolder;
            }

        }
    }
}
