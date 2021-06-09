using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force;                                 // ���������� ��� ���� ������
    Rigidbody2D BirdRigid;                              // ��� ����� Rigidbody, � �� ������ �� ����� �������

    public GameObject RestartButton;                    // ��� ��� ������

    void Start()
    {
        Time.timeScale = 1;                             //  �������� ����� 1 - �.�. ��� ���� ��������
        BirdRigid = GetComponent<Rigidbody2D>();        //  �������� ��������� Rigidbody
    }


    void Update()
    {
        if(transform.position.y < -5)
        {
            Destroy(gameObject);                        // �� ������ �����������(
            Time.timeScale = 0;                         // ����� ���������������
            RestartButton.SetActive(true);              // ������ �������� ����������
        }
        if (Input.GetMouseButtonDown(0))                // ���� ���� �� ������ ���� ��� �����
        {
            BirdRigid.velocity = Vector2.up * force;    // ��� ��� ���� �����������
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)  // ��������� ������������
    {
        if (collision.collider.tag == "Enemy")          // ���� ��� ������� "Enemy"
        {
            Destroy(gameObject);                        // �� ������ �����������(
            Time.timeScale = 0;                         // ����� ���������������
            RestartButton.SetActive(true);              // ������ �������� ����������
        }
    }
}