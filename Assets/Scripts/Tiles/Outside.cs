namespace Assets.Scripts.Tiles
{
    public class Outside : Tile
    {
        public override bool CanMoveThrough()
        {
            return false;
        }

        public override void OnMoveThrough()
        {
            throw new System.NotImplementedException();
        }
    }
}