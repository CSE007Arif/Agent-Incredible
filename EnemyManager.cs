using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spwanPoints;
	
	void Start ()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
		
	}
    void Spawn()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }
        int spawnPointIndex = Random.Range(0, spwanPoints.Length);
        Instantiate(enemy, spwanPoints[spawnPointIndex].position, spwanPoints[spawnPointIndex].rotation);
    }
	
	
}
