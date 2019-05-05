using System;
using Assets.Scripts.Tiles;
using UnityEngine;

namespace Assets.Scripts.Player
{
    internal class MovementCommand
    {
        private readonly Vector3 _direction;
        private readonly Tile _outside = new Outside();

        public MovementCommand(Vector3 direction)
        {
            _direction = direction;
        }

        public void Execute(Transform playerTransform, Tile[,] tiles)
        {
            Tile nextTile = GetDestinationTile(playerTransform, tiles);
            if (nextTile.CanMoveThrough())
            {
                playerTransform.localPosition += _direction * Grid.TilesSize;
                nextTile.OnMoveThrough();
            }
        }

        protected Tile GetDestinationTile(Transform playerTransform, Tile[,] tiles)
        {
            int xIndex = (int)playerTransform.localPosition.x / Grid.TilesSize;
            int yIndex = (int)Math.Abs(playerTransform.localPosition.y) / Grid.TilesSize;
            int destX = xIndex + (int) _direction.x;
            int destY = yIndex + ((int) _direction.y * -1);

            if (destX >= tiles.GetLength(0) || 
                destY >= tiles.GetLength(1) ||
                destX < 0 ||destY < 0)
                return _outside;

            return tiles[destY,destX];
        }
    }
}