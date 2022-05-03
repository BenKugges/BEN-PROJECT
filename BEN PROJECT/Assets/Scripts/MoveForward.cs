using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Public float speed controls the speed at which objects with this script applied to it move at//
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
        //This script makes the asset with it applied to move forward//
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
          
        


        
    }
}
