using System.Drawing.Drawing2D;

namespace WinToastr
{
    public partial class Toast : Form
    {
        private const int borderRadius = 15; // Adjust the radius according to your preference

        public Toast(string message, ToastType type)
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(this.ToastForm_Paint);

            label1.Text = message;

            switch (type)
            {
                case ToastType.Error:
                    pictureBox1.Image = Properties.Resources.error_icon;
                    break;
                case ToastType.Information:
                    pictureBox1.Image = Properties.Resources.information_icon;
                    break;
                case ToastType.Success:
                    pictureBox1.Image = Properties.Resources.success_icon;
                    break;
            }
        }

        private void Toast_Load(object sender, EventArgs e)
        {
            // Set the form to be always on top
            this.TopMost = true;

            // Set the location of the form to be at the bottom-right corner of the screen
            //this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            // Add a fade-in effect
            FadeIn();

            timer.Start();
        }

        private void ToastForm_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath roundedRectangle = RoundedRectangle(this.ClientRectangle, borderRadius);
            this.Region = new Region(roundedRectangle);

            using (Pen pen = new Pen(Color.Gray, 2))
            {
                e.Graphics.DrawPath(pen, roundedRectangle);
            }
        }

        private GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // Top-left corner
            path.AddArc(arc, 180, 90);

            // Top-right corner
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right corner
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left corner
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void FadeIn()
        {
            // Add a simple fade-in effect
            for (double opacity = 0; opacity <= 1; opacity += 0.10)
            {
                this.Opacity = opacity;
                this.Refresh();
                Thread.Sleep(15);
            }
        }

        private void FadeOut()
        {
            // Add a simple fade-out effect
            for (double opacity = 1; opacity >= 0; opacity -= 0.10)
            {
                this.Opacity = opacity;
                this.Refresh();
                Thread.Sleep(15);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Add a fade-out effect before closing
            FadeOut();
            this.Close();
        }
    }

    public enum ToastType
    {
        Success,
        Information,
        Error
    }
}
