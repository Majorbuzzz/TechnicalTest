using UnityEngine;

namespace Assets.Scripts.Tiles
{
    public class KeyTitle : Tile
    {
        public Sprite CorridorSprite;
        private bool gotKey;

        public override bool CanMoveThrough()
        {
            return true;
        }

        public override void OnMoveThrough()
        {
            if (!gotKey)
            {
                GameManager.GotKey();
                SpriteRenderer.sprite = CorridorSprite;
                gotKey = true;
            }
        }
    }
}