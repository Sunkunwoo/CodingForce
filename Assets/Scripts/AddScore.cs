using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    Info _info;
    void Start()
    {
        _info = GetComponent<Info>();
        _info.OnDeath += ScoreAdd;
    }
    public void ScoreAdd()
    {
        if (_info != null)
        {
            switch (_info.Character)
            {
                case Info.CharacterType.Monster:
                    GameManager.I.sccore += 10;
                    break;

                case Info.CharacterType.Boss:
                    GameManager.I.sccore += 50;
                    break;
            }
        }
        else
        {
            Debug.LogWarning("Info component not found.");
        }
    }
    void OnDestroy()
    {
        if (_info != null)
        {
            _info.OnDeath -= ScoreAdd;
        }
    }
}
