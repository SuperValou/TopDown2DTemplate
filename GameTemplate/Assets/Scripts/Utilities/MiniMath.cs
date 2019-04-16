using UnityEngine;

namespace Assets.Scripts.Utilities
{
    public static class MiniMath
    {
        public static float GetSquaredDistance(Vector3 positionA, Vector3 positionB)
        {
            float x = positionA.x - positionB.x;
            float y = positionA.y - positionB.y;
            float z = positionA.z - positionB.z;
            return x * x + y * y + z * z;
        }
    }
}