using hungry_ladybug;
using System;
using System.Runtime.Serialization;

namespace ladybug_game
{
    class Program

    {
        

        static void Main(string[] args, LadybugException c, char c)
        {
            bool finished = false;
            Field field = new Field();
            Ladybug ladybug = new Ladybug();
            Aphids aphids = new Aphids();

            Console.WriteLine(" \t\t start");
            Console.Read();
            while (!finished)
            {
                try
                {


                    field.drawField();
                    Console.SetCursorPosition(40, 5);
                    Console.Write("score : {0}", ladybug.score);

                    ladybug.Input();
                    object value = ladybug.drawLadybug();
                    aphids.drawLadybug();
                    ladybug.moveLadybug();
                    ladybug.eat(aphids.aphidsLocation(), aphids);
                }
                catch (LadybugException l)

                {
                    Console.Clear();
                    Console.WriteLine(l.Message);
                    Console.WriteLine("restart (y/n)");
                    _ = char.Parse(s: Console.ReadLine());
                    //const char V = 'y';
                    switch (l)
                    {
                        case y :
                            ladybug.x = 10;
                            ladybug.y = 10;
                            break;

                    }
                }
            }
        } } }

internal class Ladybug
{
    public Ladybug()
    {
    }

    internal void drawLadybug()
    {
        throw new NotImplementedException();
    }

    internal void Input()
    {
        throw new NotImplementedException();
    }

    internal void moveLadybug()
    {
        throw new NotImplementedException();
    }
}

internal class Aphids
{
    public Aphids()
    {
    }

    internal void drawLadybug()
    {
        throw new NotImplementedException();
    }
}

    

    [Serializable]
internal class LadybugException : System.Exception
{
    public LadybugException()
    {
    }

    public LadybugException(string? message) : base(message)
    {
    }

    public LadybugException(string? message, System.Exception? innerException) : base(message, innerException)
    {
    }

    protected LadybugException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
