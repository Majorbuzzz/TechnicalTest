using System;
using UnityEngine;

namespace Assets.Scripts.Tiles
{
    public class Wall : Tile
    {

        public override bool CanMoveThrough()
        {
            return false;
        }

        public override void OnMoveThrough()
        {
            throw new NotImplementedException();
        }
    }
}