using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject explosion;
    
        public Transform e;
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);
            if(Physics.Raycast(ray,out hit,Mathf.Infinity))
            {
                Instantiate(explosion, e.position, transform.rotation = Quaternion.identity);
                Destroy(hit.transform.gameObject);
            }
        }
	}
}
