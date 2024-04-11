using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Victory Scene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("You Win Scene");
    }
}
