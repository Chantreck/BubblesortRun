using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hero : Entity
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 5;
    private int health = 5;
    [SerializeField] private float jumpForce = 15f;
    private bool isGrounded = false;
    private bool isGroundedInverted = false;
    public Transform groundCheck;
    public Transform groundCheckInvert;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;
    public bool isInverted;
    private Animator anim;

    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite aliveHeart;
    [SerializeField] private Sprite deadHeart;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    
    public static Hero Instance { get; set; }

    private void Awake()
    {
        anim = GetComponent<Animator>();
        health = 5;
        lives = health;
        isInverted = false;
        Instance = this;
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Run()
    {
        anim.SetBool("Run", true);
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }
    private void FixedUpdate()
    {
         isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //
         isGroundedInverted = Physics2D.OverlapCircle(groundCheckInvert.position, checkRadius, whatIsGround);
    }
    public void temp()
    {
        anim.SetBool("Run", false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            temp();
        if (isGrounded || isGroundedInverted) {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetButton("Horizontal"))
            Run();
        if (Input.GetButtonDown("Jump"))
            Jump();

        if (!Input.GetButton("Horizontal") && !Input.GetButtonDown("Jump"))
        {
            temp();
        }

        if (lives > health)
            lives = health;

        for(int i = 0; i < hearts.Length; i++)
        {
            if (i < lives)
                hearts[i].sprite = aliveHeart;
            else
                hearts[i].sprite = deadHeart;

            if (i < health)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
    }
    private void Jump()
    {
        if(isInverted)
        {
            if (extraJumps > 0)
            {
                rb.velocity = Vector2.down * jumpForce;
                extraJumps--;
            }
            else
                if (extraJumps == 0 && isGroundedInverted == true)
                    rb.velocity = Vector2.down * jumpForce;
        }
        else
        {
            if (extraJumps > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                extraJumps--;
            }
            else
                if (extraJumps == 0 && isGrounded == true)
                    rb.velocity = Vector2.down * jumpForce;
        }
        
    }

    public override void GetDamage()
    {
        if(isInverted == false)
        {
            lives -= 1;
            Debug.Log(lives);
            if (lives == 0)
                Die();
        }
        else
        {
            if (lives < health)
            {
                lives++;
            }
        }
        
    }

    public bool GetHeal()
    {
        if(isInverted == false)
        {
            if (lives < health)
            {
                lives++;
                return true;
            }
            else
                return false;
        }
        else
        {
            lives -= 1;
            Debug.Log(lives);
            if (lives == 0)
                Die();
            return true;
        }
            
    }

    public override void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Invert()
    {
        rb.gravityScale *= -1;
        sprite.flipY = !sprite.flipY;
        isInverted = !isInverted;
    }
}