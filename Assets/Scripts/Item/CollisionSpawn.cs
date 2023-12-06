using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSpawn : MonoBehaviour
{
    public GameObject ground;
    public GameObject Sky;
    public GameObject rightWall;
    public GameObject leftWall;

    // Start is called before the first frame update
    void Start()
    {
        MakeWall();
    }

    void MakeWall()
    {
        Instantiate(Sky);
        Instantiate(ground);
        Instantiate(rightWall);
        Instantiate(leftWall);
    }
}
