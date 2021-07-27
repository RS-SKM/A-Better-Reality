using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarLady : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject crossfadeStart;
    public DialogueManager dialogueManager;
    private AudioSource audioManager;

    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        audioManager = FindObjectOfType<AudioManager>().GetComponent<AudioSource>();
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            crossfadeStart.GetComponent<LevelLoaderCrossfadeStart>().LoadNextLevel();
        }
    }
}