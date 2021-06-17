using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WardrobeInteractor : MonoBehaviour
{
    public static bool isSolved = false;
    public GameObject message;

    public void OpenWardrobe()
    {
        if (!isSolved)
        {
            SceneManager.LoadSceneAsync("HiddenObjectsGame", LoadSceneMode.Additive);
        }
        else
        {

        }
    }
}
