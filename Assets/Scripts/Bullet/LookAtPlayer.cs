using UnityEngine;

namespace other
{
    public class LookAtPlayer : MonoBehaviour
    {
        public Transform Target;

        private void Update()
        {
            Vector3 direction = Target.position - transform.position;

            float angle = DirectionToAngle(direction);

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        
        private float DirectionToAngle(Vector3 direction)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            return angle;
        }
    }
}