namespace Day8_C__Advanced_Drag_Drop
{
    public partial class Form1 : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int X = firstPoint.X - e.Location.X;
                int Y = firstPoint.Y - e.Location.Y;

                int x = this.panel1.Location.X - X;
                int y = this.panel1.Location.Y - Y;
                this.panel1.Location = new Point(x, y);
            }
        }
    }
}