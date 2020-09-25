using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    public int gemCount;
    public GameObject gemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] positionArray = new[] { new Vector3(-1.17f,0.24f,0f),
                                        new Vector3(0.1f,-1.07f,0f),
                                        new Vector3(0.1f,0.23f,0f),
                                        new Vector3(-1.22f,-1.03f,0f),

                                        new Vector3(7.45f,2f,0f),
                                        new Vector3(9.75f,0f,0f),
                                        new Vector3(9.75f,4f,0f),
                                        new Vector3(7f,-5f,0f),
                                        new Vector3(-10f,0f,0f),
                                        new Vector3(-3f,5f,0f),
                                        new Vector3(-5f,3f,0f),
                                        new Vector3(-4f,-5.75f,0f),
                                        new Vector3(2.3f,-5.9f,0f),
                                        new Vector3(2f,-1f,0f),
                                        new Vector3(-8.25f,-6f,0f),
                                        new Vector3(-10f,-2f,0f),
                                        new Vector3(-8.25f,6f,0f),
                                        new Vector3(-4f,-4.5f,0f),
                                        new Vector3(-4f,-3.25f,0f),
                                        new Vector3(0f,4f,0f)};
        foreach (Vector3 pos in positionArray) {
            Spawn(pos);
        }
    }

    void Spawn(Vector3 spawnLocation)
    {
        GameObject newGem = Instantiate(gemPrefab, spawnLocation, Quaternion.identity); //might need to add more to this
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
