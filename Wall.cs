using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Wall
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public Wall(int w, int h, int l)
        {
            Width = w;
            Height = h;
            Length = l;
        }
    }
}
