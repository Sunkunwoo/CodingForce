using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class EndAnimController : MonoBehaviour
{
    [SerializeField] Animator endAnimController;

    private void Awake()
    {
        endAnimController = GetComponent<Animator>();
    }
    private void Update()
    {
        if (endAnimController.GetCurrentAnimatorStateInfo(0).IsName("EndingScreen") == true){
            if (endAnimController.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                Debug.Log("애니메이션 종료");
            }
        }

    }
}