using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CutsceneTrigger : MonoBehaviour
{
    public bool wasRunned = false;
    public GameObject NPC;
    public GameObject paper;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !wasRunned)
        {
            wasRunned = true;
            NPC.SetActive(true);
            //SceneManager.LoadSceneAsync("SecondCutscene", LoadSceneMode.Additive);
        }
        if (collision.gameObject.CompareTag("NPC"))
        {
            paper.SetActive(true);
        }
    }
}
