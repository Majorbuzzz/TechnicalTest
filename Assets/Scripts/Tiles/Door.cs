using UnityEngine;

namespace Assets.Scripts.Tiles
{
    public class Door : Tile
    {
        public Sprite OpenedDoor;
        private bool _isOpened;

        public override bool CanMoveThrough()
        {
            if (GameManager.HasKey() || _isOpened)
                return true;

            return false;
        }

        public override void OnMoveThrough()
        {
            GameManager.UseKey();
            _isOpened = true;
            SpriteRenderer.sprite = OpenedDoor;
        }
    }
}