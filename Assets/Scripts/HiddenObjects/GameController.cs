using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int objectsRemain = 10;
    public static bool isLocked = false;
    public GameObject victoryMessage;
    public GameObject garbage;
    public GameObject background;

    // Update is called once per frame
    void Update()
    {
        if (objectsRemain == 0)
        {
            Win();
        }
    }

    void End()
    { 
        SceneManager.UnloadSceneAsync("HiddenObjects");
    }

    void Win()
    {
        garbage.SetActive(false);
        background.SetActive(false);
        victoryMessage.SetActive(true);
        StartCoroutine(Wait3Sec());
        WardrobeInteractor.isSolved = true;
        End();
    }

    IEnumerator Wait3Sec()
    {
        isLocked = true;
        yield return new WaitForSeconds(3.0f);
        isLocked = false;
    }
}
