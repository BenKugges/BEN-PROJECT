using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
      
    }

    // Update is called once per frame
    void Update()
    {
       
        {
            
        }
    }

    void SpawnObstacle ()
    {
        if (playerControllerScript.gameOver == false)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(21, 0, 9), enemyPrefabs[enemyIndex].transform.rotation);
        }
        
    }



}

