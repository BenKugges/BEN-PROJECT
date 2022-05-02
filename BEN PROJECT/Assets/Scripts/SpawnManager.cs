using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //This script controls the spawning of the obstacles and enemies//
 
    private PlayerController playerControllerScript;
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    private float startDelay = 2;
    private float repeatRate = 2;
    private Vector3 spawnPos = new Vector3(21, 0, 9);
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
     
    }

    // Update is called once per frame
    void Update()
    {
       
        {
            
        }
    }


    //This function occurs when the InvokeRepeating "SpawnObstacle" is active//
    //This function causes either an obstacle or an animal to spawn randomly//
    //This function also has the spawn position of the obstacles//
    //return value - none//
    void SpawnObstacle ()
    {
        if (playerControllerScript.gameOver == false)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(21, 0, 9), enemyPrefabs[enemyIndex].transform.rotation);
        }
        
    }



}


