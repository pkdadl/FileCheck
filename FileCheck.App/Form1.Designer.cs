
namespace FileCheck.App
{
    partial class frmFileCheck
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            txtFilePath = new System.Windows.Forms.TextBox();
            btnBrowse = new System.Windows.Forms.Button();
            txtXSDFile = new System.Windows.Forms.TextBox();
            btnXSDFile = new System.Windows.Forms.Button();
            btnSchemaValidate = new System.Windows.Forms.Button();
            txtResult = new System.Windows.Forms.TextBox();
            btnSendEmail = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new System.Drawing.Point(184, 75);
            txtFilePath.Margin = new System.Windows.Forms.Padding(6);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new System.Drawing.Size(680, 39);
            txtFilePath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBrowse.Location = new System.Drawing.Point(878, 75);
            btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(275, 49);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse Zip File";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtXSDFile
            // 
            txtXSDFile.Location = new System.Drawing.Point(184, 139);
            txtXSDFile.Margin = new System.Windows.Forms.Padding(6);
            txtXSDFile.Name = "txtXSDFile";
            txtXSDFile.Size = new System.Drawing.Size(680, 39);
            txtXSDFile.TabIndex = 2;
            // 
            // btnXSDFile
            // 
            btnXSDFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXSDFile.Location = new System.Drawing.Point(878, 139);
            btnXSDFile.Margin = new System.Windows.Forms.Padding(6);
            btnXSDFile.Name = "btnXSDFile";
            btnXSDFile.Size = new System.Drawing.Size(275, 39);
            btnXSDFile.TabIndex = 3;
            btnXSDFile.Text = "Browse XSD File";
            btnXSDFile.UseVisualStyleBackColor = true;
            btnXSDFile.Click += btnXSDFile_Click;
            // 
            // btnSchemaValidate
            // 
            btnSchemaValidate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSchemaValidate.Location = new System.Drawing.Point(203, 189);
            btnSchemaValidate.Margin = new System.Windows.Forms.Padding(6);
            btnSchemaValidate.Name = "btnSchemaValidate";
            btnSchemaValidate.Size = new System.Drawing.Size(434, 71);
            btnSchemaValidate.TabIndex = 4;
            btnSchemaValidate.Text = "Validate Schema";
            btnSchemaValidate.UseVisualStyleBackColor = true;
            btnSchemaValidate.Click += btnSchemaValidate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new System.Drawing.Point(184, 273);
            txtResult.Margin = new System.Windows.Forms.Padding(6);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new System.Drawing.Size(953, 451);
            txtResult.TabIndex = 5;
            // 
            // btnSendEmail
            // 
            btnSendEmail.Enabled = false;
            btnSendEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSendEmail.Location = new System.Drawing.Point(651, 189);
            btnSendEmail.Margin = new System.Windows.Forms.Padding(6);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new System.Drawing.Size(434, 71);
            btnSendEmail.TabIndex = 6;
            btnSendEmail.Text = "Send Email";
            btnSendEmail.UseVisualStyleBackColor = true;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // frmFileCheck
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1188, 748);
            Controls.Add(btnSendEmail);
            Controls.Add(txtResult);
            Controls.Add(btnSchemaValidate);
            Controls.Add(btnXSDFile);
            Controls.Add(txtXSDFile);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "frmFileCheck";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "File Check Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtXSDFile;
        private System.Windows.Forms.Button btnXSDFile;
        private System.Windows.Forms.Button btnSchemaValidate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSendEmail;
    }
}

