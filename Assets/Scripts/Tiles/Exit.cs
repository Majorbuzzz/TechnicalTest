using System;

namespace Assets.Scripts.Tiles
{
    public class Exit : Tile
    {
        public override bool CanMoveThrough()
        {
            return true;
        }

        public override void OnMoveThrough()
        {
            GameManager.NextLevel();
        }
    }
}