using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;

    private void Start()
    {
        GameController.IncrementPower += IncrementPower;
        GameController.DecrementPower += DecrementPower;
        GameController.EndGame += End;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            GameController.Increment();
        }
        if (collision.collider.tag == "NegativeObstacle")
        {
            GameController.Decrement();

        }
        if (collision.collider.name == "End")
        {
            GameController.End();
        }
    }

    private void IncrementPower ()
    {
        playerMovement.forwardForce += 500;
    }

    private void DecrementPower ()
    {
        playerMovement.forwardForce -= 500;
    }

    private void End ()
    {
        playerMovement.enabled = false;
    }
}
