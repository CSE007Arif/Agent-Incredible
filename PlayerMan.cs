using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMan : MonoBehaviour {


    #region Singleton
    public static PlayerMan instance;
    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;
}
