using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerV1 gameManager;
    public void OnTriggerEnter(){
        gameManager.CompleteLevel();
    }
}
