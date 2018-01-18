using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigg : MonoBehaviour {

    public ParticleSystem explo;
     void OnCollisionEnter()
    {
        explo.Play();
    }
}
