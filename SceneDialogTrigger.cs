using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDialogTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public void TriggerDialogue()
    {
        FindObjectOfType<SceneDialogMan>().StartDialogue(dialogue);
    }
}
