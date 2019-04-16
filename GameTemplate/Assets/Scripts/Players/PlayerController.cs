using System;
using Assets.Scripts.Utilities;
using UnityEngine;

namespace Assets.Scripts.Players
{
    public class PlayerController : MonoBehaviour
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
        
        public float speed = 100000;
        public float drag = 10000;

        private Vector2 _movement;

        private Player _player;
        private SpriteRenderer _spriteRenderer;
        private Animator _animator;
        private Rigidbody2D _rigidBody2D;

        void Start()
        {
            _player = this.GetComponentOrThrow<Player>();

            _rigidBody2D = this.GetComponentOrThrow<Rigidbody2D>();
            _rigidBody2D.drag = drag;

            _spriteRenderer = this.GetComponentOrThrow<SpriteRenderer>();
            
            _animator = this.GetComponentOrThrow<Animator>();
        }

        void Update()
        {
            float horizontalInput = Input.GetAxis(HorizontalAxisName);
            float verticalInput = Input.GetAxis(VerticalAxisName);

            _movement = new Vector2(horizontalInput * speed, verticalInput * speed);

            UpdatePlayerAnimation();
        }

        private void UpdatePlayerAnimation()
        {
            //_animator.SetInteger(nameof(PlayerDirection), (int)PlayerDirection.NotMoving);

        }

        void FixedUpdate()
        {
            _rigidBody2D.AddForce(_movement);
        }
    }
}
