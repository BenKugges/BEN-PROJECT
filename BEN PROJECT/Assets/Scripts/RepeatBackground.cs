using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{   //This script causes the background to repeat that is behind the player//
    //Private Vector3 startPos records the starting position of the background//
    //Private float repeatWidth records the width of the background//
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    
    void Update()
    {   
        //If the position of the background is 100 units different from the start position it will reset it back to its original position//
        if (transform.position.x < startPos.x - 100)
        {
            transform.position = startPos;
        }
    }


}

