using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230131
{
    public partial class ImagesUserControl : UserControl
    {
        public ImagesUserControl()
        {
            InitializeComponent();
            this.Load += OnImagesUserControlLoad;
        }

        private void OnImagesUserControlLoad(object? sender, EventArgs e)
        {
            var sadCatImages = new PictureBox[2, 4];
            for (int s = 0; s < sadCatImages.GetLength(0); s++) 
            {
                for (int o = 0; o < sadCatImages.GetLength(1); o++)
                {
                    sadCatImages[s, o] = new()
                    {
                        Image = Properties.Resources.sadcat_01,
                        Bounds = new()
                        {
                            Width = 200,
                            Height = 200,
                            X = o * 200,
                            Y = s * 200,
                        },
                        SizeMode = PictureBoxSizeMode.Zoom,
                    };
                    this.Controls.Add(sadCatImages[s, o]);
                }
            }
        }
    }
}
