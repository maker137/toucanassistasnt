namespace Toucan_Assistant
{
    partial class ClockWidget
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
            this.clockControl1 = new Toucan_Assistant.ClockControl();
            this.SuspendLayout();
            // 
            // clockControl1
            // 
            this.clockControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clockControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clockControl1.Location = new System.Drawing.Point(1, 0);
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.Size = new System.Drawing.Size(226, 63);
            this.clockControl1.TabIndex = 0;
            // 
            // ClockWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 66);
            this.Controls.Add(this.clockControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClockWidget";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private ClockControl clockControl1;
    }
}