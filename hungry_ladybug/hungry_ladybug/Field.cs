using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hungry_ladybug
{
    public class Field
    {
        public int width { get; set; }
        public int height { get; set; }
        public Field()
        {
            width = 50;
            height = 35;
            Console.CursorVisible = false;

        }
        public void drawField()
        {
            Console.Clear();
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("+");
            }
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.Write("+");
            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(0,i);
                Console.Write("+");
            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(width,i);
                Console.Write("+");
            }

        }

    }
}


    

