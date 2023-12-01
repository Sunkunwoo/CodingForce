using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject Apple;
    public GameObject Banana;
    public GameObject Kiwi;
    public GameObject Pineapple;
    public GameObject Mellon;
    int type;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeItem", 0, 5f);
    }

    // Update is called once per frame

    void MakeItem()
    {
        type = Random.Range(0, 4);
        if (type == 0)
            Instantiate(Apple);
        else if (type == 1)
            Instantiate(Banana);
        else if (type == 2)
            Instantiate(Kiwi);
        else if (type == 3)
            Instantiate(Pineapple);
        else if (type == 4)
            Instantiate(Mellon);
    }
}
