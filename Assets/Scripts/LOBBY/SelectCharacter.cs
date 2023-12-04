using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class SelectCharacter : MonoBehaviour
{
    public AudioClip audioClip;
    public Character character;
    Animator anim;
    SpriteRenderer sprite;
    [SerializeField] SelectCharacter[] chars;

    private void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        if (DataMgr.instance.currentCharacter == character) OnSelect();
        else OnDeSelect();
    }

    private void OnMouseUpAsButton() //콜라이더가 아니라서 그럼
    {
        SoundManager.s.PlayFXSound(audioClip);
        DataMgr.instance.currentCharacter = character;
        OnSelect();
        for(int i=0; i<chars.Length; i++)
        {
            if (chars[i] != this)
                chars[i].OnDeSelect();
        }
    }
    private void OnDeSelect()
    {
        anim.SetBool("IsRun", false);
        sprite.color = new Color(0.5f, 0.5f, 0.5f);
    }
    private void OnSelect()
    {
        anim.SetBool("IsRun", true);
        sprite.color = new Color(1f, 1f, 1f);
    }
}
