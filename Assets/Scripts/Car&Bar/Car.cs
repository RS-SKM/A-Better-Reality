using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject crossfadeStart;
    public DialogueManager dialogueManager;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Ring");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            FindObjectOfType<AudioManager>().Play("Hung Up");
            crossfadeStart.GetComponent<LevelLoaderCrossfadeStart>().LoadNextLevel();
        }
    }
}