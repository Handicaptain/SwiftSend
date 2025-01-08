using System;

namespace SwiftSend
{
    partial class emailCommunication
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
            this.lblPg2Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.lblMessageTemplate = new System.Windows.Forms.Label();
            this.btnAttachmetUpload = new System.Windows.Forms.Button();
            this.btnMessageTemplateImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblClasses = new System.Windows.Forms.Label();
            this.clbStudents = new System.Windows.Forms.CheckedListBox();
            this.cblStudentSelectAll = new System.Windows.Forms.CheckBox();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.txtAttachmentsBox = new System.Windows.Forms.TextBox();
            this.cblClassesSelectAll = new System.Windows.Forms.CheckBox();
            this.cblClasses = new System.Windows.Forms.CheckedListBox();
            this.lblCblStudents = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSearchClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPg2Email
            // 
            this.lblPg2Email.AutoSize = true;
            this.lblPg2Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPg2Email.Location = new System.Drawing.Point(47, 22);
            this.lblPg2Email.Name = "lblPg2Email";
            this.lblPg2Email.Size = new System.Drawing.Size(62, 24);
            this.lblPg2Email.TabIndex = 0;
            this.lblPg2Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complete the email or import an email template";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(78, 141);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(73, 24);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(51, 179);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.Size = new System.Drawing.Size(399, 43);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // tblMessage
            // 
            this.tblMessage.AutoSize = true;
            this.tblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblMessage.Location = new System.Drawing.Point(78, 248);
            this.tblMessage.Name = "tblMessage";
            this.tblMessage.Size = new System.Drawing.Size(87, 24);
            this.tblMessage.TabIndex = 4;
            this.tblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(51, 288);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(399, 216);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(456, 291);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(125, 24);
            this.lblAttachment.TabIndex = 6;
            this.lblAttachment.Text = "Attachment(s)";
            // 
            // lblMessageTemplate
            // 
            this.lblMessageTemplate.AutoSize = true;
            this.lblMessageTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTemplate.Location = new System.Drawing.Point(47, 516);
            this.lblMessageTemplate.Name = "lblMessageTemplate";
            this.lblMessageTemplate.Size = new System.Drawing.Size(171, 24);
            this.lblMessageTemplate.TabIndex = 7;
            this.lblMessageTemplate.Text = "Message Template";
            // 
            // btnAttachmetUpload
            // 
            this.btnAttachmetUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachmetUpload.Location = new System.Drawing.Point(587, 285);
            this.btnAttachmetUpload.Name = "btnAttachmetUpload";
            this.btnAttachmetUpload.Size = new System.Drawing.Size(80, 39);
            this.btnAttachmetUpload.TabIndex = 8;
            this.btnAttachmetUpload.Text = "Upload";
            this.btnAttachmetUpload.UseVisualStyleBackColor = true;
            this.btnAttachmetUpload.Click += new System.EventHandler(this.btnAttachmetUpload_Click);
            // 
            // btnMessageTemplateImport
            // 
            this.btnMessageTemplateImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageTemplateImport.Location = new System.Drawing.Point(234, 514);
            this.btnMessageTemplateImport.Name = "btnMessageTemplateImport";
            this.btnMessageTemplateImport.Size = new System.Drawing.Size(80, 39);
            this.btnMessageTemplateImport.TabIndex = 9;
            this.btnMessageTemplateImport.Text = "Import";
            this.btnMessageTemplateImport.UseVisualStyleBackColor = true;
            this.btnMessageTemplateImport.Click += new System.EventHandler(this.btnMessageTemplateImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(767, 14);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(96, 25);
            this.lblClasses.TabIndex = 12;
            this.lblClasses.Text = "Classes";
            // 
            // clbStudents
            // 
            this.clbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbStudents.FormattingEnabled = true;
            this.clbStudents.Location = new System.Drawing.Point(772, 367);
            this.clbStudents.Name = "clbStudents";
            this.clbStudents.Size = new System.Drawing.Size(294, 186);
            this.clbStudents.TabIndex = 14;
            this.clbStudents.SelectedIndexChanged += new System.EventHandler(this.clbStudents_SelectedIndexChanged);
            // 
            // cblStudentSelectAll
            // 
            this.cblStudentSelectAll.AutoSize = true;
            this.cblStudentSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblStudentSelectAll.Location = new System.Drawing.Point(772, 332);
            this.cblStudentSelectAll.Name = "cblStudentSelectAll";
            this.cblStudentSelectAll.Size = new System.Drawing.Size(121, 29);
            this.cblStudentSelectAll.TabIndex = 15;
            this.cblStudentSelectAll.Text = "Select All";
            this.cblStudentSelectAll.UseVisualStyleBackColor = true;
            this.cblStudentSelectAll.CheckedChanged += new System.EventHandler(this.cblStudentSelectAll_CheckedChanged);
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.LightGray;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(12, 575);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(65, 22);
            this.btnBack1.TabIndex = 16;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // txtAttachmentsBox
            // 
            this.txtAttachmentsBox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAttachmentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttachmentsBox.Location = new System.Drawing.Point(460, 330);
            this.txtAttachmentsBox.Multiline = true;
            this.txtAttachmentsBox.Name = "txtAttachmentsBox";
            this.txtAttachmentsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttachmentsBox.Size = new System.Drawing.Size(207, 174);
            this.txtAttachmentsBox.TabIndex = 17;
            this.txtAttachmentsBox.TextChanged += new System.EventHandler(this.txtAttachmentsBox_TextChanged);
            // 
            // cblClassesSelectAll
            // 
            this.cblClassesSelectAll.AutoSize = true;
            this.cblClassesSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblClassesSelectAll.Location = new System.Drawing.Point(772, 42);
            this.cblClassesSelectAll.Name = "cblClassesSelectAll";
            this.cblClassesSelectAll.Size = new System.Drawing.Size(121, 29);
            this.cblClassesSelectAll.TabIndex = 19;
            this.cblClassesSelectAll.Text = "Select All";
            this.cblClassesSelectAll.UseVisualStyleBackColor = true;
            this.cblClassesSelectAll.CheckedChanged += new System.EventHandler(this.cblClassesSelectAll_CheckedChanged);
            // 
            // cblClasses
            // 
            this.cblClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblClasses.FormattingEnabled = true;
            this.cblClasses.Location = new System.Drawing.Point(772, 77);
            this.cblClasses.Name = "cblClasses";
            this.cblClasses.Size = new System.Drawing.Size(274, 186);
            this.cblClasses.TabIndex = 18;
            // 
            // lblCblStudents
            // 
            this.lblCblStudents.AutoSize = true;
            this.lblCblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCblStudents.Location = new System.Drawing.Point(767, 304);
            this.lblCblStudents.Name = "lblCblStudents";
            this.lblCblStudents.Size = new System.Drawing.Size(105, 25);
            this.lblCblStudents.TabIndex = 20;
            this.lblCblStudents.Text = "Students";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGray;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1024, 575);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 22);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSearchClasses
            // 
            this.btnSearchClasses.BackColor = System.Drawing.Color.LightGray;
            this.btnSearchClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClasses.Location = new System.Drawing.Point(841, 269);
            this.btnSearchClasses.Name = "btnSearchClasses";
            this.btnSearchClasses.Size = new System.Drawing.Size(121, 22);
            this.btnSearchClasses.TabIndex = 22;
            this.btnSearchClasses.Text = "Search for students";
            this.btnSearchClasses.UseVisualStyleBackColor = false;
            this.btnSearchClasses.Click += new System.EventHandler(this.btnSearchClasses_Click);
            // 
            // emailCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 609);
            this.Controls.Add(this.btnSearchClasses);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCblStudents);
            this.Controls.Add(this.cblClassesSelectAll);
            this.Controls.Add(this.cblClasses);
            this.Controls.Add(this.txtAttachmentsBox);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.cblStudentSelectAll);
            this.Controls.Add(this.clbStudents);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.btnMessageTemplateImport);
            this.Controls.Add(this.btnAttachmetUpload);
            this.Controls.Add(this.lblMessageTemplate);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.tblMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPg2Email);
            this.Name = "emailCommunication";
            this.Text = "emailCommunication";
            this.Load += new System.EventHandler(this.emailCommunication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblPg2Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label tblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Label lblMessageTemplate;
        private System.Windows.Forms.Button btnAttachmetUpload;
        private System.Windows.Forms.Button btnMessageTemplateImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.CheckedListBox clbStudents;
        private System.Windows.Forms.CheckBox cblStudentSelectAll;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.TextBox txtAttachmentsBox;
        private System.Windows.Forms.CheckBox cblClassesSelectAll;
        private System.Windows.Forms.CheckedListBox cblClasses;
        private System.Windows.Forms.Label lblCblStudents;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSearchClasses;
    }
}