using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Rigidbody defines the rigid body component attached to the player as the player//
    //the floats jumpForce and gravityModifier control how high the player will jump//
    //The bool isOnGround is used later to detect whether the player is touching the ground//
    //The bool gameOver is used in scripts to detect whether the game is over//
    //The public GameObject projectilePrefab is the prefab the player will shoot//
    private Rigidbody playerBody;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
        //This spawns a projectile when the key F is pressed//
        //This projectile will move from the front of the character//
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //This checks if the player is on the ground and if they are, when space is pressed it will make the player jump//
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    //This function detects collisions//
    //It resets the boolean isOnGround to true when the player collides with the object tagged "Ground"//
    //This function causes a game over when the player collides with anything other than the ground//
    //Parameters - Collision Detection Information//
    private void OnCollisionEnter(Collision collision)
    {
        //This checks if the player is colliding with an object other than the ground if so, it will cause a game over//
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }



    }
}
