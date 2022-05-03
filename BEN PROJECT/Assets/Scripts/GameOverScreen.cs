using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == true)
        {

            Instantiate(endScreen, new Vector3(-2, 2, -2), endScreen.transform.rotation);
        }

    }

 
        


}
