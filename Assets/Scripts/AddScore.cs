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
                case Info.CharacterType.Monster1:
                    GameManager.I.sccore += 10;
                    break;
                case Info.CharacterType.Monster2:
                    GameManager.I.sccore += 10;
                    break;
                case Info.CharacterType.Monster3:
                    GameManager.I.sccore += 10;
                    break;
                case Info.CharacterType.Monster4:
                    GameManager.I.sccore += 2;
                    break;
                case Info.CharacterType.Monster5:
                    GameManager.I.sccore += 30;
                    break;

                case Info.CharacterType.Boss1:
                    GameManager.I.sccore += 50;
                    break;
                case Info.CharacterType.Boss2:
                    GameManager.I.sccore += 50;
                    break;
                case Info.CharacterType.Boss3:
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
