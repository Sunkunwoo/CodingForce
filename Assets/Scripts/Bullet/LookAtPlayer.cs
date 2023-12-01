using UnityEngine;

namespace other
{
    public class LookAtPlayer : MonoBehaviour
    {
        private void Update()
        {
            // User 태그를 가진 오브젝트를 찾음
            GameObject userObject = GameObject.FindWithTag("User");

            if (userObject != null)
            {
                // 찾은 오브젝트의 Transform을 가져와서 바라보기
                Transform target = userObject.transform;

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
