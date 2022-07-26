using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public AudioSource quitSound;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Start Game");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
        Instantiate(quitSound, new Vector3(0,0,0), new Quaternion(0,0,0,0));
    }
}
