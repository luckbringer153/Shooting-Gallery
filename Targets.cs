using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public int health = 1;
    public GameObject hitEffect;

    public void TakeDamage(int Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            ScoreDisplay.score += 1;
            Die();
        }
    }

    void Die()
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }

}
