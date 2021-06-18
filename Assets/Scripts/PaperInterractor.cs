using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaperInterractor : MonoBehaviour
{
    public void ShowNote()
    {
        SceneManager.LoadSceneAsync("SecBuildNote");
    }
}
