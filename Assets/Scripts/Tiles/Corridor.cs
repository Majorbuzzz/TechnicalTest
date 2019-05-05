namespace Assets.Scripts.Tiles
{
    public class Corridor : Tile
    {
        public override bool CanMoveThrough()
        {
            return true;
        }

        public override void OnMoveThrough()
        {
        }
    }
}