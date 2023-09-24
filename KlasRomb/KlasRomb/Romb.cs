using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRomb
{
    internal class Romb
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public Romb(double width, double height)
        {
            this.Width = width;
            this.height = height;
        }


        public double Lice()
        {
            return width * height;
        }

        public double Perimetur()
        {
            return 4 * width;
        }

        //public override string ToString()
        //{
        //    return $"width = {this.width} height = {this.height}"
        //}

        public void Izhod()
        {
            Console.WriteLine($"width = {this.width} height = {this.height}");
        }

    }
}
