using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    // public float lookRadius = 10f;
    //Transform target;
    private bool alive;
    Transform player;
    NavMeshAgent nav;
   //public GameObject bulletPrefab;
   // private GameObject _bullet; 
    void Start()
    {
        alive = true;
        //agent = GetComponent<NavMeshAgent>();
       //target = PlayerMan.instance.player.transform;
    }

   void Awake()
   {
       
        
            player = GameObject.FindGameObjectWithTag("Player").transform;
            nav = GetComponent<NavMeshAgent>();
        
        
    }

    void Update()
    {
        //GameObject hitObject = hitObject.transform.gameObject;
        // float distance = Vector3.Distance(target.position, transform.position);
        //if (distance <= lookRadius)
        //{
        // agent.SetDestination(target.position);
        //}
        if (alive)
        {
            nav.SetDestination(player.position);
           // _bullet = Instantiate(bulletPrefab) as GameObject;
            // _bullet.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
            // _bullet.transform.rotation = transform.rotation;
        }
        // GameObject hitObject = hitObject.transform.gameObject;
        //if(hitObject.GetComponent<PlayerInfo>())
        //{
        //if(_bullet==null)
        //{
        // _bullet = Instantiate(bulletPrefab) as GameObject;
        //  _bullet.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
        // _bullet.transform.rotation = transform.rotation;
        //}
        //}
    }
    public void SetAlive(bool _alive)
    {
        alive = _alive;
    }
    //void OnDrawGizmosSelected()
    //{
       // Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(transform.position, lookRadius);

   // }

}
