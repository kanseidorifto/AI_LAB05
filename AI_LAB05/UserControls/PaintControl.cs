namespace AI_LAB05
{
    public partial class PaintControl : PictureBox
    {
        public PaintControl()
        {
            InitializeComponent();
            arrayPoints = new ArrayPoints(2);
            
            //SetSize();
        }
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;
            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }

        private bool isMouse;
        private ArrayPoints arrayPoints;
        
        Bitmap bitmap;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 30f);

        public void Reset()
        {
            graphics.Clear(Color.White);
            Image = bitmap;
        }
        public Bitmap GetBitmap(Size size)
        {
            return new Bitmap(bitmap, size);
        }
        public Bitmap GetBitmap()
        {
            return new Bitmap(bitmap);
        }
        public void SetPenWidth(float width)
        {
            pen.Width = width;
        }
        public void SetSize()
        {
            bitmap = new Bitmap(Size.Width, Size.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void PaintControl_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void PaintControl_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();

        }

        private void PaintControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }

            arrayPoints.SetPoint(e.X, e.Y);
            if(arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                this.Image = bitmap;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
    }
}
