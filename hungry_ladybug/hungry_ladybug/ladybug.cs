using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hungry_ladybug
{
    public class ladybug
    {
        
        public char Symbol { get; set; }
        ConsoleKeyInfo KeyInfo = new ConsoleKeyInfo();
        char Key = 'w';
        char dir = 'u';
        public List<Position>ladybugSize { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int score { get; set; }
        
        public ladybug()
        {

        
            x = 5;
            y = 5;
            score= 0;
            ladybugSize = new List<Position>();
            ladybugSize.Add(new Position(x, y));
        }
        public void drawLadybug()
        {
            foreach(Position pos in ladybugSize)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("#");
            }
        }
    public void Input()
    {
        if (Console.KeyAvailable)
        {
            KeyInfo = Console.ReadKey(true);
            Key = KeyInfo.KeyChar;
        }

    }
    private void direction()
    {
        if (Key == 'w' && dir != 'd')
        {
            dir = 'u';
        }
        else if (Key == 's' && dir != 'u')
        {
            dir = 'd';
        }
        else if (Key == 'd' && dir != 'l')
        {
            dir = 'r';
        }
        else if (Key == 'a' && dir != 'r')
        {
            dir = 'l';
        }
    }
    public void moveLadybug()
        {
            
        direction();
        if (dir == 'u')

        {
            y--;

        }
        else if (dir == 'd')
        {
            y++;

        }
        else if (dir == 'r')
        {
            x++;
        }
        else if (dir == 'l')
        {
            x--;
        }
        ladybugSize.Add(new Position(x, y));
            ladybugSize.RemoveAt(0);
            Thread.Sleep(100);
        }

        public void Eat(Position aphids, aphids aphid1)
        {
            Position ldbg  = ladybugSize[ladybugSize.Count - 1];
            if(ldbg.x == aphids.x && ldbg.y == aphids.y)
            {
                ladybugSize.Add(new Position(x, y));
                ldbg.aphidsNewLocation();
                score++;
            }
        }

        public void clash(Field field)

        {
            Position bug = ladybugSize[ladybugSize.Count - 1];
            if (bug.x >= field.width || bug.x <= 0 || bug.y >= field.height || bug.y <=0)
            {
                throw new Exception("game over, loser!");
            }
        }

    }
}
