namespace hungry_ladybug
{
    public class ladybugBase
    {

        public void eat(Position aphids, aphids aphid1)
        {
            Position ldbg = ladybugSize[ladybugSize.Count - 1];
            if (ldbg.x == aphids.x && ldbg.y == aphids.y)
            {
                ladybugSize.Add(new Position(x, y));
                ldbg.aphidsNewLocation();
                score++;
            }
        }
    }
}