using System;
using UnityEngine;

namespace Assets.Scripts.Tiles
{
    public class TilesFactory : MonoBehaviour
    {
        public GameObject Wall;
        public GameObject Corridor;
        public GameObject Exit;
        public GameObject Door;
        public GameObject Key;
        public GameObject Start;

        public GameObject GetTile(char tileType)
        {
            switch (tileType)
            {
                case '0':
                    return Wall;
                case '1':
                    return Corridor;
                case 'e':
                    return Exit;
                case 'd':
                    return Door;
                case 'k':
                    return Key;
                case 's':
                    return Start;
                default:
                    throw new Exception("Invalid Tile Type passed in the factory : " + tileType);
            }
        }

    }
}
