using UnityEngine;

namespace other
{
    public class LookAtPlayer : MonoBehaviour
    {
        [Tooltip("바라볼 물체이다. - > 주로 플레이어를 참조하면 된다.")]
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