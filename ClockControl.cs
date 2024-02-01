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
        this.Controls.Add(label1);
    }

    private void UpdateClock()
    {
        // Update the label with the current time
        label1.Text = DateTime.Now.ToString("HH:mm:ss");

        // If you want to update the time every second, you can use a Timer
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000; // 1 second
        timer.Tick += (sender, e) =>
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        };
        timer.Start();
    }
}
