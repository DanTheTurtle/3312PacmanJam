using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public Vector3[] moveToPoints;
    public Vector3 currentPoint; 
    public Vector3 startPosition;

    public int pointSelection;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {

        //Starts to move the object towards the first "moveToPoint" you set in inspector
        this.transform.position = Vector3.MoveTowards(this.transform.position, currentPoint, Time.deltaTime * speed);

        //check to see if the object is at the next "moveToPoint"
        if (this.transform.position == currentPoint)
        {

            //if so it sets the next moveTo location
            pointSelection++;

            //if your object hits the last "moveToPoint it sends the object back to starting position to start the sequence over
            if (pointSelection == moveToPoints.Length)
            {
                pointSelection = 0;

            }

            //sets the destination of the "moveToPoint" destination
            currentPoint = moveToPoints[pointSelection];
        }
    }
}
