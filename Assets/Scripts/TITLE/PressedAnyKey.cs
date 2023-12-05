using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PressedAnyKey : MonoBehaviour
{
    public AudioClip soundClip;
    public void Start()
    {
        Cursor.visible = true;
    }
    public void Update()
    {
        if (Input.anyKey == true)
        {
            SceneManager.LoadScene("LOBBY");
            SoundManager.s.PlayFXSound(soundClip);
        }
    }


}
