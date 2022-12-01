namespace volumcontrol
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pixelcontrol2 = new volumcontrol.pixelcontrol();
            this.pixelcontrol1 = new volumcontrol.pixelcontrol();
            this.dragablebar1 = new volumcontrol.dragablebar();
            this.pixelcontrol3 = new volumcontrol.pixelcontrol();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pixelcontrol2
            // 
            this.pixelcontrol2.BackColor = System.Drawing.Color.Red;
            this.pixelcontrol2.Location = new System.Drawing.Point(112, 9);
            this.pixelcontrol2.Margin = new System.Windows.Forms.Padding(0);
            this.pixelcontrol2.Name = "pixelcontrol2";
            this.pixelcontrol2.Size = new System.Drawing.Size(5, 5);
            this.pixelcontrol2.TabIndex = 2;
            this.pixelcontrol2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pixelcontrol2_MouseClick);
            // 
            // pixelcontrol1
            // 
            this.pixelcontrol1.BackColor = System.Drawing.Color.Red;
            this.pixelcontrol1.Location = new System.Drawing.Point(17, 35);
            this.pixelcontrol1.Margin = new System.Windows.Forms.Padding(0);
            this.pixelcontrol1.Name = "pixelcontrol1";
            this.pixelcontrol1.Size = new System.Drawing.Size(100, 1);
            this.pixelcontrol1.TabIndex = 1;
            // 
            // dragablebar1
            // 
            this.dragablebar1.BackColor = System.Drawing.Color.Red;
            this.dragablebar1.Location = new System.Drawing.Point(13, 28);
            this.dragablebar1.Margin = new System.Windows.Forms.Padding(0);
            this.dragablebar1.Name = "dragablebar1";
            this.dragablebar1.Size = new System.Drawing.Size(3, 15);
            this.dragablebar1.TabIndex = 0;
            // 
            // pixelcontrol3
            // 
            this.pixelcontrol3.BackColor = System.Drawing.Color.Red;
            this.pixelcontrol3.Location = new System.Drawing.Point(13, 9);
            this.pixelcontrol3.Margin = new System.Windows.Forms.Padding(0);
            this.pixelcontrol3.Name = "pixelcontrol3";
            this.pixelcontrol3.Size = new System.Drawing.Size(5, 5);
            this.pixelcontrol3.TabIndex = 3;
            this.pixelcontrol3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pixelcontrol3_MouseDown);
            this.pixelcontrol3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pixelcontrol3_MouseMove);
            this.pixelcontrol3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pixelcontrol3_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 53);
            this.Controls.Add(this.pixelcontrol3);
            this.Controls.Add(this.pixelcontrol2);
            this.Controls.Add(this.pixelcontrol1);
            this.Controls.Add(this.dragablebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dragablebar dragablebar1;
        private System.Windows.Forms.Timer timer1;
        private pixelcontrol pixelcontrol1;
        private pixelcontrol pixelcontrol2;
        private pixelcontrol pixelcontrol3;
    }
}

