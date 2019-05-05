using System;
using UnityEngine;

namespace Assets.Scripts.Tiles
{
    [RequireComponent(typeof(Transform))]
    public abstract class Tile : MonoBehaviour
    {
        public GameManager GameManager;

        public abstract bool CanMoveThrough();

        public abstract void OnMoveThrough();

        protected SpriteRenderer SpriteRenderer;

        public void Awake()
        {
           SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        //protected void SetSprite(Sprite corridorSprite)
        //{
        //    var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //    spriteRenderer.sprite = corridorSprite;
        //}
    }
}
