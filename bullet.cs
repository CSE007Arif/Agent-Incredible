using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    Transform player;

    public float speed = 10f;
    private int damage = 1;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        transform.Translate(0, 0, speed * Time. deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerInfo player = other.GetComponent<PlayerInfo>();
        if(player!=null)
        {
            player.Hurt(damage);
        
        }
        Destroy(this.gameObject);
    }
}
