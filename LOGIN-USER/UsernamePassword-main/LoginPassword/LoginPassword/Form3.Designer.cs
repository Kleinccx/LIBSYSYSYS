﻿namespace LoginPassword
{
    partial class Userform
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
            this.DisplayData = new System.Windows.Forms.DataGridView();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayData)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayData
            // 
            this.DisplayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayData.Location = new System.Drawing.Point(153, 58);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.Size = new System.Drawing.Size(239, 150);
            this.DisplayData.TabIndex = 0;
            this.DisplayData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(398, 105);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 21);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(398, 58);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(71, 29);
            this.Delbtn.TabIndex = 2;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.Location = new System.Drawing.Point(153, 205);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(239, 45);
            this.Viewbtn.TabIndex = 4;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "USER";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(492, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(398, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 252);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.DisplayData);
            this.Name = "Userform";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DisplayData;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button btnEdit;
    }
}