using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextureStealer
{
    public partial class Interface : Form
    {
        private const int IMG_W = 500;
        private const int IMG_H = 500;

        private Image originalImage;
        private Image newImage;

        public Interface()
        {
            InitializeComponent();
        }

        private void openImageFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalImageBox.Image = Image.FromFile(dialog.FileName);
                originalImage = Image.FromFile(dialog.FileName);

                originalImageBox.Width = originalImage.Width;
                originalImageBox.Height = originalImage.Height;

                Bitmap drawing = new Bitmap(originalImage.Width, originalImage.Height);
                Graphics graphics = Graphics.FromImage(drawing);
                graphics.Clear(Color.White);
                newImageBox.Image = drawing;
            }
        }

        private void openHelpWindow(object sender, EventArgs e)
        {

        }

        private void selectTextureBrush(object sender, EventArgs e)
        {

        }

        private void selectTextureFilling(object sender, EventArgs e)
        {

        }
    }
}
