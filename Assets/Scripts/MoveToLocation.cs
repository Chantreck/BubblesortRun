using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLocation : MonoBehaviour
{
    public string SceneName;

    public void Transfer()
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
}
