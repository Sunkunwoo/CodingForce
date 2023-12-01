using UnityEngine;

namespace other
{
    public class LookAtPlayer : MonoBehaviour
    {
        private void Update()
        {
            // GameManager의 인스턴스를 얻어옴
            GameManager gameManager = GameManager.I;

            // GameManager의 Player 속성을 참조
            Transform target = gameManager.PlayerPos as Transform;

            if (target != null)
            {
                Vector3 direction = target.position - transform.position;
                float angle = DirectionToAngle(direction);
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }
        }

        private float DirectionToAngle(Vector3 direction)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            return angle;
        }
    }
}
