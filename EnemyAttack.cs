﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {


    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 5;

    GameObject player;
    PlayerHealth playerHealth;
    bool playerInRange;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeBetweenAttacks && playerInRange)
        {
            Attack();
        }
        if(playerHealth.currentHealth<=0)
        {
            Debug.Log("D");
        }
    }

    void Attack()
    {
        timer = 0f;
        if(playerHealth.currentHealth>0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
