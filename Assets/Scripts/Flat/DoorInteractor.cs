using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractor : MonoBehaviour
{
    public GameObject thoughts;
    public Camera camera;
    public Camera animCamera;
    public GameObject animCameraObject;
    public Transform player;
    public GameObject playerObject;
    private Vector3 pos;

    public void ExitRoom()
    {
        if (WardrobeInteractor.isSolved)
        {
            SceneManager.LoadSceneAsync("GardenToSecBuild");
        } else
        {
            camera.enabled = false;
            animCamera.enabled = true;
            pos = player.position;
            pos.y += 1f;
            pos.z = -10f;
            animCameraObject.transform.position = pos;
            playerObject.GetComponent<PlayerController1>().enabled = false;
            thoughts.SetActive(true);
        }
    }
}
