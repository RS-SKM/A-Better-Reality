using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwaySmile : MonoBehaviour
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
            FindObjectOfType<AudioManager>().Play("Door");
            crossfadeStart.GetComponent<LevelLoaderCrossfadeStart>().LoadNextLevel();
        }
    }
}