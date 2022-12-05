using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;


    // Start is called before the first frame update
    void Start()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void OptionsButton()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void BackOptions()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
