using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class frmScreenSaver : Form
    {
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();

        Random rand = new Random();

        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }
        public frmScreenSaver()
        {
            InitializeComponent();
        }

        private void frmScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void frmScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("MarcoReus");

            foreach (string image in images)
            {
                BGImages.Add(new Bitmap(image));

            }
            for (int i = 0; i < 20; ++i)
            {
                BritPic bp = new BritPic();
                bp.PicNum = i % BGImages.Count;
                bp.X = rand.Next(0, Width);
                bp.Y = rand.Next(0, Height);

                BritPics.Add(bp);


            }
        }
    }
}
