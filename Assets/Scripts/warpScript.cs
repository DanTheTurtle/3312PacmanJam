using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{
    public GameObject masterWarp;
    public Transform teleportLocation;
    private bool isOn = false;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {

        if (isOn && "Player".Equals(col.gameObject.tag))
        {
            Debug.Log(col.gameObject.tag);
            col.transform.position = teleportLocation.position;
            masterWarp.GetComponent<WarpRespawn>().ToggleSet();
        }
    }

    void turnOff() 
    {
        this.GetComponent<CircleCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
        isOn = false;
    }
    void turnOn()
    {
        this.GetComponent<CircleCollider2D>().enabled = true;
        this.GetComponent<SpriteRenderer>().enabled = true;
        isOn = true;
    }
    public void ToggleActive()
    {
        if (isOn)
        {
            turnOff();
        }else
        {
            turnOn();
        }
    }
}
