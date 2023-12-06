using UnityEditor;
using UnityEngine;

public abstract class ShootManager : MonoBehaviour
{
    public AudioClip trickatkSound;
    public GameObject Bullet;
    public Transform spawnPoint;
    public float Speed;

    protected virtual void Start()
    {
        Speed = 10.0f;
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("Shoot", 0f, 10f);
    }

    public abstract void Shoot(float atk);

    protected void SpawnBullet(Vector3 position, Quaternion rotation, float atk, float speed = 0)
    {
        GameObject bullet = Instantiate(Bullet, position, rotation);

        if (bullet != null)
        {
            MonsterBulletController bulletController = bullet.GetComponent<MonsterBulletController>();

            if (bulletController != null)
            {
                bulletController.Initialize(atk);
                bulletController.Speed = speed;
            }

            Destroy(bullet, 10f);
        }
    }
}
