using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public int sceneToLoa;
    public void ToMenu()
    {
        sceneToLoa = 0;
        SceneManager.LoadScene(sceneToLoa);
        Debug.Log("Back to Menu");
    }

    public void ReloadScene()
    {
        sceneToLoa = 1;
        SceneManager.LoadScene(sceneToLoa);
        Debug.Log("Scene Reloaded");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
            ToMenu();
        if (Input.GetKeyUp(KeyCode.N))
            ReloadScene();
    }
    
}
