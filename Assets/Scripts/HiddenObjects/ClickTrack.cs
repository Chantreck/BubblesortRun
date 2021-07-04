using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTrack : MonoBehaviour
{
    public static int TotalClick = 0;
    public KeyCode MouseClick;
    public GameObject blockMessage;

    //public static ClickTrack Instance { get; set; }

    void Start()
    {
        //Instance = this;
        blockMessage.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(MouseClick))
        {
            TotalClick += 1;
        }

        if (TotalClick >= 5)
        {
            TotalClick = 0;
            StartCoroutine(Wait5Sec());
        }
    }

    IEnumerator Wait5Sec()
    {
        GameController.isLocked = true;
        blockMessage.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        GameController.isLocked = false;
        blockMessage.SetActive(false);
    }
}
