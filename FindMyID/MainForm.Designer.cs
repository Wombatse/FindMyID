﻿
namespace FindMyID
{
    partial class MainForm
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnOpenDoc = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.AllowDrop = true;
            this.tbPath.Location = new System.Drawing.Point(12, 12);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(667, 23);
            this.tbPath.TabIndex = 0;
            this.tbPath.Text = "C:\\Users\\devin\\Documents\\TestMail.txt";
            this.tbPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbPath_DragDrop);
            this.tbPath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbPath_DragOver);
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.Location = new System.Drawing.Point(685, 12);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(87, 23);
            this.btnOpenDoc.TabIndex = 1;
            this.btnOpenDoc.Text = "Öffnen...";
            this.btnOpenDoc.UseVisualStyleBackColor = true;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenDoc_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(604, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbRegex
            // 
            this.tbRegex.Location = new System.Drawing.Point(105, 119);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(473, 23);
            this.tbRegex.TabIndex = 3;
            this.tbRegex.Text = "[A-Z]0[1-9]{6}";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbRegex);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpenDoc);
            this.Controls.Add(this.tbPath);
            this.Name = "MainForm";
            this.Text = "FindMyID";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbRegex;
    }
}
