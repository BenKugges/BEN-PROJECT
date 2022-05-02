using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Values for maximum and minimum boundry for the game object to be within//
    //Private float topBound is the furthest left that any object can travel//
    //Private float lowerBound is the furthest right any object can travel//
    private float topBound = 35;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        //This checks whether the asset with the script applied is within the boundaries, if the asset is not within the boundries it will be destroyed//
        //This script uses the private floats from above//
    {
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
