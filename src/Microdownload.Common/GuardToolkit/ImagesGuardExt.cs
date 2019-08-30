using Microsoft.AspNetCore.Http;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace Microdownload.Common.GuardToolkit
{
    public static class ImagesGuardExt
    {
        public static bool IsImageFile(this byte[] photoFile)
        {
            if (photoFile == null || photoFile.Length == 0)
                return false;

            using (var memoryStream = new MemoryStream(photoFile))
            {
                using (var img = Image.FromStream(memoryStream))
                {
                    return img.Width > 0;
                }
            }
        }

        public static bool IsValidImageFile(this IFormFile photoFile, int maxWidth = 150, int maxHeight = 150)
        {
            if (photoFile == null || photoFile.Length == 0) return false;
            using (var img = Image.FromStream(photoFile.OpenReadStream()))
            {
                if (img.Width > maxWidth) return false;
                if (img.Height > maxHeight) return false;
            }
            return true;
        }

        public static bool IsImageFile(this IFormFile photoFile)
        {
            if (photoFile == null || photoFile.Length == 0)
                return false;

            using (var img = Image.FromStream(photoFile.OpenReadStream()))
            {
                return img.Width > 0;
            }
        }


        public static Image Resize(this Image current, int maxWidth, int maxHeight)
        {
            int width, height;
            #region reckon size 
            if (current.Width > current.Height)
            {
                width = maxWidth;
                height = Convert.ToInt32(current.Height * maxHeight / (double)current.Width);
            }
            else
            {
                width = Convert.ToInt32(current.Width * maxWidth / (double)current.Height);
                height = maxHeight;
            }
            #endregion

            #region get resized bitmap 
            var canvas = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(canvas))
            {
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.DrawImage(current, 0, 0, width, height);
            }

            return canvas;
            #endregion
        }

        public static byte[] ToByteArray(this Image img)
        {


            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }

    }
}