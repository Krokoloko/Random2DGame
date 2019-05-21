using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public string sceneName;

    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
