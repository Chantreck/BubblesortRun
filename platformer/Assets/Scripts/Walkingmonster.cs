using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkingmonster : Entity
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private float speed;

    private int currentIndex;
    private Vector2 currentPoint;
    private bool walking;
    private bool isDead = false;

    private void Start()
    {
        currentPoint = points[0].position;
        ChooseDirection();
        walking = true;
    }

    private void Update()
    {
        if (isDead) { return; }

        Walk();
    }

    private void Walk()
    {
        if (walking)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, currentPoint, step);
        
            if (Vector3.Distance(transform.position, currentPoint) < 0.5f)
            { 
                ChooseNextPoint();
            }
        }
    }

    private void ChooseNextPoint()
    {
        currentIndex = ++currentIndex < points.Count ? currentIndex : 0;
        currentPoint = points[currentIndex].position;
  
        ChooseDirection();
    }

    private void ChooseDirection()
    {
        GetComponentInChildren<SpriteRenderer>().flipX = !(currentPoint.x < transform.position.x);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
        }
    }

}
