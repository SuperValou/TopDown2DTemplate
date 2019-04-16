using Assets.Scripts.Players;
using Assets.Scripts.Utilities;
using UnityEngine;

namespace Assets.Scripts.UserInterfaces
{
    public class PlayerHud : MonoBehaviour
    {


        private Player _player;

        void Start()
        {
            _player = this.GetComponentOrThrow<Player>();
        }

        void Update()
        {

        }
    }
}