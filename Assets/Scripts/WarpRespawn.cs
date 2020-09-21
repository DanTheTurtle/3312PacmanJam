using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpRespawn : MonoBehaviour
{
    public GameObject warp1;
    public GameObject warp2;
    public float respawnTime = 30f;
    // Start is called before the first frame update
    void Start()
    {
        ToggleSet();
    }


    public void ToggleSet()
    {
        var link1 = warp1.GetComponent<warpScript>();
        var link2 = warp2.GetComponent<warpScript>();
        link1.ToggleActive();
        link2.ToggleActive();
        Invoke("ToggleSet", respawnTime);
    }

}