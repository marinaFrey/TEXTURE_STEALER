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
        private const int CIRCLE_SIZE = 10;

        private Image originalImage;
        private Image newImage;
        private Bitmap textureArea;

        private bool isFill;
        private bool isBrush;
        private bool isSecondPoint;
        private bool hasFillSelection;
        private bool hasBrushSelection;

        Point firstPoint;
        Point secondPoint;
        Point fillPoint;
        
        public Interface()
        {
            InitializeComponent();
            isFill = false;
            isBrush = false;
            isSecondPoint = false;
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
            isBrush = true;
            isFill = false;
            isSecondPoint = false;
            hasBrushSelection = false;
            hasFillSelection = false;
        }

        private void selectTextureFilling(object sender, EventArgs e)
        {
            isFill = true;
            isBrush = false;
            isSecondPoint = false;
            hasFillSelection = false;
            hasBrushSelection = false;
        }

        private void captureTexture(object sender, MouseEventArgs e)
        {
            if (isBrush)
            {
                if (isSecondPoint)
                {
                    //seta bitmap da textura
                    secondPoint.X = e.X;
                    secondPoint.Y = e.Y;
                    Bitmap drawing = new Bitmap(originalImage);
                    Graphics line = Graphics.FromImage(drawing);
                    Pen pen = new Pen(Color.Blue);

                    line.DrawLine(pen, firstPoint, secondPoint);
                    originalImageBox.Image = drawing;
                    isSecondPoint = false;
                    hasBrushSelection = true;
                    hasFillSelection = false;
                }
                else
                {
                    //seta primeiro ponto da textura
                    firstPoint.X = e.X;
                    firstPoint.Y = e.Y;

                    Bitmap drawing = new Bitmap(originalImage);
                    Graphics point = Graphics.FromImage(drawing);
                    Rectangle rec = new Rectangle(firstPoint.X, firstPoint.Y, CIRCLE_SIZE, CIRCLE_SIZE);
                    Pen pen = new Pen(Color.Blue);
                    point.DrawEllipse(pen, rec);
                    originalImageBox.Image = drawing;
                    isSecondPoint = true;
                }

            }
            else
            {
                if (isFill)
                {

                    if (isSecondPoint)
                    {
                        //seta bitmap da textura
                        secondPoint.X = e.X;
                        secondPoint.Y = e.Y;
                        Bitmap drawing = new Bitmap(originalImage);
                        Graphics square = Graphics.FromImage(drawing);
                        Pen pen = new Pen(Color.Blue);

                        int width = Math.Abs(secondPoint.X - firstPoint.X);
                        int height = Math.Abs(secondPoint.Y - firstPoint.Y);

                        Rectangle rec = new Rectangle();
                        rec.Width = width;
                        rec.Height = height;

                        if (firstPoint.Y < secondPoint.Y)
                        {
                            rec.X = firstPoint.X;
                            rec.Y = firstPoint.Y;

                            if (firstPoint.X > secondPoint.X)
                            {
                                rec.X = firstPoint.X - width;
                                rec.Y = firstPoint.Y;
                            }
                            
                        }
                        else
                        {
                            if (secondPoint.Y < firstPoint.Y)
                            {
                                rec.X = secondPoint.X;
                                rec.Y = secondPoint.Y;

                                if(firstPoint.X < secondPoint.X)
                                {
                                    rec.Y = firstPoint.Y - height;
                                    rec.X = firstPoint.X;
                                }
                            }                    
                            
                        }

                        Bitmap originalDraw = new Bitmap(originalImage);
                        square.DrawRectangle(pen,rec);
                        originalImageBox.Image = drawing;
                        System.Drawing.Imaging.PixelFormat format = drawing.PixelFormat;
                        textureArea = originalDraw.Clone(rec, format);
                        textureBox.Image = textureArea;
                        isSecondPoint = false;
                        hasFillSelection = true;
                        hasBrushSelection = false;

                    }
                    else
                    {
                        //seta primeiro ponto da textura
                        firstPoint.X = e.X;
                        firstPoint.Y = e.Y;
                        Bitmap drawing = new Bitmap(originalImage);
                        Graphics point = Graphics.FromImage(drawing);
                        Rectangle rec = new Rectangle(firstPoint.X, firstPoint.Y, 10, 10);
                        Pen pen = new Pen(Color.Blue);
                        point.DrawEllipse(pen, rec);
                        originalImageBox.Image = drawing;
                        isSecondPoint = true;
                    }

                }

            }
        

        }



        private void drawTexture(object sender, MouseEventArgs e)
        {
            if (isBrush)
            {
                if (hasBrushSelection)
                {

                }
            }
            else
            {
                if (isFill)
                {
                    if (hasFillSelection)
                    {
                        //usaremos Graphics.FillRegion, para isso precisamos criar uma Region
                        fillPoint.X = e.X;
                        fillPoint.Y = e.Y;
                        Bitmap drawing = new Bitmap(newImage);
                        Graphics imageGraphics = Graphics.FromImage(drawing);
                        Graphics textureGraphics = Graphics.FromImage(textureArea);



                    }
                }
            }
        }
    }
}
