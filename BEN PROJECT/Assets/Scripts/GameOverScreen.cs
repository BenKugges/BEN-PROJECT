
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    //Private PlayerController playerControllerScript is used to find the asset with the playercontroller script attached//
    //The public GameObject endScreen is the asset that will be displayed when the player loses//
    private PlayerController playerControllerScript;
    public GameObject endScreen;

    // Start is called before the first frame update
    //This finds the gameObject with named "Player"//
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame

    //
    void Update()
    {
        if (playerControllerScript.gameOver == true)
        {

            Instantiate(endScreen, new Vector3(-1, 2, 10), endScreen.transform.rotation);
            Destroy(gameObject);
        }

    }





}