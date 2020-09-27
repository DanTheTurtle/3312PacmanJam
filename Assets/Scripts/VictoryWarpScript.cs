using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryWarpScript : MonoBehaviour
{
    public Transform gemParent;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if ("Player".Equals(col.gameObject.tag))
        {
            Manager.instance.WinGame();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(gemParent.childCount == 0)
        {
            this.GetComponent<BoxCollider2D>().enabled = true;
            this.GetComponent<SpriteRenderer>().enabled = true;

        } 
    }
}
