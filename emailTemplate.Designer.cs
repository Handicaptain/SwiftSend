namespace SwiftSend
{
    partial class emailTemplate
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
            this.lblEmailTemplate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailTemplateName = new System.Windows.Forms.TextBox();
            this.lblEmailTemplateMessage = new System.Windows.Forms.Label();
            this.txtEmailTemplateMessage = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmailTemplate
            // 
            this.lblEmailTemplate.AutoSize = true;
            this.lblEmailTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTemplate.Location = new System.Drawing.Point(82, 23);
            this.lblEmailTemplate.Name = "lblEmailTemplate";
            this.lblEmailTemplate.Size = new System.Drawing.Size(174, 25);
            this.lblEmailTemplate.TabIndex = 0;
            this.lblEmailTemplate.Text = "Email Template";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Template Name";
            // 
            // txtEmailTemplateName
            // 
            this.txtEmailTemplateName.Location = new System.Drawing.Point(91, 117);
            this.txtEmailTemplateName.Multiline = true;
            this.txtEmailTemplateName.Name = "txtEmailTemplateName";
            this.txtEmailTemplateName.Size = new System.Drawing.Size(461, 49);
            this.txtEmailTemplateName.TabIndex = 2;
            this.txtEmailTemplateName.TextChanged += new System.EventHandler(this.txtEmailTemplateName_TextChanged);
            // 
            // lblEmailTemplateMessage
            // 
            this.lblEmailTemplateMessage.AutoSize = true;
            this.lblEmailTemplateMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTemplateMessage.Location = new System.Drawing.Point(87, 195);
            this.lblEmailTemplateMessage.Name = "lblEmailTemplateMessage";
            this.lblEmailTemplateMessage.Size = new System.Drawing.Size(223, 24);
            this.lblEmailTemplateMessage.TabIndex = 3;
            this.lblEmailTemplateMessage.Text = "Email Template Message";
            // 
            // txtEmailTemplateMessage
            // 
            this.txtEmailTemplateMessage.Location = new System.Drawing.Point(91, 242);
            this.txtEmailTemplateMessage.Multiline = true;
            this.txtEmailTemplateMessage.Name = "txtEmailTemplateMessage";
            this.txtEmailTemplateMessage.Size = new System.Drawing.Size(682, 256);
            this.txtEmailTemplateMessage.TabIndex = 4;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(91, 527);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(49, 26);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Path";
            this.lblPath.Click += new System.EventHandler(this.lblPath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(146, 521);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(423, 37);
            this.txtFilePath.TabIndex = 6;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFiles.Location = new System.Drawing.Point(575, 519);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(70, 41);
            this.btnBrowseFiles.TabIndex = 7;
            this.btnBrowseFiles.Text = "...";
            this.btnBrowseFiles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTemplate.Location = new System.Drawing.Point(651, 517);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(188, 42);
            this.btnSaveTemplate.TabIndex = 11;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnBack4
            // 
            this.btnBack4.BackColor = System.Drawing.Color.LightGray;
            this.btnBack4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack4.Location = new System.Drawing.Point(12, 574);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(75, 23);
            this.btnBack4.TabIndex = 12;
            this.btnBack4.Text = "Back";
            this.btnBack4.UseVisualStyleBackColor = false;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // emailTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 609);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtEmailTemplateMessage);
            this.Controls.Add(this.lblEmailTemplateMessage);
            this.Controls.Add(this.txtEmailTemplateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmailTemplate);
            this.Name = "emailTemplate";
            this.Text = "emailTemplate";
            this.Load += new System.EventHandler(this.emailTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailTemplateName;
        private System.Windows.Forms.Label lblEmailTemplateMessage;
        private System.Windows.Forms.TextBox txtEmailTemplateMessage;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnBack4;
    }
}