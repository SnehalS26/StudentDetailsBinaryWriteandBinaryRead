namespace StudentDetailsBWandBR
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.textRollnum = new System.Windows.Forms.TextBox();
            this.textPerce = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parcentage";
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(460, 159);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(114, 35);
            this.btnCreateFolder.TabIndex = 3;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // textRollnum
            // 
            this.textRollnum.Location = new System.Drawing.Point(197, 129);
            this.textRollnum.Name = "textRollnum";
            this.textRollnum.Size = new System.Drawing.Size(144, 22);
            this.textRollnum.TabIndex = 5;
            // 
            // textPerce
            // 
            this.textPerce.Location = new System.Drawing.Point(197, 274);
            this.textPerce.Name = "textPerce";
            this.textPerce.Size = new System.Drawing.Size(144, 22);
            this.textPerce.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(197, 201);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(144, 22);
            this.textName.TabIndex = 7;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(460, 241);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(114, 38);
            this.btnCreateFile.TabIndex = 8;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(630, 241);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(111, 38);
            this.btnBinaryRead.TabIndex = 9;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(630, 159);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(111, 35);
            this.btnBinaryWrite.TabIndex = 10;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPerce);
            this.Controls.Add(this.textRollnum);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.TextBox textRollnum;
        private System.Windows.Forms.TextBox textPerce;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
    }
}

