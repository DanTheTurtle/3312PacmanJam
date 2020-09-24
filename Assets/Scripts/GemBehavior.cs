using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehavior : MonoBehaviour
{
    public float value;
    bool endkey;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player".Equals(collision.gameObject.tag))
        {
            ScoreBehavior.instance.ScoreUpdate(value);
            if (endkey)
            {
                //closer to unlocking thing
            }
            Destroy(this.gameObject);
        }
    }
}
