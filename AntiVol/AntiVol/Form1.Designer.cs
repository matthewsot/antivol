namespace AntiVol
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
            this.mainToggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainToggle
            // 
            this.mainToggle.AutoSize = true;
            this.mainToggle.Checked = true;
            this.mainToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainToggle.Location = new System.Drawing.Point(12, 12);
            this.mainToggle.Name = "mainToggle";
            this.mainToggle.Size = new System.Drawing.Size(130, 17);
            this.mainToggle.TabIndex = 2;
            this.mainToggle.Text = "Hide the volume slider";
            this.mainToggle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 42);
            this.Controls.Add(this.mainToggle);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "AntiVol";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mainToggle;
    }
}

