namespace ExcelDiff.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFile2 = new System.Windows.Forms.Button();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.btnSelectFile1 = new System.Windows.Forms.Button();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.cmdCompare = new System.Windows.Forms.Button();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.folderB = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectFile2);
            this.groupBox1.Controls.Add(this.txtFile2);
            this.groupBox1.Controls.Add(this.btnSelectFile1);
            this.groupBox1.Controls.Add(this.txtFile1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel Files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Excel File #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Excel File #1";
            // 
            // selectFile2
            // 
            this.selectFile2.Location = new System.Drawing.Point(467, 57);
            this.selectFile2.Name = "selectFile2";
            this.selectFile2.Size = new System.Drawing.Size(97, 20);
            this.selectFile2.TabIndex = 3;
            this.selectFile2.Text = "Select";
            this.selectFile2.UseVisualStyleBackColor = true;
            this.selectFile2.Click += new System.EventHandler(this.selectFile2_Click);
            // 
            // txtFile2
            // 
            this.txtFile2.Location = new System.Drawing.Point(80, 57);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.ReadOnly = true;
            this.txtFile2.Size = new System.Drawing.Size(381, 20);
            this.txtFile2.TabIndex = 2;
            // 
            // btnSelectFile1
            // 
            this.btnSelectFile1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectFile1.Location = new System.Drawing.Point(467, 20);
            this.btnSelectFile1.Name = "btnSelectFile1";
            this.btnSelectFile1.Size = new System.Drawing.Size(97, 20);
            this.btnSelectFile1.TabIndex = 1;
            this.btnSelectFile1.Text = "Select";
            this.btnSelectFile1.UseVisualStyleBackColor = true;
            this.btnSelectFile1.Click += new System.EventHandler(this.btnSelectFile1_Click);
            // 
            // txtFile1
            // 
            this.txtFile1.Location = new System.Drawing.Point(80, 20);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.ReadOnly = true;
            this.txtFile1.Size = new System.Drawing.Size(381, 20);
            this.txtFile1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstResult);
            this.groupBox2.Controls.Add(this.cmdCompare);
            this.groupBox2.Controls.Add(this.cmdGenerate);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(7, 20);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(557, 290);
            this.lstResult.TabIndex = 3;
            // 
            // cmdCompare
            // 
            this.cmdCompare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCompare.Location = new System.Drawing.Point(355, 315);
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Size = new System.Drawing.Size(209, 29);
            this.cmdCompare.TabIndex = 2;
            this.cmdCompare.Text = "&Compare Difference";
            this.cmdCompare.UseVisualStyleBackColor = true;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdGenerate.Location = new System.Drawing.Point(6, 315);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(209, 29);
            this.cmdGenerate.TabIndex = 1;
            this.cmdGenerate.Text = "&Generate Result";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // opFile
            // 
            this.opFile.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Diff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectFile2;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.Button btnSelectFile1;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.Button cmdCompare;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.FolderBrowserDialog folderB;
    }
}