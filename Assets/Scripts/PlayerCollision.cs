using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle"){
            Debug.Log("We hit an obstacle");
            movement.enabled = false; // disable movement for player if player collides with obstacle
            FindObjectOfType<GameManagerV1>().EndGame();
        }else if(collisionInfo.collider.tag == "End")
        {
            Debug.Log("Level Complete");
            FindObjectOfType<GameManagerV1>().CompleteLevel();
        }
    }
}
