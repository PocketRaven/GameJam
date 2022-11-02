using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    private float startDelay = 2;
    private float repeateRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeateRate);
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(Obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
