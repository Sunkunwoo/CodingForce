using UnityEngine;

public class SpinShoot : ShootManager
{
    public float TurnSpeed;
    public float SpawnInterval = 0.5f;
    private float _spawnTimer;

    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);

        // 기본 회전
        transform.Rotate(Vector3.forward * (TurnSpeed * 100 * Time.deltaTime));

        // 생성 간격 처리
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer < SpawnInterval) return;

        // 초기화
        _spawnTimer = 0f;

        // 총알 생성
        SpawnBullet(spawnPoint.position, spawnPoint.rotation, atk , Speed);
    }
}