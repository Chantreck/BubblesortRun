using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public GameObject label;

    void OnMouseDown()
    {
        if (!GameController.isLocked)
        {
            gameObject.SetActive(false);
            label.SetActive(false);
            GameController.objectsRemain--;
            ClickTrack.TotalClick = 0;
        }
    }
}
