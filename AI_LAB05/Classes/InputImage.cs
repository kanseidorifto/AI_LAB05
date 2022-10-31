using AI_LAB05.Interfaces;

namespace AI_LAB05.Classes
{
    public class InputImage : IInputSignals
    {
        private Bitmap _image;
        int _category_num;
        public InputImage(Bitmap image, int category_num)
        {
            _image = image;
            _category_num = category_num;
        }
        public float[] GetArray()
        {
            float[,] b_map = GetBoolBitmap(_image);
            float[] signals_vector = new float[b_map.Length];
            int index = 0;
            foreach (var b in b_map)
            {
                signals_vector[index] = b;
                index++;
                //var file = File.OpenWrite("array.txt");

            }
            string str = "";
            foreach (var item in b_map)
            {
                str +=item.ToString()+",";
            }
            File.WriteAllText("array.txt", str);
            return signals_vector;
        }
        public int GetCorrectAnswer()
        {
            return _category_num;
        }

        public float GetSignal(int index)
        {
            var temp = _image.GetPixel(((index + 1) % _image.Width) - 1, (int)Math.Floor((double)(index - 1) / _image.Height));
            //var temp = b.GetPixel(x, y);
            if (temp.R < 50)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            //return _signals_vector[index];
        }
        public static float[,] GetBoolBitmap(Bitmap _bitmap)
        {
            Bitmap b = _bitmap;

            float[,] ar = new float[b.Width, b.Height];

            for (int y = 0; y < b.Height; y++)
            {
                for (int x = 0; x < b.Width; x++)
                {
                    var temp = b.GetPixel(y, x);
                    //ar[x, y] = temp.R / 255;
                    if (temp.R < 50)
                    {
                        ar[x, y] = 1;
                    }
                    else
                    {
                        ar[x, y] = 0;
                    }
                }
            }
            return ar;
        }
    }
}
