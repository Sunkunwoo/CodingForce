using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public AudioClip audioClip;
    public void PressedStartButton()
    {
        Instantiate(GameManager.I.player);
        SoundManager.s.PlayFXSound(audioClip);
        SceneManager.LoadScene("Stage1");
    }
}
