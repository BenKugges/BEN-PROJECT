using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Values for maximum and minimum boundry//
    private float topBound = 35;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        //This checks whether the asset with the script applied is within the boundries, if the asset is not within the boundries it will be destroyed//
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
