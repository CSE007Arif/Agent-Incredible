using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public string levelLoader;
    private float timer = 120f;
    private Text timerSec;
	// Use this for initialization
	void Start ()
    {
        timerSec = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        timerSec.text = timer.ToString("f0");
        if(timer <= 0f)
        {
           Application.LoadLevel(levelLoader);
        }
		
	}
    //public void LoadScene(string GameOver)
    //{
        //SceneManager.LoadScene(GameOver);
   // }
}
