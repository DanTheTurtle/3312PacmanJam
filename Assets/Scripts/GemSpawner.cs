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
        Transform[] positionArray = new Transform[gemCount];
        foreach(Transform pos in positionArray)
        {
            Spawn(pos);
        }
    }

    void Spawn(Transform spawnLocation)
    {
        GameObject newGem = Instantiate(gemPrefab, spawnLocation); //might need to add more to this
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
