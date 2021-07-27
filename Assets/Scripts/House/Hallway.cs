using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject spriteFade;
    public DialogueManager dialogueManager;

    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            spriteFade.GetComponent<LevelLoaderSpriteFade>().LoadNextLevel();
        }
    }
}
