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
            SuspendLayout();

            // Instantiate your custom ClockControl
            clockControl1 = new ClockControl();

            // Add the ClockControl to the form's controls
            Controls.Add(clockControl1);

            // Other auto-generated code...

            ResumeLayout(false);
        }

        #endregion
    }
}
