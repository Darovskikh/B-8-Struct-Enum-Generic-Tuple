using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20, new Coordinates(5, 6));
            Rectangle[] rectangles = new Rectangle[100];
            Random random = new Random();
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i] = new Rectangle(random.Next(10), random.Next(10), new Coordinates(random.Next(100), random.Next(100)));
            }

            int count = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                for (int j = 0; j < rectangles.Length; j++)
                {
                    if (rectangles[i].h == rectangles[j].h && rectangles[i].w == rectangles[j].w)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }

    struct Rectangle
    {
        public int w, h;
        public Coordinates coords;

        public Rectangle(int w, int h, Coordinates coords)
        {
            this.w = w;
            this.h = h;
            this.coords = coords;
        }

    }
    struct Coordinates
    {
        int x, y;
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
