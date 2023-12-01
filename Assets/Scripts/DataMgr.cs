using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMgr : MonoBehaviour
{
    public static DataMgr instance;
    public Character currentCharacter;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

}

public enum Character
{
    Blue,Green,Pink,Red,Yellow
}