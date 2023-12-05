using UnityEngine;

public class Boss1Move : BossMove
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        positionA = new Vector3(9f, 5f, 0f);
        positionB = new Vector3(-9f, 5f, 0f);
    }
    protected override void MoveObject()
    {
        // Ư�� ��ǥB�� �̵� ���̸�
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, positionB, moveSpeed * Time.deltaTime);

            // Ư�� ��ǥB�� �����ϸ� Ư�� ��ǥA�� �̵��� ������ ǥ��
            if (Vector3.Distance(transform.position, positionB) < 0.1f)
            {
                movingToTarget = false;
            }
        }
        else
        {
            // Ư�� ��ǥA�� �̵� ���̸�
            transform.position = Vector3.MoveTowards(transform.position, positionA, moveSpeed * Time.deltaTime);

            // Ư�� ��ǥA�� �����ϸ� Ư�� ��ǥB�� �̵��� ������ ǥ��
            if (Vector3.Distance(transform.position, positionA) < 0.1f)
            {
                movingToTarget = true;
            }
        }
    }
}
