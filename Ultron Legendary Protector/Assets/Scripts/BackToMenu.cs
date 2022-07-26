using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public int sceneToLoa;
    public AudioSource backSound;
    public AudioSource retrySound;
    public void ToMenu()
    {
        sceneToLoa = 0;
        SceneManager.LoadScene(sceneToLoa);
        Debug.Log("Back to Menu");
        Instantiate(backSound, new Vector3(0,0,0), new Quaternion(0,0,0,0));
    }

    public void ReloadScene()
    {
        sceneToLoa = 1;
        SceneManager.LoadScene(sceneToLoa);
        Debug.Log("Scene Reloaded");
        Instantiate(retrySound, new Vector3(0,0,0), new Quaternion(0,0,0,0));
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
            ToMenu();
        if (Input.GetKeyUp(KeyCode.N))
            ReloadScene();
    }
    
}
