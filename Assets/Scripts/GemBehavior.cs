using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehavior : MonoBehaviour
{
    public float value;

    public AudioClip aClip;
    bool endkey;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player".Equals(collision.gameObject.tag))
        {
            ScoreBehavior.instance.ScoreUpdate(value);
            //AudioSource.PlayClipAtPoint(aClip, transform.position);
            Destroy(this.gameObject);
        }
    }
}
