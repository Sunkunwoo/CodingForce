using UnityEngine;

public class Boss2Move : BossMove
{
    float y;
    float x;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        PositionA = new Vector3(9f, 5f, 0f);
        PositionB = new Vector3(-9f, 5f, 0f);
    }
    protected override void MoveObject()
    {

        // Ư�� ��ǥB�� �̵� ���̸�
        if (MovingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, PositionB, MoveSpeed * Time.deltaTime);

            // Ư�� ��ǥB�� �����ϸ� Ư�� ��ǥA�� �̵��� ������ ǥ��
            if (Vector3.Distance(transform.position, PositionB) < 0.1f)
            {
                y = Random.Range(-0.05f, 5.0f);
                x = Random.Range(-9.0f, 9.0f);
                PositionA = new Vector3(x, y, 0f);
                MovingToTarget = false;
            }
        }
        else
        {
            // Ư�� ��ǥA�� �̵� ���̸�
            transform.position = Vector3.MoveTowards(transform.position, PositionA, MoveSpeed * Time.deltaTime);

            // Ư�� ��ǥA�� �����ϸ� Ư�� ��ǥB�� �̵��� ������ ǥ��
            if (Vector3.Distance(transform.position, PositionA) < 0.1f)
            {
                y = Random.Range(-0.05f, 5.0f);
                x = Random.Range(-9.0f, 9.0f);
                PositionB = new Vector3(x, y, 0f);
                MovingToTarget = true;
            }
        }
    }
}
