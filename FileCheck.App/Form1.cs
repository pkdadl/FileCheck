using System;
using System.Windows.Forms;
using FileCheck.Validate;

namespace FileCheck.App
{
    public partial class frmFileCheck : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public frmFileCheck()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtFilePath.Text = openFileDialog.FileName;
                }

            }
        }

        private void btnXSDFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xsd files (*.xsd)|*.xsd";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtXSDFile.Text = openFileDialog.FileName;
                }

            }
        }

        private void btnSchemaValidate_Click(object sender, EventArgs e)
        {
            Guid foldrGUID = Guid.NewGuid();
            System.Diagnostics.Process p = System.Diagnostics.Process.GetCurrentProcess();
            string pid = p.Id.ToString();
            string extractFolderName = pid + "-" + foldrGUID.ToString();
            string xmlFilePath = @".\" + extractFolderName + @"\party.xml";

            XMLFileValidate xMLFileValidate = new XMLFileValidate();

            /**********   Check Zip folder has only valid extensions  *******/
            string result = xMLFileValidate.CheckValidExtension(txtFilePath.Text);
            if (result == "Success")
            {
                txtResult.Text = "Valid extensions result -   Passed";
                /**********    Extract Zip file   ***********/
                string extractionResult = xMLFileValidate.ExtractZipFile(txtFilePath.Text, extractFolderName);
                if (extractionResult == "Zip file extraction Success")
                {
                    txtResult.Text = txtResult.Text + Environment.NewLine + "Zip file extraction result   -  Passed";

                    /**********   Check for XML schema validity   **********/
                    string schemaResult = xMLFileValidate.CheckSchema(xmlFilePath, txtXSDFile.Text);
                    if (schemaResult == "Success")
                    {
                        txtResult.Text = txtResult.Text + Environment.NewLine + "Schema Validation result   -  Passed";
                        btnSendEmail.Enabled = true;
                    }
                    else
                    {
                        txtResult.Text = txtResult.Text + Environment.NewLine + "Schema Validation result - Failed";
                    }
                }
                else
                {
                    txtResult.Text = txtResult.Text + Environment.NewLine + "Zip file extraction result - Failed";
                }

            }
            else
            {
                txtResult.Text = "Valid extensions result - Failed";
            }

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            XMLFileValidate xMLFileValidate = new XMLFileValidate();
            string result = xMLFileValidate.SendEmail(txtFilePath.Text);
            if (result == "Success")
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + "Send Email   -    Passed";
            }
            else
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + "Send Email   -    Failed";
            }

        }

        
    }
}
