using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerV1 : MonoBehaviour
{
  bool gameHasEnded = false;
  float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("End Game");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel() {
        // Get the build index of the current scene.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Load the next scene.
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        if(currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            completeLevelUI.SetActive(false);
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
        Invoke("LoadNextLevel", restartDelay);
    }

}
