using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("About Scene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("About Scene 2");
    }
}
