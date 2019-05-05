using System;
using Assets.Scripts.Tiles;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(LevelRenderer))]
    public class Grid : MonoBehaviour
    {
        public static int TilesSize = 64;
        public Tile[,] Tiles;
        
        public Vector3 GetStartPosition()
        {
            var cols = Tiles.GetLength(0);
            var rows = Tiles.GetLength(1);
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (Tiles[x,y].GetType() == typeof(Start))
                    {
                        return Tiles[x, y].transform.localPosition;
                    }
                }
            }
            throw new Exception("No start position in the grid.");
        }
    }
}
