using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour
{

    public GameObject InfoPanel;
    public void OnPress()
    {
        InfoPanel.SetActive(true);
    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            InfoPanel.SetActive(false);
        }
    }
}
