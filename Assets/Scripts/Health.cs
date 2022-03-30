using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float maxHealth = 5f;

    private float curentHealth;

    private void Awake()
    {
        curentHealth = maxHealth;
    }

    public void Hited(float damage)
    {
        curentHealth -= damage;
        if (curentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
