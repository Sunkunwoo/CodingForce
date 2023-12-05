using System.Collections.Generic;
using other;
using UnityEngine;
using UnityEngine.UIElements;


public class ShapeShooter : ShootManager
{
    [Range(0, 360), Tooltip("퍼지기 전 회전을 줄 수 있음")]
    public float InitialRotation;

    [Range(3, 7), Tooltip("퍼지는 모양이 몇각형으로 퍼질지 정하는 것")]
    public int NumVertices = 3;

    [Range(1, 5), Tooltip("이 값을 조정하여 둥근 느낌, 납작한 느낌으로 표현 됨")]
    public float SubdivisionFactor = 3;

    private int _halfSubdivision;
    private float _sideLength;
    private float _triangleAngle;
    private readonly List<float> _vertexDistances = new List<float>();
    private readonly List<float> _vertexAngles = new List<float>();

    private void Awake()
    {
        InitialRotation = UnityEngine.Random.Range(0f, 360f);
        NumVertices = UnityEngine.Random.Range(3, 8);
        SubdivisionFactor = UnityEngine.Random.Range(1f, 6f);
        InitializeShape();
    }

    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);

        if (Bullet != null && spawnPoint != null)
        {
            float direction = InitialRotation;

            for (int r = 0; r < NumVertices; r++)
            {
                for (int i = 1; i <= _halfSubdivision; i++)
                {
                    SpawnBullet(
                        spawnPoint.position,
                        Quaternion.Euler(0, 0, direction + _vertexAngles[i]),
                        atk,
                        _vertexDistances[i] * Speed / SubdivisionFactor
                    );

                    SpawnBullet(
                        spawnPoint.position,
                        Quaternion.Euler(0, 0, direction - _vertexAngles[i]),
                        atk,
                        _vertexDistances[i] * Speed / SubdivisionFactor
                    );

                    SpawnBullet(spawnPoint.position, Quaternion.Euler(0, 0, direction), atk, Speed);

                    direction += 360 / NumVertices;
                }
            }
        }
    }

    [ContextMenu("Reset Shape")]
    private void InitializeShape()
    {
        _vertexDistances.Clear();
        _vertexAngles.Clear();

        _halfSubdivision = (int)Mathf.Floor(SubdivisionFactor / 2);
        _sideLength = 2 * Mathf.Sin(Mathf.PI / NumVertices);
        _triangleAngle = ((Mathf.PI / 2f) * (NumVertices - 2f)) / NumVertices;
        _vertexDistances.Add(0);
        _vertexAngles.Add(0);

        for (int i = 1; i <= _halfSubdivision; i++)
        {
            _vertexDistances.Add(
                Mathf.Sqrt(
                    SubdivisionFactor * SubdivisionFactor
                    - 2 * _sideLength * Mathf.Cos(_triangleAngle) * i * SubdivisionFactor
                    + _sideLength * _sideLength * i * i
                )
            );
        }

        for (int i = 1; i <= _halfSubdivision; i++)
        {
            _vertexAngles.Add(Mathf.Rad2Deg * (Mathf.Asin(_sideLength * Mathf.Sin(_triangleAngle) * i / _vertexDistances[i])));
        }
    }
}