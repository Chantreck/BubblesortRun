using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healer : Entity
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            //Hero.Instance.GetHeal();
            //Die();

            if (Hero.Instance.GetHeal())
            {
                Die();
            }
        }
    }
}
