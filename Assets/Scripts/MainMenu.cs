using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu: MonoBehaviour
{
    public string newGameScene;
    public string Credits;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void CreditScene()
    {
        SceneManager.LoadScene(Credits);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
