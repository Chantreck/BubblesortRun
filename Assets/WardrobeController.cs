using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeController : MonoBehaviour
{
    private bool isOpen = false;

    public void OpenWardrobe()
    {
        if (!isOpen)
        {
            isOpen = true;
            print("Wardrobe is opened.");
        } else
        {
            isOpen = false;
            print("Wardrobe is closed.");
        }
    }
}
