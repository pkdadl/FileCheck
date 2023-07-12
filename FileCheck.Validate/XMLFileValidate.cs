
using MailKit.Net.Smtp;
using MimeKit;
using System; //Environment.NewLine
using System.Collections.Generic;
using System.Data;
using System.IO;  //Path
using System.IO.Compression;  //ZipFile
using System.Xml.Linq;
using System.Xml.Schema; //XDocument.Load

namespace FileCheck.Validate
{
    public class XMLFileValidate
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public string CheckSchema(string zipFilePath, string XSDFilePath)
        {
            XmlSchemaSet xmlSchemaSet = new XmlSchemaSet();
            xmlSchemaSet.Add("", XSDFilePath);
            XDocument partyDoc = XDocument.Load(zipFilePath);
            string msg = "";
            bool errors = false;
            partyDoc.Validate(xmlSchemaSet, (o, e) =>
            {
                msg += e.Message + Environment.NewLine;
                errors = true;
            });

            if ( !errors)
            {
                msg = "Success";
            }

            return msg;
        }

        public string CheckValidExtension(string zipFolderLocation)
        {
            string result = "";
            string extension = "";
            string invalidExtension = "";

            var validExtensionLst = new List<string>();
            validExtensionLst.Add(".txt");
            validExtensionLst.Add(".pdf");
            validExtensionLst.Add(".png");
            validExtensionLst.Add(".XML");
            validExtensionLst.Add(".docx");
            validExtensionLst.Add(".doc");
            validExtensionLst.Add(".xlsx");
            validExtensionLst.Add(".msg");

            using var zipFile = ZipFile.OpenRead(zipFolderLocation);

            foreach (var entry in zipFile.Entries)
            {                              
                extension = Path.GetExtension(entry.Name);
                if (!validExtensionLst.Contains(extension))
                {
                    invalidExtension += extension + Environment.NewLine;
                }

            }
            if (invalidExtension == "")
            {
                result = "Success";
            }
            else
            {
                result = invalidExtension;
            }

            return result;
        }

        public string ExtractZipFile(string sourceZipFilePath, string extractFolderName)
        {
            string extractPath = "";
            string result = "";            
            try
            {
                 extractPath = @".\" + extractFolderName;
              
                //public static void ExtractToDirectory (string sourceArchiveFileName, string destinationDirectoryName, bool overwriteFiles); 
                ZipFile.ExtractToDirectory(sourceZipFilePath, extractPath, true);
                result = "Zip file extraction Success";
                logger.Info("{0}", "Zip file extraction Success");


            }
            catch( Exception ex)
            {
                result = ex.Message;
                logger.Error(ex, "Extract Zip file failed");
            }
            return result;


        }

        public string SendEmail(string sourceZipFilePath)
        {
            string result = "";
            MimeMessage message = new MimeMessage();
            // From name and email address
            MailboxAddress fromAddress = new MailboxAddress("Test", "*************");
            message.From.Add(fromAddress);
            //To email address
            message.To.Add(MailboxAddress.Parse("***************"));
            message.Subject = "File Validation Application";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.Attachments.Add(sourceZipFilePath);
            message.Body = bodyBuilder.ToMessageBody();

            //Create a new SMPTP Client
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                //Connect to Gmail SMTP server using port 465 with SSL enabled
                smtpClient.Connect("smtp.gmail.com", 465, true);
                //Gmail account user name and password
                smtpClient.Authenticate("xxxxxxxxxxx", "*****************");
                smtpClient.Send(message);
                result = "Success";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                //In any case, disconnect and dispose SMTP client
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
                
            }
        }

        
    }
}
