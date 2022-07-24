using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public int sceneToLoa;
    public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneToLoa);
        Debug.Log("Screen Loaded");
    }
}
