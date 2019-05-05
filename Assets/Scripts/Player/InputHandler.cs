using Assets.Scripts.Tiles;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class InputHandler : MonoBehaviour
    {
        public Transform PlayerTrans;
        private Tile[,] _tiles;
        private MovementCommand _buttonW, _buttonS, _buttonA, _buttonD;

        void Start()
        {
            _buttonW = new MovementCommand(Vector3.up);
            _buttonS = new MovementCommand(Vector3.down);
            _buttonA = new MovementCommand(Vector3.left);
            _buttonD = new MovementCommand(Vector3.right);
            _tiles = GetComponentInParent<Grid>().Tiles;
        }

        void Update()
        {
            HandleInput();
        }
        
        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.W))
                _buttonW.Execute(PlayerTrans, _tiles);
            else if (Input.GetKeyDown(KeyCode.A))
                _buttonA.Execute(PlayerTrans, _tiles);
            else if (Input.GetKeyDown(KeyCode.S))
                _buttonS.Execute(PlayerTrans, _tiles);
            else if (Input.GetKeyDown(KeyCode.D))
                _buttonD.Execute(PlayerTrans, _tiles);
        }
    }

}