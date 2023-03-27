using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hungry_ladybug
{
    internal class aphids
    {
        public Position aphidsPos = new Position();
        Random random = new Random();
        Field field  = new Field();
        public aphids()
        {
            Console.SetCursorPosition(aphidsPos.x, aphidsPos.y);
            Console.Write("*");

        }
        public Position AphidsLocation()
            { 
            return aphidsPos;
        }
        public void aphidsLocation()
        {
            aphidsPos.x = random.Next(2,field.width);
            aphidsPos.y = random.Next(2,field.height);
        }
    }
}
