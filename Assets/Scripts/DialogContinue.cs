using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogContinue : MonoBehaviour
{
    public Animator animation;
    public GameObject dialogue;
    
    public void Continue()
    {
        dialogue.SetActive(false);
        if (animation != null)
        {
            animation.SetTrigger("Active");
        }
    }
}
