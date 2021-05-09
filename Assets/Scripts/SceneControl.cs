using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneControl : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ChangeToScene(string name)
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(name);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
