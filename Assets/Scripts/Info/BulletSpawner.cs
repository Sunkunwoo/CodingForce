using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletFabs;
    public Transform spawnPoint;

    public void SpawnProjectile(float atk)
    {
        if (bulletFabs != null && spawnPoint != null)
        {
            GameObject bullet = Instantiate(bulletFabs, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("탄환생성");

            // 탄알 스크립트 가져오기
            BulletController bulletController = bullet.GetComponent<BulletController>();

            if (bulletController != null)
            {
                // Atk 값을 전달하여 탄알 초기화
                bulletController.Initialize(atk);
            }
        }
    }
}
