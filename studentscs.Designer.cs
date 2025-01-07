using System;

namespace SwiftSend
{
    partial class studentscs
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblClass2 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblViewStudents = new System.Windows.Forms.Label();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(67, 28);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(105, 25);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students";
            // 
            // lblClass2
            // 
            this.lblClass2.AutoSize = true;
            this.lblClass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass2.Location = new System.Drawing.Point(69, 131);
            this.lblClass2.Name = "lblClass2";
            this.lblClass2.Size = new System.Drawing.Size(71, 25);
            this.lblClass2.TabIndex = 9;
            this.lblClass2.Text = "Class";
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.Black;
            this.txtClass.Location = new System.Drawing.Point(72, 181);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(189, 31);
            this.txtClass.TabIndex = 0;
            this.txtClass.Text = "Enter class";

            // 
            // lblViewStudents
            // 
            this.lblViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStudents.Location = new System.Drawing.Point(67, 68);
            this.lblViewStudents.Name = "lblViewStudents";
            this.lblViewStudents.Size = new System.Drawing.Size(288, 39);
            this.lblViewStudents.TabIndex = 34;
            this.lblViewStudents.Text = "View students in the class";
            // 
            // btnBack3
            // 
            this.btnBack3.BackColor = System.Drawing.Color.LightGray;
            this.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack3.Location = new System.Drawing.Point(12, 574);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(75, 23);
            this.btnBack3.TabIndex = 36;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.Location = new System.Drawing.Point(1014, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(267, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(72, 246);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(702, 295);
            this.dgvStudents.TabIndex = 39;
            // 
            // studentscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 609);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.lblViewStudents);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass2);
            this.Controls.Add(this.lblStudents);
            this.Name = "studentscs";
            this.Text = "studentscs";
            this.Load += new System.EventHandler(this.studentscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblClass2;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblViewStudents;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}