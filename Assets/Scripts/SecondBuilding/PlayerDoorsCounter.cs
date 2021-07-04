using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorsCounter : MonoBehaviour
{
    private static bool FirstDoorChecked = false;
    private static bool SecondDoorChecked = false;
    private static bool ThirdDoorChecked = false;

    public GameObject dialog;
    public GameObject player;
    public GameObject DoorIsClosed;

    void Update()
    {
        if (FirstDoorChecked && SecondDoorChecked && ThirdDoorChecked)
        {
            player.GetComponent<PlayerController1>().enabled = false;
            DoorIsClosed.SetActive(false);
            dialog.SetActive(true);
        }
    }

    public void OpenFirstDoor()
    {
        FirstDoorChecked = true;
    }

    public void OpenSecondDoor()
    {
        SecondDoorChecked = true;
    }

    public void OpenThirdDoor()
    {
        ThirdDoorChecked = true;
    }
}
