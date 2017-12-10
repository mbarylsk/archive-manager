using System;
using System.Drawing;
using System.Windows.Forms;

public enum ProgressBarDisplayText
{
    Percentage,
    CustomText
}

class CustomProgressBar : ProgressBar
{
    // print % or text
    public ProgressBarDisplayText MyStyle { get; set; }
    // text to be printed
    public String MyText { get; set; }

    public void GraphicsProgressBar()
    {       
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
        string text = MyStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : MyText;

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