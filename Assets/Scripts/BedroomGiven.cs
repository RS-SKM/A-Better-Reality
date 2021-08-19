using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomGiven : MonoBehaviour
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
            crossfadeStart.GetComponent<LevelLoaderCrossfadeStart>().LoadNextLevel();
            FindObjectOfType<AudioManager>().Play("Door");
        }
    }
}
