using AI_LAB05.Classes;
using System.Drawing.Drawing2D;

namespace AI_LAB05.Forms
{
    public partial class ViewBatch : Form
    {
        public ViewBatch()
        {
            InitializeComponent();

        }
        private ImageList myImageList;
        public void LoadBatch(InputArray[] inputArrays, int X, int Y)
        {
            myImageList = new ImageList();
            myImageList.ImageSize = new Size(64, 64);
            int count = 0;
            listView1.Items.Clear();
            for (int i = 0; i < inputArrays.Length; i++)
            {
                Bitmap bitmap = new Bitmap(X, Y);
                var temp_arr = inputArrays[i].GetArray();
                if ((X * Y) == temp_arr.Length)
                {
                    for (int j = 0; j < temp_arr.Length; j++)
                    {
                        if (temp_arr[j] == 1)
                        {
                            bitmap.SetPixel((j % X), (int)Math.Floor((double)(j) / Y), Color.Black);
                        }
                        else
                        {
                            bitmap.SetPixel((j % X), (int)Math.Floor((double)(j) / Y), Color.White);
                        }
                    }
                }
                else
                {
                    bitmap = SystemIcons.Hand.ToBitmap();
                }
                myImageList.Images.Add(Program.ResizeImage(bitmap,64,64,InterpolationMode.NearestNeighbor));
                listView1.Items.Add(new ListViewItem { ImageIndex = count, Text = inputArrays[i]._category_num.ToString() +" : " + inputArrays[i]._category_name });
                count++;
            }

            listView1.LargeImageList = myImageList;
        }

        private void заПорядкомДоданняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.None;
            //заПорядкомДоданняToolStripMenuItem.Checked = true;
            //заЗростаннямToolStripMenuItem.Checked = false;
        }

        private void заЗростаннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
            заЗростаннямToolStripMenuItem.Checked = true;
            заПорядкомДоданняToolStripMenuItem.Checked = false;
        }
    }
}
