using Assets.Scripts.Tiles;
using UnityEngine;

namespace Assets.Scripts
{
    public class LevelRenderer : MonoBehaviour
    {
        public Grid Grid;
        public TilesFactory TilesFactory;
        public GameManager GameManager;

        public void RenderLevel(char[,] level)
        {
            Clear();
            var cols = level.GetLength(0);
            var rows = level.GetLength(1);
            Tile[,] tiles = new Tile[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    GameObject tile = TilesFactory.GetTile(level[x, y]);
                    tile.transform.localPosition = new Vector3(y * Grid.TilesSize, x * -1 * Grid.TilesSize);
                    var instantiatedTile = Instantiate(tile, transform);
                    tiles[x, y] = instantiatedTile.GetComponent<Tile>();
                    tiles[x, y].GameManager = GameManager;
                }
            }

            Grid.Tiles = tiles;
        }

        public void Clear()
        {
            foreach (Transform child in transform)
                Destroy(child.gameObject);
        }
    }
}
