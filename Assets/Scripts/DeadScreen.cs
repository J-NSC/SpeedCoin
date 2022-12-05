using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScreen : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadGameScene", 3.0f);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
