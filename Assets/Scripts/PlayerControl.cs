using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CircleCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("rejump collided");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime,0);
    }
}
