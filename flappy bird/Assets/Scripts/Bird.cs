using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force;                                 // переменная для силы прыжка
    Rigidbody2D BirdRigid;                              // нам нужен Rigidbody, а то птичка не будет прыгать

    public GameObject RestartButton;                    // это для кнопки

    void Start()
    {
        Time.timeScale = 1;                             //  скорость равна 1 - т.е. все норм работает
        BirdRigid = GetComponent<Rigidbody2D>();        //  получаем компонент Rigidbody
    }


    void Update()
    {
        if(transform.position.y < -5)
        {
            Destroy(gameObject);                        // то птичка уничтожаеся(
            Time.timeScale = 0;                         // время останавливается
            RestartButton.SetActive(true);              // кнопка рестарта появляется
        }
        if (Input.GetMouseButtonDown(0))                // если жмем на кнопку мыши или экран
        {
            BirdRigid.velocity = Vector2.up * force;    // как раз силу настраиваем
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)  // проверяем столкновение
    {
        if (collision.collider.tag == "Enemy")          // если тэг объекта "Enemy"
        {
            Destroy(gameObject);                        // то птичка уничтожаеся(
            Time.timeScale = 0;                         // время останавливается
            RestartButton.SetActive(true);              // кнопка рестарта появляется
        }
    }
}