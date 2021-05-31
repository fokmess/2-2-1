
namespace _2_2_1
{
    partial class Form1
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
            this.fileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileText = new System.Windows.Forms.TextBox();
            this.fileText2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileName.Location = new System.Drawing.Point(343, 70);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(340, 51);
            this.fileName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(754, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileText
            // 
            this.fileText.Enabled = false;
            this.fileText.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fileText.Location = new System.Drawing.Point(30, 183);
            this.fileText.Multiline = true;
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(516, 590);
            this.fileText.TabIndex = 3;
            // 
            // fileText2
            // 
            this.fileText2.Enabled = false;
            this.fileText2.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fileText2.Location = new System.Drawing.Point(632, 183);
            this.fileText2.Multiline = true;
            this.fileText2.Name = "fileText2";
            this.fileText2.Size = new System.Drawing.Size(516, 590);
            this.fileText2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 956);
            this.Controls.Add(this.fileText2);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.TextBox fileText2;
    }
}

