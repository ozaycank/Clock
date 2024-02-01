using System;
using System.Windows.Forms;

public class ClockControl : UserControl
{
    private Label label1 = new Label();

    public ClockControl()
    {
        InitializeComponents();
        UpdateClock();
    }

    private void InitializeComponents()
    {
        label1 = new Label();
        label1.Font = new Font("Arial", 24, FontStyle.Bold);
        this.BorderStyle = BorderStyle.FixedSingle; 
        label1.BorderStyle = BorderStyle.None;
        label1.Dock = DockStyle.Fill;
        this.Controls.Add(label1);
    }

    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // ClockControl
        // 
        Name = "ClockControl";
        Size = new Size(700, 700);
        ResumeLayout(false);
    }

    private void UpdateClock()
    {
        // Update the label with the current time
        label1.Text = DateTime.Now.ToString("HH:mm:ss");

        
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000; // 1 second
        timer.Tick += (sender, e) =>
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        };
        timer.Start();
    }
}
