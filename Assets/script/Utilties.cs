using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Utiltis : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    public void TestFunctie()
    {
        Debug.Log("De knop werkt!");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
