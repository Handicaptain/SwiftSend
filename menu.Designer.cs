namespace SwiftSend
{
    partial class menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEmailCommunication = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(507, 52);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 31);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddTemplate);
            this.panel1.Controls.Add(this.btnViewStudents);
            this.panel1.Controls.Add(this.btnAddClass);
            this.panel1.Controls.Add(this.btnEmailCommunication);
            this.panel1.Location = new System.Drawing.Point(318, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 387);
            this.panel1.TabIndex = 1;
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAddTemplate.Location = new System.Drawing.Point(85, 283);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(321, 47);
            this.btnAddTemplate.TabIndex = 4;
            this.btnAddTemplate.Text = "Add email template";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnViewStudents.Location = new System.Drawing.Point(85, 201);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(321, 47);
            this.btnViewStudents.TabIndex = 2;
            this.btnViewStudents.Text = "View students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAddClass.Location = new System.Drawing.Point(85, 121);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(321, 47);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "Add a class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEmailCommunication
            // 
            this.btnEmailCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnEmailCommunication.Location = new System.Drawing.Point(85, 43);
            this.btnEmailCommunication.Name = "btnEmailCommunication";
            this.btnEmailCommunication.Size = new System.Drawing.Size(321, 47);
            this.btnEmailCommunication.TabIndex = 0;
            this.btnEmailCommunication.Text = "Email communication";
            this.btnEmailCommunication.UseVisualStyleBackColor = true;
            this.btnEmailCommunication.Click += new System.EventHandler(this.btnEmailCommunication_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMenu);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmailCommunication;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnAddTemplate;
    }
}

