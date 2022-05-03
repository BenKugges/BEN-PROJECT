using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //Private float speed controls the speed of the background//
    private float speed = 8;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
        //Finds the object with the player controller script attached//
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
        //This checks if the game over state has been activated, if it hasn't it will make the move left script continue//
    {
        if (playerControllerScript.gameOver == false)
            transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
