using System.Collections.Generic;
using other;
using UnityEngine;


public class ShapeShoot : ShootManager
{
    [Range(0, 360), Tooltip("퍼지기 전 회전을 줄 수 있음")]
    public float Rotation;

    [Range(3, 7), Tooltip("퍼지는 모양이 몇각형으로 퍼질지 정하는 것")]
    public int Vertex = 3;

    [Range(1, 5), Tooltip("이 값을 조정하여 둥근 느낌, 납작한 느낌으로 표현 됨")]
    public float Subdivision = 3;


    private int _m;
    private float _a;
    private float _phi;
    private readonly List<float> _v = new List<float>();
    private readonly List<float> _xx = new List<float>();

    private void Awake()
    {
        ShapeInit();
    }

    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);
        if (Bullet != null && spawnPoint != null)
        {
            float direction = Rotation;

            for (int r = 0; r < Vertex; r++)
            {
                for (int i = 1; i <= _m; i++)
                {
                    SpawnBullet(spawnPoint.position, Quaternion.Euler(0, 0, direction + _xx[i]), atk, _v[i] * Speed / Subdivision);
                    SpawnBullet(spawnPoint.position, Quaternion.Euler(0, 0, direction - _xx[i]), atk, _v[i] * Speed / Subdivision);
                    SpawnBullet(spawnPoint.position, Quaternion.Euler(0, 0, direction), atk, Speed);

                    direction += 360 / Vertex;
                }
            }
        }
    }

    [ContextMenu("모양 변경 초기화")]
    private void ShapeInit()
    {
        _v.Clear();
        _xx.Clear();

        _m = (int)Mathf.Floor(Subdivision / 2);
        _a = 2 * Mathf.Sin(Mathf.PI / Vertex);
        _phi = ((Mathf.PI / 2f) * (Vertex - 2f)) / Vertex;
        _v.Add(0);
        _xx.Add(0);

        for (int i = 1; i <= _m; i++)
        {
            _v.Add(Mathf.Sqrt(Subdivision * Subdivision - 2 * _a * Mathf.Cos(_phi) * i * Subdivision + _a * _a * i * i));
        }

        for (int i = 1; i <= _m; i++)
        {
            _xx.Add(Mathf.Rad2Deg * (Mathf.Asin(_a * Mathf.Sin(_phi) * i / _v[i])));
        }
    }
}