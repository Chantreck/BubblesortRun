using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractor : MonoBehaviour
{
    public void ExitRoom()
    {
        if (WardrobeInteractor.isSolved)
        {
            SceneManager.LoadSceneAsync("Garden");
        }
    }
}
