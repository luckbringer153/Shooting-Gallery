using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int dmg = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Targets t = collision.GetComponent<Targets>();

        if (t != null)
        {
            t.TakeDamage(dmg);
        }

        Destroy(gameObject);
    }




}
