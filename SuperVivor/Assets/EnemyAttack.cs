using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRadius = 1f; // The distance from the enemy at which it will start attacking
    public int damage = 1; // The amount of damage to be dealt to the player
    public float attackDelay = 1f; // The time in seconds between each attack
    public LayerMask playerLayer; // The layer that the player is on
    public PlayerHealth playerHealth; // A reference to the player's health script
    public bool canAttack = true;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        // Check if the player is within the attack radius and if enough time has passed since the last attack
        if (Vector2.Distance(transform.position, playerHealth.transform.position) < attackRadius)
        {
            if (canAttack)
            {
                // Start attacking the player
                Attack();
            }
        }
    }

    void cooldownAttack()
    {
        canAttack = true;
    }

    void Attack()
    {
        playerHealth.TakeDamage(damage);
        canAttack= false;
        Invoke("cooldownAttack", attackDelay);
    }
}
