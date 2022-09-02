using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Vector3 destination;
    public float speedFactor;

    // Start is called before the first frame update
    void Start()
    {
        this.destination = getNewLocation(-15, 15);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 actualPosition = this.GetComponent<Transform>().position;
        if (Vector3.Distance(actualPosition, this.destination) < 0.5f)
        {
            this.destination = getNewLocation(-15, 15);
        }
        else {
            this.GetComponent<Rigidbody>().position = Vector3.MoveTowards(actualPosition,destination,this.speedFactor);
        }
        
    }

    private Vector3 getNewLocation(int min, int max)
    {
        return new Vector3(Random.Range(min, max), 0.5f, Random.Range(min, max));
    }
}
