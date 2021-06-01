using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float currentSpeed = 5f;
    Rigidbody2D rbody;

    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime * currentSpeed;
    }
}
