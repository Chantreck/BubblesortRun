using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float currentSpeed = 5f;
    private Vector2 size = new Vector2(5f, 5f);

    void Start()
    {
        
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E))
        {
            CheckInteraction();
        }*/

        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime * currentSpeed;
    }

    public void ShowInteractableIcon(GameObject interactionObject)
    {
        interactionObject.SetActive(true);
    }

    public void HideInteractableIcon(GameObject interactionObject)
    {
        interactionObject.SetActive(false);
    }

    /*private void CheckInteraction()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, size, 0, Vector2.zero);

        if (hits.Length > 0)
        {
            foreach (RaycastHit2D hit in hits)
            {
                if (hit.transform.GetComponent<Interactable>())
                {
                    print("I'm trying to interact");
                    hit.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
    }*/
}
