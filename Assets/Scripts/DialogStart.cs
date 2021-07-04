using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogStart : MonoBehaviour
{
    public GameObject dialogue;

    public void Show()
    {
        dialogue.SetActive(true);
    }
}
