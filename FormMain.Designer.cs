namespace WinHash
{
    partial class FormMain
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
            this.btSelectFile = new System.Windows.Forms.Button();
            this.lFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSelectFile
            // 
            this.btSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(105, 23);
            this.btSelectFile.TabIndex = 0;
            this.btSelectFile.Text = "Выбрать файл";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click);
            // 
            // lFile
            // 
            this.lFile.AutoSize = true;
            this.lFile.Location = new System.Drawing.Point(123, 17);
            this.lFile.Name = "lFile";
            this.lFile.Size = new System.Drawing.Size(16, 13);
            this.lFile.TabIndex = 2;
            this.lFile.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Хэш";
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(46, 51);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(300, 20);
            this.tbHash.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 75);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lFile);
            this.Controls.Add(this.btSelectFile);
            this.Name = "Form1";
            this.Text = "Расчёт SHA-1 для файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelectFile;
        private System.Windows.Forms.Label lFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHash;
    }
}

