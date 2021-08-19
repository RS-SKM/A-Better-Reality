using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class News : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject crossfadeStart;
    public DialogueManager dialogueManager;

    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            crossfadeStart.GetComponent<Backout>().LoadNextLevel();
        }
    }
}
