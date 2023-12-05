using UnityEngine;

public class Boss2Move : BossMove
{
    float y;
    float x;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        positionA = new Vector3(9f, 5f, 0f);
        positionB = new Vector3(-9f, 5f, 0f);
    }
    protected override void MoveObject()
    {

        // 특정 좌표B로 이동 중이면
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, positionB, moveSpeed * Time.deltaTime);

            // 특정 좌표B에 도착하면 특정 좌표A로 이동할 것임을 표시
            if (Vector3.Distance(transform.position, positionB) < 0.1f)
            {
                y = Random.Range(-0.05f, 5.0f);
                x = Random.Range(-9.0f, 9.0f);
                positionA = new Vector3(x, y, 0f);
                movingToTarget = false;
            }
        }
        else
        {
            // 특정 좌표A로 이동 중이면
            transform.position = Vector3.MoveTowards(transform.position, positionA, moveSpeed * Time.deltaTime);

            // 특정 좌표A에 도착하면 특정 좌표B로 이동할 것임을 표시
            if (Vector3.Distance(transform.position, positionA) < 0.1f)
            {
                y = Random.Range(-0.05f, 5.0f);
                x = Random.Range(-9.0f, 9.0f);
                positionB = new Vector3(x, y, 0f);
                movingToTarget = true;
            }
        }
    }
}
