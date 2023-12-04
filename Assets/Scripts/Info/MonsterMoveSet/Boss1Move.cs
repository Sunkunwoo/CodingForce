using UnityEngine;

public class Boss1Move : BossMove
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        PositionA = new Vector3(9f, 5f, 0f);
        PositionB = new Vector3(-9f, 5f, 0f);
    }
    protected override void MoveObject()
    {
        // 특정 좌표B로 이동 중이면
        if (MovingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, PositionB, MoveSpeed * Time.deltaTime);

            // 특정 좌표B에 도착하면 특정 좌표A로 이동할 것임을 표시
            if (Vector3.Distance(transform.position, PositionB) < 0.1f)
            {
                MovingToTarget = false;
            }
        }
        else
        {
            // 특정 좌표A로 이동 중이면
            transform.position = Vector3.MoveTowards(transform.position, PositionA, MoveSpeed * Time.deltaTime);

            // 특정 좌표A에 도착하면 특정 좌표B로 이동할 것임을 표시
            if (Vector3.Distance(transform.position, PositionA) < 0.1f)
            {
                MovingToTarget = true;
            }
        }
    }
}
