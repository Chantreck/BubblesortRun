using UnityEngine;
public class PlayerController1 : MonoBehaviour
{
    const double a0 = 0;
    const double a45 = 0.3826834;
    const double a90 = 0.7071068;
    const double a135 = 0.9238796;
    const double a180 = 1;

    public float currentSpeed = 5f;
    private Animator anim;
    private Vector2 size = new Vector2(5f, 5f);
    public int previousAngle = 0;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        if (verticalMovement != 0 || horizontalMovement != 0)
        {
            anim.SetInteger("state", 0);
        }
        else
        {
            anim.StopPlayback();
            anim.SetInteger("state", 1);
        }
        /*
        if(horizontalMovement == -1)
            if(previousAngle != 90)
            {
                Debug.Log(transform.rotation.z);
                transform.Rotate(0, 0, 90);
                previousAngle = 90;
            }
          */    
        
        if (horizontalMovement == -1)
        {
            if(verticalMovement == 1)
                rotate(45);
            if(verticalMovement == 0)
                rotate(90);
            if (verticalMovement == -1)
                rotate(135);
        } 
        
        if (horizontalMovement == 0)
        {
            if (verticalMovement == -1)
                rotate(180);
            //if (verticalMovement == 0)
            //    rotate(0);
            if (verticalMovement == 1)
                rotate(0);
        }
        if(horizontalMovement == 1)
        {
            if (verticalMovement == -1)
                rotate(225);
            if (verticalMovement == 0)
                rotate(270);
            if (verticalMovement == 1)
                rotate(315);
        }
       
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
    
    public void rotate(int angle)
    {
        //if (angle > 180) return;
        if (previousAngle != angle)
        {
            transform.Rotate(0, 0, angle - previousAngle);
            //transform.Rotate(0, 0, angle);
            previousAngle = angle;
            //Debug.Log(angle);
        }
    }
}