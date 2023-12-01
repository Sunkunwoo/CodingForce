using UnityEngine;


public class CircleShot : MonoBehaviour
{
    public AudioClip trickatkSound;
    //발사될 총알 오브젝트
    public GameObject Bullet;
    public Transform spawnPoint;
    private float atkValue = 10;
    private void Start()
    {
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("ShootWithATK", 0f, 0.5f);
    }
    private void ShootWithATK()
    {
        Shoot(atkValue);
    }

    private void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);
        if (Bullet != null && spawnPoint != null)
        {
            //360번 반복
            for (int i = 0; i < 360; i += 13)
            {
                //총알 생성
                GameObject temp = Instantiate(Bullet);

                

                //총알 생성 위치를 (0,0) 좌표로 한다.
                temp.transform.position = spawnPoint.position;

                //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
                temp.transform.rotation = Quaternion.Euler(0, 0, i);

                // 탄알 스크립트 가져오기
                BulletController bulletController = temp.GetComponent<BulletController>();

                if (bulletController != null)
                {
                    // Atk 값을 전달하여 탄알 초기화
                    bulletController.Initialize(atk);
                }
                
                //2초마다 삭제
                Destroy(temp, 2f);
            }

        }
    }
}