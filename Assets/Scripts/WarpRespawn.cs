using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpRespawn : MonoBehaviour
{
    public GameObject warp1;
    public GameObject warp2;
    // Start is called before the first frame update
    void Start()
    {
        //warp1.ToggleActive();
        //warp2.ToggleActive();
        Invoke("ToggleSet",30);
    }

    // Update is called once per frame
    void ToggleSet()
    {
        //warp1.ToggleActive();
        //warp2.ToggleActive();
        Invoke("ToggleSet", 30);
    }
}
