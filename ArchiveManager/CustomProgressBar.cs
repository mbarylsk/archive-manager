using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

public enum ProgressBarDisplayText
{
    Percentage,
    CustomText
}

class CustomProgressBar : ProgressBar
{
    // Property to set to decide whether to print a % or Text
    public ProgressBarDisplayText DisplayStyle { get; set; }

    // Property to hold the custom text
    public String CustomText { get; set; }

    public CustomProgressBar()
    {
        // Modify the ControlStyles flags
        // http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx        
        this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        System.Drawing.Rectangle rect = ClientRectangle;
        Graphics g = e.Graphics;

        ProgressBarRenderer.DrawHorizontalBar(g, rect);
        rect.Inflate(-3, -3);
        if (Value > 0)
        {
            // As we doing this ourselves we need to draw the chunks on the progress bar
            System.Drawing.Rectangle clip = new System.Drawing.Rectangle(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
            ProgressBarRenderer.DrawHorizontalChunks(g, clip);
        }

        // Set the Display text (Either a % amount or our custom text
        string text = DisplayStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : CustomText;

        using (System.Drawing.Font f = new System.Drawing.Font(FontFamily.GenericSerif, 10))
        {
            SizeF len = g.MeasureString(text, f);
            // Calculate the location of the text (the middle of progress bar)
            Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)) + 20, Convert.ToInt32((rect.Height / 2) - (len.Height / 2)) + 3);
            // Draw the custom text
            g.DrawString(text, f, Brushes.Black, location);
        }
    }
}