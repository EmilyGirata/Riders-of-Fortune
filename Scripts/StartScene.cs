using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Preview");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
