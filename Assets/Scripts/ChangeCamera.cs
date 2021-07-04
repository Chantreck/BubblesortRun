using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera camera;
    public Camera animCamera;
    public GameObject animCameraObject;
    public Transform player;
    public GameObject playerObject;
    private Vector3 pos;

    public void MoveIn()
    {
        camera.enabled = false;
        animCamera.enabled = true;
        pos = player.position;
        pos.z = -10f;
        animCameraObject.transform.position = pos;
        playerObject.GetComponent<PlayerController1>().enabled = false;
    }

    public void MoveOut()
    {
        camera.enabled = true;
        animCamera.enabled = false;
        playerObject.GetComponent<PlayerController1>().enabled = true;
    }
}
