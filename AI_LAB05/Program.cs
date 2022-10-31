using AI_LAB05.Classes;
using AI_LAB05.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace AI_LAB05
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            /*
            List<InputArray> input_signals_arr = new List<InputArray>();
            NeuronNetwork neuronNetwork = new NeuronNetwork(2, new int[] { 2 }, 1);

            input_signals_arr.Add(new InputArray(new float[] { 0, 0 }, 0));
            input_signals_arr.Add(new InputArray(new float[] { 0, 1 }, 1));
            input_signals_arr.Add(new InputArray(new float[] { 1, 0 }, 1));
            input_signals_arr.Add(new InputArray(new float[] { 1, 1 }, 0));

            int epochs = neuronNetwork.Learning(input_signals_arr.ToArray(), 500, 0.01f);

            OutputSignals result1 = neuronNetwork.GetAnswer(input_signals_arr[0]);
            OutputSignals result2 = neuronNetwork.GetAnswer(input_signals_arr[1]);
            OutputSignals result3 = neuronNetwork.GetAnswer(input_signals_arr[2]);
            OutputSignals result4 = neuronNetwork.GetAnswer(input_signals_arr[3]);
            */
        }
        public static bool[,] getBoolBitmap(Bitmap _bitmap, uint treshold)
        {
            Bitmap b = _bitmap;

            bool[,] ar = new bool[b.Width, b.Height];

            for (int y = 0; y < b.Height; y++)
            {
                for (int x = 0; x < b.Width; x++)
                {
                    var temp = b.GetPixel(x, y);
                    if (temp.R < treshold)
                    {
                        ar[x, y] = false;
                    }
                    else
                    {
                        ar[x, y] = true;
                    }
                }
            }

            return ar;
        }
        public static Bitmap ResizeImage(Image image, int width, int height , InterpolationMode interpolationMode = InterpolationMode.Low)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.InterpolationMode = interpolationMode;//  .NearestNeighbor;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}