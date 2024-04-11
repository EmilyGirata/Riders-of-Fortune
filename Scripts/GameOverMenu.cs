using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Game Over Scene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Preview");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("Loss Scene");
    }
}
