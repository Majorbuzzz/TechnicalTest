using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public GameObject GridGameObject;
        public GameObject PlayerGameObject;
        public GameObject CanvasGameObject;
        public GameObject Key;
        private Grid _grid;
        private int _currentLevel = 0;
        private LevelRenderer _levelRenderer;
        private bool _gotKey;

        void Awake()
        {
            _grid = GridGameObject.GetComponent<Grid>();
            _levelRenderer = GridGameObject.GetComponent<LevelRenderer>();
            GenerateLevel(Level.Levels[_currentLevel]);
        }
        
        public void GenerateLevel(char[,] level)
        {
            _levelRenderer.RenderLevel(level);
            PlayerGameObject.transform.localPosition = _grid.GetStartPosition();
            Instantiate(PlayerGameObject, GridGameObject.transform);
            _currentLevel++;
        }

        public void NextLevel()
        {
            if (_currentLevel< Level.Levels.Length)
                GenerateLevel(Level.Levels[_currentLevel]);
            else
            {
                _levelRenderer.Clear();
                CanvasGameObject.SetActive(true);
            }
            
        }

        public void Restart()
        {
            CanvasGameObject.SetActive(false);
            _currentLevel = 0;
            NextLevel();
        }

        public void GotKey()
        {
            _gotKey = true;
            Key.SetActive(true);
        }

        public void UseKey()
        {
            _gotKey = false;
            Key.SetActive(false);
        }

        public bool HasKey()
        {
            return _gotKey;
        }
    }
}
