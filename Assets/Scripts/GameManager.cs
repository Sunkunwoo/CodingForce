using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    // Start is called before the first frame update
    void Awake()
    {
            I = this;
            DontDestroyOnLoad(this.gameObject);
    }


}
