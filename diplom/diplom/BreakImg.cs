using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom
{
    //класс для рисования всяких закрытых областей
    class BreakImg
    {
        private string filePath;
        private string folderPath;
        private System.Drawing.Bitmap source;
        public double height;
        public double width;


        public BreakImg(string path,string folder)
        {
            this.filePath = path;
            this.folderPath = folder;
            source = new System.Drawing.Bitmap(this.filePath);
            this.height = source.Height;
            this.width = source.Width;
        }
        public void breakShit()
        {
            for (int x = 25; x < 45; x++)
            {
                for (int y = 60; y < 80; y++)
                {
                    source.SetPixel(x, y, System.Drawing.Color.Black);
                }
            }
            string name = this.folderPath + "\\name.jpg";
            source.Save(name, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
         
    }
}
