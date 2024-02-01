namespace Clock
{
    partial class Form1
    {
        private ClockControl clockControl1; // Add this line

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            clockControl1 = new ClockControl();
            SuspendLayout();
            // 
            // clockControl1
            // 
            clockControl1.Location = new Point(50, 50);
            clockControl1.Name = "clockControl1";
            clockControl1.Size = new Size(230, 110);
            clockControl1.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(350, 250);
            Controls.Add(clockControl1);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion
    }
}
