using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{
    public Transform teleportLocation;
    private bool isOn = true;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("trigger in warp");
        if (isOn && "Player".Equals(GetComponent<CircleCollider2D>().gameObject.tag))
        {
            transform.position = teleportLocation.position;
            //ToggleActive();
        }
    }

    public void ToggleActive()
    {
        isOn = !isOn;
    }
}
