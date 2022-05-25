using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void PlayGameBtn(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGameBtn()
    {
        Application.Quit();
        Debug.Log("CLOSING GAME!");
    }
}
