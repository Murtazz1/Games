using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float randomizedInterval;   
    private float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        randomizedInterval = Random.Range(60f, 100f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter += 1;
        if (counter >= randomizedInterval) {
            counter = 0;
            Instantiate(Enemy, transform.position, transform.rotation);
            randomizedInterval = Random.Range(60f, 100f);
        }
    }
}
