using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBossBgm : BgmPlayer
{
    public string objectTagToDelete = "BgmPlayer"; // �����Ϸ��� ������Ʈ�� �±�

    protected override void Start()
    {
        base.Start();
        GameObject[] objectsToDelete = GameObject.FindGameObjectsWithTag(objectTagToDelete);

        foreach (GameObject obj in objectsToDelete)
        {
            Destroy(obj);
        }
    }
}
