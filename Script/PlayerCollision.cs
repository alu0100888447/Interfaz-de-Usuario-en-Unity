using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovement.forwardForce += 500; 
            //playerMovement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
        }
        if (collision.collider.tag == "NegativeObstacle")
        {
            playerMovement.forwardForce -= 500;

        }
        if (collision.collider.name == "End")
        {
            playerMovement.enabled = false;
        }
    }
}
