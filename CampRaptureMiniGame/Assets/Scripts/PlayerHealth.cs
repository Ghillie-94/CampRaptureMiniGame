using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public string gameOverScene;
    // This function is NOT built in to Unity
    // It will only be called manually by our own code
    // It must be marked "public" so our other scripts can access it
    public void Kill()
    {
        // This will destroy the gameObject that this script is attached to
        //Destroy(gameObject);
        SceneManager.LoadScene(gameOverScene);
    }
}
