using Assets.Scripts.Utilities;
using UnityEngine;

namespace Assets.Scripts.Players
{
    public class Player : MonoBehaviour
    {
        private PlayerController _controller;

        void Start()
        {
            _controller = this.GetComponentOrThrow<PlayerController>();
        }
    
        void Update()
        {
        
        }
    }
}
