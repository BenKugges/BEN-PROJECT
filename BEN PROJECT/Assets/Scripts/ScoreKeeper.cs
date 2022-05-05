using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    //public TextMeshProUGUI is the text displaying the score//.
    //public float scoreCount keeps track of the score//
    //public float pointsPerSecond is the amount of points the player gains per second//
    //Public PlayerController playerControllerScript finds the asset with the playercontroller script attached//
    public TextMeshProUGUI scoreText;
    public float scoreCount;
    public float pointsPerSecond;
    private PlayerController playerControllerScript;
    //Finds the player controller script//
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    //If the game is not over the score will keep increasing//
    //When the player crashes the score will stop increasing//
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
            scoreText.text = "Units Ran:" + scoreCount;
        }
            
        
    }

}
