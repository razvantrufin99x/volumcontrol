﻿namespace volumcontrol
{
    partial class dragablebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // dragablebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "dragablebar";
            this.Size = new System.Drawing.Size(3, 15);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragablebar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragablebar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragablebar_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
