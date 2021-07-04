using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Opening");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
