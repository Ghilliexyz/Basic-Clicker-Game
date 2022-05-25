using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public string sceneName;
    public void PlayGameBtn()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGameBtn()
    {
        Application.Quit();
    }
}
