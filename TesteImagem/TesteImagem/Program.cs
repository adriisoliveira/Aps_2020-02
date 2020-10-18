using System;
using System.Collections.Generic;
using System.Windows.Forms.Control;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Drawing.Bitmap;
using System.Drawing.Graphics;


namespace TesteImagem
{
    class Program
    {
        public System.Drawing.Drawing2D.SmoothingMode SmoothingMode { get; set; }
        public sealed class Bitmap
        {
            private int width;
            private int height;

            public Bitmap(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        public sealed class Graphics
        {
            public object InterpolationMode { get; internal set; }

            internal Graphics FromImage(Bitmap reducedImage)
            {
                throw new NotImplementedException();
            }
        }

        public static System.Drawing.Graphics FromImage(System.Drawing.Image image);

        static Bitmap reduceImage (Bitmap image, int width, int height)
        {
            Bitmap reducedImage = new Bitmap(width, height);
            Graphics graphics = graphics.FromImage(reducedImage);

            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(image, 0, 0, width, height);
            graphics.Dispose();

            return reducedImage;
        }

        static List<bool> generateHash (Bitmap image)
        {
            List<bool> hash = new List<bool>();

            for (int y = 0; y <image.Height; y++)
            {
                for (int x = 0; x<image.Width; x++)
                {
                    hash.Add(image.GetPixel(x, y).GetBrightness() < 0.5f);
                }
            }

            return hash;
        }
        public static Bitmap GrayScale (Bitmap Bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y< Bmp.Height; y++)
            {
                for(int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }
            return Bmp;
        }

        static int equalPixels(List<bool> pixel0, List<bool> pixel1)
        {
            int equalPixelsAmount = 0;
            int pixelsToCompare = (pixel0.Count + pixel1.Count) / 2;

            for (int i = 0; i < pixelsToCompare; i++)
            {
                if (pixel0[i] == pixel1[i])
                {
                    equalPixelsAmount++;
                }
            }

            return equalPixelsAmount;
        }

        static void Main(string [] args)
        {
            while (true)
            {
                Console.WriteLine("Insira um comando:");
                Console.WriteLine("- comparar imagens");
                Console.WriteLine("");
                string command = Console.ReadLine();


                if (command == "comparar imagens")
                {
                    Console.WriteLine("Insira o endereço da imagem 0");
                    string image0Path = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Insira o endereço da imagem 1");
                    string image1Path = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Convertendo imagens para bitmap");
                    Bitmap image0Bitmap = new Bitmap(image0Path);
                    Bitmap image1Bitmap = new Bitmap(image1Path);
                    Console.WriteLine();

                    Console.WriteLine("Reduzindo imagens para 256x256");
                    Bitmap image0BitmapReduced = reduceImage(image0Bitmap, 1000, 1000);
                    Bitmap image1BitmapReduced = reduceImage(image1Bitmap, 1000, 1000);
                    Console.WriteLine();

                    Console.WriteLine("Concertendo a imagem para preto e branco");
                    Bitmap image0BitmapBlackAndWhite = GrayScale(image0BitmapReduced);
                    Bitmap image1BitmapBlackAndWhite = GrayScale(image1BitmapReduced);
                    Console.WriteLine();

                    Console.WriteLine("Gerando hash das imagens");
                    List<bool> image0Hash = generateHash(image0BitmapBlackAndWhite);
                    List<bool> image1Hash = generateHash(image1BitmapBlackAndWhite);
                    Console.WriteLine();

                    Console.WriteLine("Calculando a quantidade de pixels iguais");
                    int pixelsIguais = equalPixels(image0Hash, image1Hash);
                    Console.WriteLine("");

                    Console.WriteLine("Calculando porcentagem de acertos");
                    float area = image0BitmapReduced.Width * image1BitmapReduced.Height;
                    float _decimal = pixelsIguais / area;
                    float hitPercent = _decimal * 100;
                    Console.WriteLine("");

                    if (hitPercent >= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Essas duas imagens são iguais");
                        Console.WriteLine("Porcentagem de acerto:" + hitPercent);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Essas duas imagens são diferentes");
                        Console.WriteLine("Porcentagem de acerto: " + hitPercent);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }
    }
}
